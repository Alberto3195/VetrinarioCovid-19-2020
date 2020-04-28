namespace VetrinarioCovid_19_20
{
    partial class VentanaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuario = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.registro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.login2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 533);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(12, 135);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(132, 23);
            this.usuario.TabIndex = 1;
            this.usuario.Text = "Nombre Usuario";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(12, 161);
            this.user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(208, 22);
            this.user.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(12, 222);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(208, 22);
            this.pass.TabIndex = 4;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(12, 196);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(132, 23);
            this.contraseña.TabIndex = 3;
            this.contraseña.Text = "Contraseña";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(12, 250);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(93, 51);
            this.login.TabIndex = 5;
            this.login.Text = "Login Usuario";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Location = new System.Drawing.Point(12, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 119);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // registro
            // 
            this.registro.Location = new System.Drawing.Point(62, 335);
            this.registro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(221, 47);
            this.registro.TabIndex = 7;
            this.registro.Text = "¿No tienes cuenta? Registrate como cliente";
            this.registro.UseVisualStyleBackColor = true;
            this.registro.Click += new System.EventHandler(this.registro_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 386);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "¿No tienes cuenta? Registrate como veterinario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // login2
            // 
            this.login2.Location = new System.Drawing.Point(127, 250);
            this.login2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login2.Name = "login2";
            this.login2.Size = new System.Drawing.Size(93, 51);
            this.login2.TabIndex = 10;
            this.login2.Text = "Login Veterinario";
            this.login2.UseVisualStyleBackColor = true;
            this.login2.Click += new System.EventHandler(this.login2_Click);
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 558);
            this.Controls.Add(this.login2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.user);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "VentanaLogin";
            this.Text = "Veterinaria El Sauce";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button registro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button login2;
    }
}