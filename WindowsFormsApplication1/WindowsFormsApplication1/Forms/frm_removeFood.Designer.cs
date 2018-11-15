namespace WindowsFormsApplication1
{
    partial class frm_removeFood
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
            this.scroll_menu = new System.Windows.Forms.VScrollBar();
            this.grid_remove = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_remPr = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_remove)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.Location = new System.Drawing.Point(814, 0);
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
            this.exit.Location = new System.Drawing.Point(839, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 25);
            this.exit.TabIndex = 3;
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
            // scroll_menu
            // 
            this.scroll_menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.scroll_menu.Location = new System.Drawing.Point(847, 25);
            this.scroll_menu.Name = "scroll_menu";
            this.scroll_menu.Size = new System.Drawing.Size(17, 486);
            this.scroll_menu.TabIndex = 6;
            // 
            // grid_remove
            // 
            this.grid_remove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_remove.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid_remove.Location = new System.Drawing.Point(0, 25);
            this.grid_remove.Name = "grid_remove";
            this.grid_remove.Size = new System.Drawing.Size(847, 403);
            this.grid_remove.TabIndex = 7;
            this.grid_remove.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_remove_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_remPr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 85);
            this.panel2.TabIndex = 8;
            // 
            // btn_remPr
            // 
            this.btn_remPr.Location = new System.Drawing.Point(700, 27);
            this.btn_remPr.Name = "btn_remPr";
            this.btn_remPr.Size = new System.Drawing.Size(75, 23);
            this.btn_remPr.TabIndex = 0;
            this.btn_remPr.Text = "Remover";
            this.btn_remPr.UseVisualStyleBackColor = true;
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
            // frm_removeFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grid_remove);
            this.Controls.Add(this.scroll_menu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MinimizeBox = false;
            this.Name = "frm_removeFood";
            this.Text = "frm_removeFood";
            this.Load += new System.EventHandler(this.frm_removeFood_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_remove)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar scroll_menu;
        private System.Windows.Forms.DataGridView grid_remove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_remPr;
        private System.Windows.Forms.Button btn_back;
    }
}