namespace Tutorial_Username
{
    partial class FormLogin
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
            this.BtnAcesso = new System.Windows.Forms.Button();
            this.LblUser = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAcesso
            // 
            this.BtnAcesso.Location = new System.Drawing.Point(84, 110);
            this.BtnAcesso.Name = "BtnAcesso";
            this.BtnAcesso.Size = new System.Drawing.Size(75, 29);
            this.BtnAcesso.TabIndex = 0;
            this.BtnAcesso.Text = "Acesso";
            this.BtnAcesso.UseVisualStyleBackColor = true;
            this.BtnAcesso.Click += new System.EventHandler(this.BtnAcesso_Click);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(12, 25);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(43, 13);
            this.LblUser.TabIndex = 1;
            this.LblUser.Text = "Usuário";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(84, 25);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(84, 61);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(100, 20);
            this.TxtSenha.TabIndex = 4;
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Location = new System.Drawing.Point(12, 61);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(38, 13);
            this.LblPass.TabIndex = 3;
            this.LblPass.Text = "Senha";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 172);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.BtnAcesso);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAcesso;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblPass;
    }
}