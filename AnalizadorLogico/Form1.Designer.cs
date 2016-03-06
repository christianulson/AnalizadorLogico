namespace AnalizadorLogico
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.gv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btE = new System.Windows.Forms.Button();
            this.btOU = new System.Windows.Forms.Button();
            this.btSesomenteSe = new System.Windows.Forms.Button();
            this.btEntao = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btNegacao = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btOuExclusivo = new System.Windows.Forms.Button();
            this.tp = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.cb4 = new System.Windows.Forms.ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.cb5 = new System.Windows.Forms.ComboBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.cb6 = new System.Windows.Forms.ComboBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResLogico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Montar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(62, 70);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.ReadOnly = true;
            this.txtFormula.Size = new System.Drawing.Size(683, 20);
            this.txtFormula.TabIndex = 1;
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(13, 122);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(812, 410);
            this.gv.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Formula";
            // 
            // btE
            // 
            this.btE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btE.Location = new System.Drawing.Point(21, 15);
            this.btE.Name = "btE";
            this.btE.Size = new System.Drawing.Size(27, 36);
            this.btE.TabIndex = 4;
            this.btE.Text = "˄";
            this.btE.UseVisualStyleBackColor = true;
            this.btE.Click += new System.EventHandler(this.bt);
            // 
            // btOU
            // 
            this.btOU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOU.Location = new System.Drawing.Point(55, 15);
            this.btOU.Name = "btOU";
            this.btOU.Size = new System.Drawing.Size(27, 36);
            this.btOU.TabIndex = 5;
            this.btOU.Text = "˅";
            this.btOU.UseVisualStyleBackColor = true;
            this.btOU.Click += new System.EventHandler(this.bt);
            // 
            // btSesomenteSe
            // 
            this.btSesomenteSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSesomenteSe.Location = new System.Drawing.Point(191, 15);
            this.btSesomenteSe.Name = "btSesomenteSe";
            this.btSesomenteSe.Size = new System.Drawing.Size(27, 36);
            this.btSesomenteSe.TabIndex = 6;
            this.btSesomenteSe.Text = "↔";
            this.btSesomenteSe.UseVisualStyleBackColor = true;
            this.btSesomenteSe.Click += new System.EventHandler(this.bt);
            // 
            // btEntao
            // 
            this.btEntao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntao.Location = new System.Drawing.Point(157, 15);
            this.btEntao.Name = "btEntao";
            this.btEntao.Size = new System.Drawing.Size(27, 36);
            this.btEntao.TabIndex = 7;
            this.btEntao.Text = "→";
            this.btEntao.UseVisualStyleBackColor = true;
            this.btEntao.Click += new System.EventHandler(this.bt);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(293, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "(";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.bt);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(259, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 36);
            this.button5.TabIndex = 9;
            this.button5.Text = "↓";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.bt);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(225, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 36);
            this.button6.TabIndex = 10;
            this.button6.Text = "↑";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.bt);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(327, 15);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 36);
            this.button7.TabIndex = 11;
            this.button7.Text = ")";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.bt);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(395, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(27, 36);
            this.button8.TabIndex = 12;
            this.button8.Text = "]";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.bt);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(361, 15);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(27, 36);
            this.button9.TabIndex = 13;
            this.button9.Text = "[";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.bt);
            // 
            // btNegacao
            // 
            this.btNegacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNegacao.Location = new System.Drawing.Point(123, 15);
            this.btNegacao.Name = "btNegacao";
            this.btNegacao.Size = new System.Drawing.Size(27, 36);
            this.btNegacao.TabIndex = 14;
            this.btNegacao.Text = "~";
            this.btNegacao.UseVisualStyleBackColor = true;
            this.btNegacao.Click += new System.EventHandler(this.bt);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(429, 15);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(27, 36);
            this.button10.TabIndex = 15;
            this.button10.Text = "≠";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.bt);
            // 
            // btOuExclusivo
            // 
            this.btOuExclusivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOuExclusivo.Location = new System.Drawing.Point(89, 15);
            this.btOuExclusivo.Name = "btOuExclusivo";
            this.btOuExclusivo.Size = new System.Drawing.Size(27, 36);
            this.btOuExclusivo.TabIndex = 16;
            this.btOuExclusivo.Text = "⊕";
            this.btOuExclusivo.UseVisualStyleBackColor = true;
            this.btOuExclusivo.Click += new System.EventHandler(this.bt);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "q";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bt);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(116, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 36);
            this.button3.TabIndex = 18;
            this.button3.Text = "y";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.bt);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(46, 19);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(27, 36);
            this.button11.TabIndex = 19;
            this.button11.Text = "p";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.bt);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(81, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(27, 36);
            this.button12.TabIndex = 20;
            this.button12.Text = "w";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.bt);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(151, 19);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(27, 36);
            this.button13.TabIndex = 21;
            this.button13.Text = "z";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.bt);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(186, 19);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(27, 36);
            this.button14.TabIndex = 22;
            this.button14.Text = "x";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.bt);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(751, 41);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(74, 23);
            this.button15.TabIndex = 23;
            this.button15.Text = "Limpar";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Location = new System.Drawing.Point(13, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 66);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variávies";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btE);
            this.groupBox2.Controls.Add(this.btOU);
            this.groupBox2.Controls.Add(this.btOuExclusivo);
            this.groupBox2.Controls.Add(this.btSesomenteSe);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.btEntao);
            this.groupBox2.Controls.Add(this.btNegacao);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(261, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 62);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operadores";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(751, 13);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 26;
            this.button16.Text = "Apagar";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(88, 541);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Resultado";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(64, 101);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(20, 13);
            this.lbl1.TabIndex = 29;
            this.lbl1.Text = "V1";
            this.lbl1.Visible = false;
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "V",
            "F"});
            this.cb1.Location = new System.Drawing.Point(86, 97);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(32, 21);
            this.cb1.TabIndex = 30;
            this.cb1.Visible = false;
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "V",
            "F"});
            this.cb2.Location = new System.Drawing.Point(152, 97);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(32, 21);
            this.cb2.TabIndex = 32;
            this.cb2.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(130, 101);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(20, 13);
            this.lbl2.TabIndex = 31;
            this.lbl2.Text = "V2";
            this.lbl2.Visible = false;
            // 
            // cb3
            // 
            this.cb3.FormattingEnabled = true;
            this.cb3.Items.AddRange(new object[] {
            "V",
            "F"});
            this.cb3.Location = new System.Drawing.Point(218, 97);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(32, 21);
            this.cb3.TabIndex = 34;
            this.cb3.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(196, 101);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(20, 13);
            this.lbl3.TabIndex = 33;
            this.lbl3.Text = "V3";
            this.lbl3.Visible = false;
            // 
            // cb4
            // 
            this.cb4.FormattingEnabled = true;
            this.cb4.Items.AddRange(new object[] {
            "V",
            "F"});
            this.cb4.Location = new System.Drawing.Point(284, 97);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(32, 21);
            this.cb4.TabIndex = 36;
            this.cb4.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(262, 101);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(20, 13);
            this.lbl4.TabIndex = 35;
            this.lbl4.Text = "V4";
            this.lbl4.Visible = false;
            // 
            // cb5
            // 
            this.cb5.FormattingEnabled = true;
            this.cb5.Items.AddRange(new object[] {
            "V",
            "F"});
            this.cb5.Location = new System.Drawing.Point(350, 97);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(32, 21);
            this.cb5.TabIndex = 38;
            this.cb5.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(328, 101);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(20, 13);
            this.lbl5.TabIndex = 37;
            this.lbl5.Text = "V5";
            this.lbl5.Visible = false;
            // 
            // cb6
            // 
            this.cb6.FormattingEnabled = true;
            this.cb6.Items.AddRange(new object[] {
            "V",
            "F"});
            this.cb6.Location = new System.Drawing.Point(416, 97);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(32, 21);
            this.cb6.TabIndex = 40;
            this.cb6.Visible = false;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(394, 101);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(20, 13);
            this.lbl6.TabIndex = 39;
            this.lbl6.Text = "V6";
            this.lbl6.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Resultado Lógico";
            // 
            // lblResLogico
            // 
            this.lblResLogico.AutoSize = true;
            this.lblResLogico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResLogico.Location = new System.Drawing.Point(274, 541);
            this.lblResLogico.Name = "lblResLogico";
            this.lblResLogico.Size = new System.Drawing.Size(0, 13);
            this.lblResLogico.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 574);
            this.Controls.Add(this.lblResLogico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb6);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.txtFormula);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Vefiricador Logico by Christian Ulson";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btE;
        private System.Windows.Forms.Button btOU;
        private System.Windows.Forms.Button btSesomenteSe;
        private System.Windows.Forms.Button btEntao;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btNegacao;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btOuExclusivo;
        private System.Windows.Forms.ToolTip tp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox cb4;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ComboBox cb5;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.ComboBox cb6;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResLogico;
    }
}

