namespace WindowsFormsApplication1
{
	partial class frm_AddFood
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
            this.txb_nameFood = new System.Windows.Forms.TextBox();
            this.txb_DescFood = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txb_valor = new System.Windows.Forms.TextBox();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Imagem:";
            // 
            // txb_nameFood
            // 
            this.txb_nameFood.Location = new System.Drawing.Point(323, 92);
            this.txb_nameFood.Name = "txb_nameFood";
            this.txb_nameFood.Size = new System.Drawing.Size(100, 20);
            this.txb_nameFood.TabIndex = 1;
            // 
            // txb_DescFood
            // 
            this.txb_DescFood.Location = new System.Drawing.Point(323, 215);
            this.txb_DescFood.Name = "txb_DescFood";
            this.txb_DescFood.Size = new System.Drawing.Size(100, 20);
            this.txb_DescFood.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(323, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 158);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(603, 396);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Adicionar ";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(279, 142);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(34, 13);
            this.lbl_valor.TabIndex = 15;
            this.lbl_valor.Text = "Valor:";
            // 
            // txb_valor
            // 
            this.txb_valor.Location = new System.Drawing.Point(323, 139);
            this.txb_valor.Name = "txb_valor";
            this.txb_valor.Size = new System.Drawing.Size(100, 20);
            this.txb_valor.TabIndex = 2;
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Location = new System.Drawing.Point(323, 176);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(51, 23);
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // frm_AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.txb_valor);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txb_DescFood);
            this.Controls.Add(this.txb_nameFood);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar ao cardápio";
            this.Load += new System.EventHandler(this.frm_AddFood_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.TextBox txb_nameFood;
		private System.Windows.Forms.TextBox txb_DescFood;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Label lbl_valor;
		private System.Windows.Forms.TextBox txb_valor;
		private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Button btn_back;
    }
}