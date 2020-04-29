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
            this.nom = new System.Windows.Forms.TextBox();
            this.tip = new System.Windows.Forms.TextBox();
            this.raz = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.Sexo = new System.Windows.Forms.Label();
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
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(120, 87);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(186, 22);
            this.nom.TabIndex = 4;
            // 
            // tip
            // 
            this.tip.Location = new System.Drawing.Point(120, 129);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(186, 22);
            this.tip.TabIndex = 5;
            // 
            // raz
            // 
            this.raz.Location = new System.Drawing.Point(120, 184);
            this.raz.Name = "raz";
            this.raz.Size = new System.Drawing.Size(186, 22);
            this.raz.TabIndex = 6;
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(95, 340);
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "DNI";
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(119, 239);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(186, 22);
            this.DNI.TabIndex = 12;
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(120, 285);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(186, 22);
            this.sex.TabIndex = 13;
            // 
            // Sexo
            // 
            this.Sexo.Location = new System.Drawing.Point(12, 284);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(100, 23);
            this.Sexo.TabIndex = 14;
            this.Sexo.Text = "Sexo";
            // 
            // RegistroMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 418);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.raz);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.nom);
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
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.TextBox raz;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DNI;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.Label Sexo;
    }
}