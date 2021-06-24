namespace Almacenamiento_Arreglos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.brnAsc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edad :";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(102, 108);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(76, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(103, 166);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.FormattingEnabled = true;
            this.cmbEstudiante.Location = new System.Drawing.Point(312, 124);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(121, 21);
            this.cmbEstudiante.TabIndex = 5;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(351, 94);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(57, 13);
            this.lblEstudiante.TabIndex = 6;
            this.lblEstudiante.Text = "Estudiante";
            // 
            // brnAsc
            // 
            this.brnAsc.Location = new System.Drawing.Point(320, 192);
            this.brnAsc.Name = "brnAsc";
            this.brnAsc.Size = new System.Drawing.Size(88, 23);
            this.brnAsc.TabIndex = 7;
            this.brnAsc.Text = "Ascendente";
            this.brnAsc.UseVisualStyleBackColor = true;
            this.brnAsc.Click += new System.EventHandler(this.brnAsc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ordenarlos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brnAsc);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.cmbEstudiante);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ComboBox cmbEstudiante;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Button brnAsc;
        private System.Windows.Forms.Label label2;
    }
}

