using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AnalizadorLogico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tp.Show("E", btE);
            tp.Show("OU", btOU);
            tp.Show("Negação", btNegacao);
        }

        private int indice;

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                //var result = new DataTable().Compute("true AND false OR true", null);
                var operadores = new List<Tuple<char, string>>();
                operadores.Add(Tuple.Create('˄', " AND "));
                operadores.Add(Tuple.Create('˅', " OR "));
                operadores.Add(Tuple.Create('~', " NOT "));
                operadores.Add(Tuple.Create('⊕', ""));
                operadores.Add(Tuple.Create('→', ""));
                operadores.Add(Tuple.Create('↔', ""));

                var f = txtFormula.Text;
                var ff = new List<string>();
                foreach (var l in f.Where(char.IsLetter).Select(a => a.ToString()))
                {
                    if (!ff.Contains(l))
                        ff.Add(l);
                }
                var formula = f.Replace(" ", "");
                //var arrFormula = Regex.Split(formula, @"(\(|\)|(?<!e|E)-|(?<!e|E)\+|\*|/|\s+)");
                var arrFormula = Regex.Split(formula, @"(\(|\)|\[|\]|\{|\})");
                var operacao = new List<string>();
                var index = 0;
                foreach (var it in arrFormula)
                {
                    if (it == string.Empty)
                        continue;
                    if (it == "(" || it == "[" || it == "{")
                    {
                        index = index == 0 ? 0 : index - 1;
                        continue;
                    }
                    else if (it == ")" || it == "]" || it == "}")
                    {
                        index = index == operacao.Count ? operacao.Count : index + 1;
                        continue;
                    }
                    var arrit = it.Split(operadores.Select(a => a.Item1).ToArray());
                    var arrOp = new List<string>();
                    var first = true;
                    var i = 0;
                    arrOp.Add("");
                    foreach (var s in it)
                    {
                        if (operadores.Any(a => a.Item1 == s))
                        {
                            if (!first)
                            {
                                i++;
                                arrOp.Add("");
                            }
                            first = false;
                        }
                        arrOp[i] += s.ToString();
                    }
                    if (arrOp.Count > 1)
                    {
                        foreach (var o in arrOp)
                        {
                            operacao.Insert(o.StartsWith("~") && index > 0 ? index - 1 : index, o);
                            index++;
                        }
                    }
                    else
                        operacao.Insert(index, it);
                }
                for (int i = 1; i < operacao.Count; i++)
                {
                    if (!char.IsLetter(operacao[i].Last()))
                    {
                        var cc = operacao[i].Last();
                        operacao[i] = cc + operacao[i].Substring(0, operacao[i].Length - 1);
                    }
                }

                var linhas = Math.Pow(2, ff.Count);
                var dt = new DataTable();
                foreach (var a in ff)
                {
                    dt.Columns.Add(a.ToString(), typeof(string));
                    while (operacao.FindIndex(s => s == a) > -1)
                        operacao.RemoveAt(operacao.FindIndex(s => s == a));
                }
                foreach (var a in operacao)
                    dt.Columns.Add(a, typeof(string));

                for (var i = 0; i < linhas; i++)
                    dt.Rows.Add(dt.NewRow());
                var v = true;
                var m = linhas;
                int c;
                for (var j = 0; j < ff.Count; j++)
                {
                    m = m / 2;
                    c = 0;
                    v = true;
                    for (var i = 0; i < linhas; i++)
                    {
                        if (c == m)
                        {
                            v = !v;
                            c = 0;
                        }
                        dt.Rows[i][j] = v ? "V" : "F";
                        c++;
                    }
                }
                for (var i = 0; i < linhas; i++)
                {
                    for (var j = 0; j < operacao.Count; j++)
                    {
                        var ix = ff.Count + j;
                        //Regex.Split(formula, @"(\(|\)|\[|\]|\{|\})");
                        var arrOp = new List<string>();
                        foreach (var s in operacao[j])
                        {
                            if (operadores.Any(a => a.Item1 == s))
                                continue;
                            arrOp.Add(s.ToString());
                        }
                        var op = operacao[j];
                        if (op.Contains("⊕"))
                        {
                            dt.Rows[i][ix] = (dt.Rows[i][arrOp[0]].ToString() == "V" ^ dt.Rows[i][arrOp.Count == 1 ? operacao[j - 1] : arrOp[1]].ToString() == "V") ? "V" : "F";
                        }
                        else if (op.Contains("→"))
                        {
                            dt.Rows[i][ix] = (dt.Rows[i][arrOp[0]].ToString() == "V" && dt.Rows[i][arrOp.Count == 1 ? operacao[j - 1] : arrOp[1]].ToString() == "F") ? "F" : "V";
                        }
                        else if (op.Contains("↔"))
                        {
                            dt.Rows[i][ix] = dt.Rows[i][arrOp[0]].ToString() == dt.Rows[i][arrOp.Count == 1 ? operacao[j - 1] : arrOp[1]].ToString() ? "V" : "F";
                        }
                        else {
                            if (operadores.Any(a => a.Item1 == op.First()) && j - 1 > -1)
                                if (op.All(a => a == '~'))
                                    op += dt.Rows[i][operacao[j - 1]].ToString() == "V"
                                        ? "true"
                                        : "false";
                                else
                                    op = dt.Rows[i][operacao[j - 1]].ToString() == "V"
                                            ? "true"
                                            : "false"
                                        + op
                                        + (arrOp.Count == 0
                                            ? (dt.Rows[i][operacao[j - 2]].ToString() == "V"
                                                ? "true"
                                                : "false")
                                            : string.Empty);

                            foreach (var a in arrOp)
                                op = op.Replace(a, dt.Rows[i][a].ToString() == "V" ? "true" : "false");

                            foreach (var a in operadores)
                                op = op.Replace(a.Item1.ToString(), a.Item2);
                            op = op.Replace(" NOT NOT ", "");
                            dt.Rows[i][ix] = (bool)dt.Compute(op, null) ? "V" : "F";
                        }
                    }
                }
                var V = true;
                var F = true;
                var cl = dt.Columns.Count - 1;
                indice = -1;
                var w = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[cl].ToString() == "V")
                        F = false;
                    if (dr[cl].ToString() == "F")
                        V = false;
                    if (ff.Count == 1)
                    {
                        if (dr[lbl1.Text].ToString() == cb1.Text)
                            indice = w;
                    }
                    if (ff.Count == 2)
                    {
                        if (dr[lbl1.Text].ToString() == cb1.Text
                             && dr[lbl2.Text].ToString() == cb2.Text
                             )
                            indice = w;
                    }
                    if (ff.Count == 3)
                    {
                        if (dr[lbl1.Text].ToString() == cb1.Text
                             && dr[lbl2.Text].ToString() == cb2.Text
                             && dr[lbl3.Text].ToString() == cb3.Text
                             )
                            indice = w;
                    }
                    if (ff.Count == 4)
                    {
                        if (dr[lbl1.Text].ToString() == cb1.Text
                             && dr[lbl2.Text].ToString() == cb2.Text
                             && dr[lbl3.Text].ToString() == cb3.Text
                             && dr[lbl4.Text].ToString() == cb4.Text
                             )
                            indice = w;
                    }
                    if (ff.Count == 5)
                    {
                        if (dr[lbl1.Text].ToString() == cb1.Text
                             && dr[lbl2.Text].ToString() == cb2.Text
                             && dr[lbl3.Text].ToString() == cb3.Text
                             && dr[lbl4.Text].ToString() == cb4.Text
                             && dr[lbl5.Text].ToString() == cb5.Text
                             )
                            indice = w;
                    }
                    if (ff.Count == 6)
                    {
                        if (dr[lbl1.Text].ToString() == cb1.Text
                             && dr[lbl2.Text].ToString() == cb2.Text
                             && dr[lbl3.Text].ToString() == cb3.Text
                             && dr[lbl4.Text].ToString() == cb4.Text
                             && dr[lbl5.Text].ToString() == cb5.Text
                             && dr[lbl6.Text].ToString() == cb6.Text
                             )
                            indice = w;
                    }
                    w++;
                }

                gv.DataSource = dt;
                lblResultado.Text = "Contingência";
                if (V)
                {
                    gv.Columns[cl].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                    lblResultado.Text = "Tautologica";
                }
                if (F)
                {
                    gv.Columns[cl].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    lblResultado.Text = "Contraditória";
                }
                gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                gv.CellFormatting += Gv_CellFormatting;
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao executar formula.\nEx.:" + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void Gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.RowIndex == indice)
            {
                e.CellStyle.ForeColor = System.Drawing.Color.Blue;
                e.CellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif; ", 10, System.Drawing.FontStyle.Bold);
                if (e.ColumnIndex == gv.ColumnCount-1)
                {
                    lblResLogico.Text = e.Value.ToString();
                }
            }
        }

        private void bt(object sender, EventArgs e)
        {
            txtFormula.Text += " " + ((Button)sender).Text + " ";
            //txtFormula.Focus();

            ShowItems();
        }

        private void ShowItems()
        {
            var f = txtFormula.Text;
            var ff = new List<string>();
            foreach (var l in f.Where(char.IsLetter).Select(a => a.ToString()))
            {
                if (!ff.Contains(l))
                    ff.Add(l);
            }
            ShowRide(lbl1, cb1, 1, ff);
            ShowRide(lbl2, cb2, 2, ff);
            ShowRide(lbl3, cb3, 3, ff);
            ShowRide(lbl4, cb4, 4, ff);
            ShowRide(lbl5, cb5, 5, ff);
            ShowRide(lbl6, cb6, 6, ff);

            txtFormula.BackColor = System.Drawing.Color.White;
            if (!string.IsNullOrEmpty(txtFormula.Text))
            {
                f = f.Replace(" ","");
                if (f.EndsWith("~"))
                    txtFormula.BackColor = System.Drawing.Color.Red;
                var cc = f.ToList();
                var last = '@';
                var lastisLetther = false;
                for (int i = 1; i < cc.Count; i++){


                    last = cc[i];
                }
            }
        }

        private void ShowRide(Control lbl, Control cb, int ix, List<string> lst)
        {
            if (lst.Count >= ix)
            {
                lbl.Text = lst[ix-1];
                lbl.Visible = cb.Visible = true;
            }
            else
            {
                lbl.Visible = cb.Visible = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtFormula.Text = "";
            lblResultado.Text = "";
            gv.DataSource = null;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            cb1.Visible = false;
            cb2.Visible = false;
            cb3.Visible = false;
            cb4.Visible = false;
            cb5.Visible = false;
            cb6.Visible = false;
            ShowItems();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtFormula.Text.Length >= 3)
                txtFormula.Text = txtFormula.Text.Substring(0, txtFormula.Text.Length - 3);
            ShowItems();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
