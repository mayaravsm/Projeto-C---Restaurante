namespace WindowsFormsApplication1
{
	partial class frm_AddFuncionario
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
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_cpfFun = new System.Windows.Forms.TextBox();
            this.txb_nomeFun = new System.Windows.Forms.TextBox();
            this.txb_senhaFun = new System.Windows.Forms.TextBox();
            this.btn_addFun = new System.Windows.Forms.Button();
            this.cb_cargoFun = new System.Windows.Forms.ComboBox();
            this.lb_codFun = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.Location = new System.Drawing.Point(814, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 6;
            this.minimize.Text = "_";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.Location = new System.Drawing.Point(839, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 25);
            this.exit.TabIndex = 7;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 25);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cargo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha:";
            // 
            // txb_cpfFun
            // 
            this.txb_cpfFun.Location = new System.Drawing.Point(296, 144);
            this.txb_cpfFun.Name = "txb_cpfFun";
            this.txb_cpfFun.Size = new System.Drawing.Size(100, 20);
            this.txb_cpfFun.TabIndex = 1;
            // 
            // txb_nomeFun
            // 
            this.txb_nomeFun.Location = new System.Drawing.Point(296, 174);
            this.txb_nomeFun.Name = "txb_nomeFun";
            this.txb_nomeFun.Size = new System.Drawing.Size(100, 20);
            this.txb_nomeFun.TabIndex = 2;
            // 
            // txb_senhaFun
            // 
            this.txb_senhaFun.Location = new System.Drawing.Point(326, 260);
            this.txb_senhaFun.Name = "txb_senhaFun";
            this.txb_senhaFun.Size = new System.Drawing.Size(100, 20);
            this.txb_senhaFun.TabIndex = 4;
            // 
            // btn_addFun
            // 
            this.btn_addFun.Location = new System.Drawing.Point(296, 299);
            this.btn_addFun.Name = "btn_addFun";
            this.btn_addFun.Size = new System.Drawing.Size(75, 23);
            this.btn_addFun.TabIndex = 5;
            this.btn_addFun.Text = "Adicionar";
            this.btn_addFun.UseVisualStyleBackColor = true;
            this.btn_addFun.Click += new System.EventHandler(this.btn_addFun_Click);
            // 
            // cb_cargoFun
            // 
            this.cb_cargoFun.FormattingEnabled = true;
            this.cb_cargoFun.Location = new System.Drawing.Point(296, 209);
            this.cb_cargoFun.Name = "cb_cargoFun";
            this.cb_cargoFun.Size = new System.Drawing.Size(121, 21);
            this.cb_cargoFun.TabIndex = 3;
            this.cb_cargoFun.SelectedIndexChanged += new System.EventHandler(this.cb_cargoFun_SelectedIndexChanged);
            // 
            // lb_codFun
            // 
            this.lb_codFun.AutoSize = true;
            this.lb_codFun.Location = new System.Drawing.Point(285, 263);
            this.lb_codFun.Name = "lb_codFun";
            this.lb_codFun.Size = new System.Drawing.Size(0, 13);
            this.lb_codFun.TabIndex = 10;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(51, 23);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // frm_AddFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.lb_codFun);
            this.Controls.Add(this.cb_cargoFun);
            this.Controls.Add(this.btn_addFun);
            this.Controls.Add(this.txb_senhaFun);
            this.Controls.Add(this.txb_nomeFun);
            this.Controls.Add(this.txb_cpfFun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AddFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddFuncionario";
            this.Load += new System.EventHandler(this.frm_AddFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button minimize;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txb_cpfFun;
		private System.Windows.Forms.TextBox txb_nomeFun;
		private System.Windows.Forms.TextBox txb_senhaFun;
		private System.Windows.Forms.Button btn_addFun;
		private System.Windows.Forms.ComboBox cb_cargoFun;
		private System.Windows.Forms.Label lb_codFun;
        private System.Windows.Forms.Button btn_back;
    }
}