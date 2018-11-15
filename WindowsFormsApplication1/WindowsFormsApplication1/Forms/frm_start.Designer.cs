namespace WindowsFormsApplication1
{
    partial class frm_start
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_start));
			this.btn_inicio = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.minimize = new System.Windows.Forms.Button();
			this.settings = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_inicio
			// 
			this.btn_inicio.Location = new System.Drawing.Point(329, 189);
			this.btn_inicio.Name = "btn_inicio";
			this.btn_inicio.Size = new System.Drawing.Size(153, 117);
			this.btn_inicio.TabIndex = 1;
			this.btn_inicio.Text = "Faça seu pedido";
			this.btn_inicio.UseVisualStyleBackColor = true;
			this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
			// 
			// exit
			// 
			this.exit.Location = new System.Drawing.Point(855, 0);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(25, 25);
			this.exit.TabIndex = 4;
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
			this.panel1.Size = new System.Drawing.Size(880, 25);
			this.panel1.TabIndex = 2;
			// 
			// minimize
			// 
			this.minimize.Location = new System.Drawing.Point(824, 0);
			this.minimize.Name = "minimize";
			this.minimize.Size = new System.Drawing.Size(25, 25);
			this.minimize.TabIndex = 3;
			this.minimize.Text = "_";
			this.minimize.UseVisualStyleBackColor = true;
			this.minimize.Click += new System.EventHandler(this.minimize_Click);
			// 
			// settings
			// 
			this.settings.BackColor = System.Drawing.Color.Transparent;
			this.settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settings.BackgroundImage")));
			this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.settings.FlatAppearance.BorderSize = 0;
			this.settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.settings.Location = new System.Drawing.Point(12, 31);
			this.settings.Name = "settings";
			this.settings.Size = new System.Drawing.Size(30, 30);
			this.settings.TabIndex = 2;
			this.settings.UseVisualStyleBackColor = false;
			this.settings.Click += new System.EventHandler(this.settings_Click);
			// 
			// frm_start
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 550);
			this.Controls.Add(this.settings);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_inicio);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frm_start";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "tela_inicial";
			this.Load += new System.EventHandler(this.start_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button settings;
    }
}

