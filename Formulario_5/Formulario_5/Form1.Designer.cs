namespace Formulario_5
{
    partial class Form1
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
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.Lb_Apellido = new System.Windows.Forms.Label();
            this.Lb_Telefono = new System.Windows.Forms.Label();
            this.Lb_Estatura = new System.Windows.Forms.Label();
            this.Lb_Edad = new System.Windows.Forms.Label();
            this.GB_Genero = new System.Windows.Forms.GroupBox();
            this.rdb_Mujer = new System.Windows.Forms.RadioButton();
            this.radbtn_Hombre = new System.Windows.Forms.RadioButton();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_Apellido = new System.Windows.Forms.TextBox();
            this.TB_Telefono = new System.Windows.Forms.TextBox();
            this.TB_Estatura = new System.Windows.Forms.TextBox();
            this.TB_Edad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.GB_Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_Nombre
            // 
            this.Lb_Nombre.AutoSize = true;
            this.Lb_Nombre.Location = new System.Drawing.Point(49, 58);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(59, 16);
            this.Lb_Nombre.TabIndex = 0;
            this.Lb_Nombre.Text = "Nombre:";
            // 
            // Lb_Apellido
            // 
            this.Lb_Apellido.AutoSize = true;
            this.Lb_Apellido.Location = new System.Drawing.Point(49, 102);
            this.Lb_Apellido.Name = "Lb_Apellido";
            this.Lb_Apellido.Size = new System.Drawing.Size(67, 16);
            this.Lb_Apellido.TabIndex = 1;
            this.Lb_Apellido.Text = "Apellidos:";
            // 
            // Lb_Telefono
            // 
            this.Lb_Telefono.AutoSize = true;
            this.Lb_Telefono.Location = new System.Drawing.Point(49, 141);
            this.Lb_Telefono.Name = "Lb_Telefono";
            this.Lb_Telefono.Size = new System.Drawing.Size(64, 16);
            this.Lb_Telefono.TabIndex = 2;
            this.Lb_Telefono.Text = "Telefono:";
            // 
            // Lb_Estatura
            // 
            this.Lb_Estatura.AutoSize = true;
            this.Lb_Estatura.Location = new System.Drawing.Point(49, 183);
            this.Lb_Estatura.Name = "Lb_Estatura";
            this.Lb_Estatura.Size = new System.Drawing.Size(59, 16);
            this.Lb_Estatura.TabIndex = 3;
            this.Lb_Estatura.Text = "Estatura:";
            // 
            // Lb_Edad
            // 
            this.Lb_Edad.AutoSize = true;
            this.Lb_Edad.Location = new System.Drawing.Point(49, 226);
            this.Lb_Edad.Name = "Lb_Edad";
            this.Lb_Edad.Size = new System.Drawing.Size(43, 16);
            this.Lb_Edad.TabIndex = 4;
            this.Lb_Edad.Text = "Edad:";
            // 
            // GB_Genero
            // 
            this.GB_Genero.Controls.Add(this.rdb_Mujer);
            this.GB_Genero.Controls.Add(this.radbtn_Hombre);
            this.GB_Genero.Location = new System.Drawing.Point(12, 287);
            this.GB_Genero.Name = "GB_Genero";
            this.GB_Genero.Size = new System.Drawing.Size(331, 81);
            this.GB_Genero.TabIndex = 5;
            this.GB_Genero.TabStop = false;
            this.GB_Genero.Text = "Genero";
            // 
            // rdb_Mujer
            // 
            this.rdb_Mujer.AutoSize = true;
            this.rdb_Mujer.Location = new System.Drawing.Point(210, 39);
            this.rdb_Mujer.Name = "rdb_Mujer";
            this.rdb_Mujer.Size = new System.Drawing.Size(61, 20);
            this.rdb_Mujer.TabIndex = 14;
            this.rdb_Mujer.TabStop = true;
            this.rdb_Mujer.Text = "Mujer";
            this.rdb_Mujer.UseVisualStyleBackColor = true;
            // 
            // radbtn_Hombre
            // 
            this.radbtn_Hombre.AutoSize = true;
            this.radbtn_Hombre.Location = new System.Drawing.Point(64, 39);
            this.radbtn_Hombre.Name = "radbtn_Hombre";
            this.radbtn_Hombre.Size = new System.Drawing.Size(77, 20);
            this.radbtn_Hombre.TabIndex = 13;
            this.radbtn_Hombre.TabStop = true;
            this.radbtn_Hombre.Text = "Hombre";
            this.radbtn_Hombre.UseVisualStyleBackColor = true;
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(202, 58);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(100, 22);
            this.TB_Nombre.TabIndex = 6;
            // 
            // TB_Apellido
            // 
            this.TB_Apellido.Location = new System.Drawing.Point(202, 99);
            this.TB_Apellido.Name = "TB_Apellido";
            this.TB_Apellido.Size = new System.Drawing.Size(100, 22);
            this.TB_Apellido.TabIndex = 7;
            // 
            // TB_Telefono
            // 
            this.TB_Telefono.Location = new System.Drawing.Point(202, 135);
            this.TB_Telefono.Name = "TB_Telefono";
            this.TB_Telefono.Size = new System.Drawing.Size(100, 22);
            this.TB_Telefono.TabIndex = 8;
            // 
            // TB_Estatura
            // 
            this.TB_Estatura.Location = new System.Drawing.Point(202, 177);
            this.TB_Estatura.Name = "TB_Estatura";
            this.TB_Estatura.Size = new System.Drawing.Size(100, 22);
            this.TB_Estatura.TabIndex = 9;
            // 
            // TB_Edad
            // 
            this.TB_Edad.Location = new System.Drawing.Point(202, 220);
            this.TB_Edad.Name = "TB_Edad";
            this.TB_Edad.Size = new System.Drawing.Size(100, 22);
            this.TB_Edad.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(76, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(226, 106);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(76, 517);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(226, 106);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 645);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.TB_Edad);
            this.Controls.Add(this.TB_Estatura);
            this.Controls.Add(this.TB_Telefono);
            this.Controls.Add(this.TB_Apellido);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.GB_Genero);
            this.Controls.Add(this.Lb_Edad);
            this.Controls.Add(this.Lb_Estatura);
            this.Controls.Add(this.Lb_Telefono);
            this.Controls.Add(this.Lb_Apellido);
            this.Controls.Add(this.Lb_Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_Genero.ResumeLayout(false);
            this.GB_Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Nombre;
        private System.Windows.Forms.Label Lb_Apellido;
        private System.Windows.Forms.Label Lb_Telefono;
        private System.Windows.Forms.Label Lb_Estatura;
        private System.Windows.Forms.Label Lb_Edad;
        private System.Windows.Forms.GroupBox GB_Genero;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_Apellido;
        private System.Windows.Forms.TextBox TB_Telefono;
        private System.Windows.Forms.TextBox TB_Estatura;
        private System.Windows.Forms.TextBox TB_Edad;
        private System.Windows.Forms.RadioButton rdb_Mujer;
        private System.Windows.Forms.RadioButton radbtn_Hombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}

