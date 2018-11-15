namespace WindowsFormsApplication1
{
	partial class frm_admLogado
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
            this.btn_newFood = new System.Windows.Forms.Button();
            this.btn_newFun = new System.Windows.Forms.Button();
            this.btn_Dellfun = new System.Windows.Forms.Button();
            this.btn_DelFood = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.Location = new System.Drawing.Point(830, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 5;
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
            this.exit.TabIndex = 6;
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
            this.panel1.Size = new System.Drawing.Size(880, 25);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btn_newFood
            // 
            this.btn_newFood.Location = new System.Drawing.Point(363, 135);
            this.btn_newFood.Name = "btn_newFood";
            this.btn_newFood.Size = new System.Drawing.Size(152, 23);
            this.btn_newFood.TabIndex = 1;
            this.btn_newFood.Text = "Adicionar um novo prato";
            this.btn_newFood.UseVisualStyleBackColor = true;
            this.btn_newFood.Click += new System.EventHandler(this.btn_newFood_Click);
            // 
            // btn_newFun
            // 
            this.btn_newFun.Location = new System.Drawing.Point(363, 201);
            this.btn_newFun.Name = "btn_newFun";
            this.btn_newFun.Size = new System.Drawing.Size(161, 23);
            this.btn_newFun.TabIndex = 2;
            this.btn_newFun.Text = "Adicionar um novo funcionário";
            this.btn_newFun.UseVisualStyleBackColor = true;
            this.btn_newFun.Click += new System.EventHandler(this.btn_newFun_Click);
            // 
            // btn_Dellfun
            // 
            this.btn_Dellfun.Location = new System.Drawing.Point(363, 333);
            this.btn_Dellfun.Name = "btn_Dellfun";
            this.btn_Dellfun.Size = new System.Drawing.Size(161, 23);
            this.btn_Dellfun.TabIndex = 4;
            this.btn_Dellfun.Text = "Remover um funcionário";
            this.btn_Dellfun.UseVisualStyleBackColor = true;
            this.btn_Dellfun.Click += new System.EventHandler(this.btn_Dellfun_Click);
            // 
            // btn_DelFood
            // 
            this.btn_DelFood.Location = new System.Drawing.Point(363, 267);
            this.btn_DelFood.Name = "btn_DelFood";
            this.btn_DelFood.Size = new System.Drawing.Size(152, 23);
            this.btn_DelFood.TabIndex = 3;
            this.btn_DelFood.Text = "Remover um prato";
            this.btn_DelFood.UseVisualStyleBackColor = true;
            this.btn_DelFood.Click += new System.EventHandler(this.btn_DelFood_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(3, 1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(51, 23);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // frm_admLogado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 550);
            this.Controls.Add(this.btn_Dellfun);
            this.Controls.Add(this.btn_DelFood);
            this.Controls.Add(this.btn_newFun);
            this.Controls.Add(this.btn_newFood);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_admLogado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_funcLogado";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button minimize;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_newFood;
		private System.Windows.Forms.Button btn_newFun;
		private System.Windows.Forms.Button btn_Dellfun;
		private System.Windows.Forms.Button btn_DelFood;
        private System.Windows.Forms.Button btn_back;
    }
}