namespace WindowsFormsApplication1
{
	partial class frm_funcLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.txb_CodFun = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_cpffun = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 25);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(51, 23);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // minimize
            // 
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.Location = new System.Drawing.Point(830, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 4;
            this.minimize.Text = "_";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.Location = new System.Drawing.Point(855, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 25);
            this.exit.TabIndex = 5;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // txb_CodFun
            // 
            this.txb_CodFun.Location = new System.Drawing.Point(388, 269);
            this.txb_CodFun.MaxLength = 5;
            this.txb_CodFun.Name = "txb_CodFun";
            this.txb_CodFun.Size = new System.Drawing.Size(100, 20);
            this.txb_CodFun.TabIndex = 2;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(397, 319);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Logar";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPF do funcionário";
            // 
            // txb_cpffun
            // 
            this.txb_cpffun.Location = new System.Drawing.Point(388, 230);
            this.txb_cpffun.MaxLength = 11;
            this.txb_cpffun.Name = "txb_cpffun";
            this.txb_cpffun.Size = new System.Drawing.Size(100, 20);
            this.txb_cpffun.TabIndex = 1;
            // 
            // frm_funcLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 550);
            this.Controls.Add(this.txb_cpffun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txb_CodFun);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_funcLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_funsLogin";
            this.Load += new System.EventHandler(this.frm_funcLogin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button minimize;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.TextBox txb_CodFun;
		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txb_cpffun;
        private System.Windows.Forms.Button btn_back;
    }
}