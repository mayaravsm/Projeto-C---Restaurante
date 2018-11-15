namespace WindowsFormsApplication1
{
    partial class frm_cliente
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
            this.btn_nextn = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_nextn
            // 
            this.btn_nextn.Location = new System.Drawing.Point(711, 447);
            this.btn_nextn.Name = "btn_nextn";
            this.btn_nextn.Size = new System.Drawing.Size(75, 23);
            this.btn_nextn.TabIndex = 3;
            this.btn_nextn.Text = "Próximo";
            this.btn_nextn.UseVisualStyleBackColor = true;
            this.btn_nextn.Click += new System.EventHandler(this.btn_nextn_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(379, 203);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(159, 20);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(298, 210);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(42, 13);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "NOME:";
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
            this.panel1.TabIndex = 6;
            // 
            // minimize
            // 
            this.minimize.Location = new System.Drawing.Point(821, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 4;
            this.minimize.Text = "_";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(852, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 25);
            this.exit.TabIndex = 5;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(298, 242);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(30, 13);
            this.lblcpf.TabIndex = 7;
            this.lblcpf.Text = "CPF:";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(379, 234);
            this.txtcpf.MaxLength = 11;
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(159, 20);
            this.txtcpf.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(3, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(51, 23);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // frm_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 550);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_nextn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nome";
            this.Load += new System.EventHandler(this.nome_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nextn;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Button btn_back;
    }
}