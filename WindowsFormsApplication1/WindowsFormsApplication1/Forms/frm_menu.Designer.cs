namespace WindowsFormsApplication1
{
    partial class frm_menu
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
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.btn_pr = new System.Windows.Forms.Button();
            this.btn_sob = new System.Windows.Forms.Button();
            this.btn_beb = new System.Windows.Forms.Button();
            this.scroll_menu = new System.Windows.Forms.VScrollBar();
            this.panel_sobremesa = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_sobremesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 25);
            this.panel1.TabIndex = 3;
            // 
            // minimize
            // 
            this.minimize.Location = new System.Drawing.Point(808, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 2;
            this.minimize.Text = "_";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(839, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 25);
            this.exit.TabIndex = 1;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btn_pr
            // 
            this.btn_pr.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_pr.Location = new System.Drawing.Point(0, 25);
            this.btn_pr.Name = "btn_pr";
            this.btn_pr.Size = new System.Drawing.Size(288, 44);
            this.btn_pr.TabIndex = 5;
            this.btn_pr.Text = "PRATOS";
            this.btn_pr.UseVisualStyleBackColor = true;
            this.btn_pr.Click += new System.EventHandler(this.btn_pr_Click);
            // 
            // btn_sob
            // 
            this.btn_sob.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sob.Location = new System.Drawing.Point(576, 25);
            this.btn_sob.Name = "btn_sob";
            this.btn_sob.Size = new System.Drawing.Size(288, 44);
            this.btn_sob.TabIndex = 6;
            this.btn_sob.Text = "SOBREMESAS";
            this.btn_sob.UseVisualStyleBackColor = true;
            this.btn_sob.Click += new System.EventHandler(this.btn_sob_Click);
            // 
            // btn_beb
            // 
            this.btn_beb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_beb.Location = new System.Drawing.Point(288, 25);
            this.btn_beb.Name = "btn_beb";
            this.btn_beb.Size = new System.Drawing.Size(288, 44);
            this.btn_beb.TabIndex = 7;
            this.btn_beb.Text = "BEBIDAS";
            this.btn_beb.UseVisualStyleBackColor = true;
            this.btn_beb.Click += new System.EventHandler(this.btn_beb_Click);
            // 
            // scroll_menu
            // 
            this.scroll_menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.scroll_menu.Location = new System.Drawing.Point(847, 0);
            this.scroll_menu.Name = "scroll_menu";
            this.scroll_menu.Size = new System.Drawing.Size(17, 442);
            this.scroll_menu.TabIndex = 0;
            // 
            // panel_sobremesa
            // 
            this.panel_sobremesa.Controls.Add(this.scroll_menu);
            this.panel_sobremesa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_sobremesa.Location = new System.Drawing.Point(0, 69);
            this.panel_sobremesa.Name = "panel_sobremesa";
            this.panel_sobremesa.Size = new System.Drawing.Size(864, 442);
            this.panel_sobremesa.TabIndex = 4;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.btn_beb);
            this.Controls.Add(this.btn_sob);
            this.Controls.Add(this.btn_pr);
            this.Controls.Add(this.panel_sobremesa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel_sobremesa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btn_pr;
        private System.Windows.Forms.Button btn_sob;
        private System.Windows.Forms.Button btn_beb;
        private System.Windows.Forms.VScrollBar scroll_menu;
        private System.Windows.Forms.Panel panel_sobremesa;
    }
}