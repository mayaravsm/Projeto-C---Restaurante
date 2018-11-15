namespace WindowsFormsApplication1
{
	partial class frm_garLogado
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
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 25);
            this.panel1.TabIndex = 6;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(51, 23);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // frm_garLogado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_garLogado";
            this.Text = "frm_garLogado";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button minimize;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
    }
}