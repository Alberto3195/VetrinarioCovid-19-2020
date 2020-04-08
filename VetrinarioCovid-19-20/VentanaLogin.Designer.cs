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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 22);
            this.textBox2.TabIndex = 4;
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
            this.login.Location = new System.Drawing.Point(12, 259);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(93, 25);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 557);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaLogin";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.Button login;
    }
}