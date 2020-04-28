namespace VetrinarioCovid_19_20
{
    partial class LoginVeterinario
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
            this.login = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(12, 258);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(93, 30);
            this.login.TabIndex = 10;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(12, 230);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(208, 22);
            this.pass.TabIndex = 9;
            // 
            // contraseña
            // 
            this.contraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contraseña.Location = new System.Drawing.Point(12, 204);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(132, 23);
            this.contraseña.TabIndex = 8;
            this.contraseña.Text = "Contraseña";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(12, 169);
            this.user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(208, 22);
            this.user.TabIndex = 7;
            // 
            // usuario
            // 
            this.usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usuario.Location = new System.Drawing.Point(12, 143);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(132, 23);
            this.usuario.TabIndex = 6;
            this.usuario.Text = "Nombre Usuario";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Location = new System.Drawing.Point(12, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 119);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // LoginVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(345, 306);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.user);
            this.Controls.Add(this.usuario);
            this.Name = "LoginVeterinario";
            this.Text = "Veterinaria El Sauce";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}