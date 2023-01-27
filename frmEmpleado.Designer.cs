namespace TP7CoyRoldanPablo
{
    partial class frmEmpleado
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblCasado = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textSalario = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(30, 77);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(30, 122);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";
            // 
            // lblCasado
            // 
            this.lblCasado.AutoSize = true;
            this.lblCasado.Location = new System.Drawing.Point(30, 167);
            this.lblCasado.Name = "lblCasado";
            this.lblCasado.Size = new System.Drawing.Size(65, 13);
            this.lblCasado.TabIndex = 3;
            this.lblCasado.Text = "Estado Civil:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(30, 214);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salario:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(118, 37);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(181, 20);
            this.textNombre.TabIndex = 5;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(118, 77);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(181, 20);
            this.textDni.TabIndex = 6;
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(118, 122);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(181, 20);
            this.textEdad.TabIndex = 7;
            // 
            // textSalario
            // 
            this.textSalario.Location = new System.Drawing.Point(118, 206);
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(181, 20);
            this.textSalario.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(33, 273);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(210, 273);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Soltero"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(118, 164);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(181, 21);
            this.cmbEstadoCivil.TabIndex = 12;
            this.cmbEstadoCivil.Text = "Seleccione";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 317);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textSalario);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblCasado);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmEmpleado";
            this.Text = "Nuevo Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblCasado;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textSalario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
    }
}