namespace VetrinarioCovid_19_20
{
    partial class RegistroMascota
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
            this.Nombre = new System.Windows.Forms.Label();
            this.Raza = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(13, 87);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 23);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // Raza
            // 
            this.Raza.Location = new System.Drawing.Point(13, 187);
            this.Raza.Name = "Raza";
            this.Raza.Size = new System.Drawing.Size(100, 23);
            this.Raza.TabIndex = 2;
            this.Raza.Text = "Raza";
            // 
            // Tipo
            // 
            this.Tipo.Location = new System.Drawing.Point(13, 132);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(100, 23);
            this.Tipo.TabIndex = 3;
            this.Tipo.Text = "Tipo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 22);
            this.textBox3.TabIndex = 6;
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(98, 234);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(121, 47);
            this.Registrar.TabIndex = 8;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(120, 37);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(186, 22);
            this.ID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // RegistroMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 299);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.Raza);
            this.Controls.Add(this.Nombre);
            this.Name = "RegistroMascota";
            this.Text = "Registre su mascota";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistroMascota_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Raza;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
    }
}