namespace WindowsFormsApplication1.Forms
{
    partial class frm_removeFunc
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
            this.pnl_baixo = new System.Windows.Forms.Panel();
            this.btn_remF = new System.Windows.Forms.Button();
            this.grid_removeF = new System.Windows.Forms.DataGridView();
            this.scroll_menu = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_baixo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_removeF)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_baixo
            // 
            this.pnl_baixo.Controls.Add(this.btn_remF);
            this.pnl_baixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_baixo.Location = new System.Drawing.Point(0, 426);
            this.pnl_baixo.Name = "pnl_baixo";
            this.pnl_baixo.Size = new System.Drawing.Size(847, 85);
            this.pnl_baixo.TabIndex = 12;
            // 
            // btn_remF
            // 
            this.btn_remF.Location = new System.Drawing.Point(700, 27);
            this.btn_remF.Name = "btn_remF";
            this.btn_remF.Size = new System.Drawing.Size(75, 23);
            this.btn_remF.TabIndex = 0;
            this.btn_remF.Text = "Remover";
            this.btn_remF.UseVisualStyleBackColor = true;
            // 
            // grid_removeF
            // 
            this.grid_removeF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_removeF.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid_removeF.Location = new System.Drawing.Point(0, 25);
            this.grid_removeF.Name = "grid_removeF";
            this.grid_removeF.Size = new System.Drawing.Size(847, 404);
            this.grid_removeF.TabIndex = 11;
            this.grid_removeF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_removeF_CellContentClick);
            // 
            // scroll_menu
            // 
            this.scroll_menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.scroll_menu.Location = new System.Drawing.Point(847, 25);
            this.scroll_menu.Name = "scroll_menu";
            this.scroll_menu.Size = new System.Drawing.Size(17, 486);
            this.scroll_menu.TabIndex = 10;
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
            this.panel1.TabIndex = 9;
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
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(3, 1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(51, 23);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // frm_removeFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.pnl_baixo);
            this.Controls.Add(this.grid_removeF);
            this.Controls.Add(this.scroll_menu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_removeFunc";
            this.Text = "frm_removeFunc";
            this.Load += new System.EventHandler(this.frm_removeFunc_Load);
            this.pnl_baixo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_removeF)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_baixo;
        private System.Windows.Forms.Button btn_remF;
        private System.Windows.Forms.DataGridView grid_removeF;
        private System.Windows.Forms.VScrollBar scroll_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btn_back;
    }
}