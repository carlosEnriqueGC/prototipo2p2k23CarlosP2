
namespace CapaVista
{
    partial class MantenimientoAlumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cargar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_alumno = new System.Windows.Forms.ComboBox();
            this.Salir = new System.Windows.Forms.Button();
            this.ayuda = new System.Windows.Forms.Button();
            this.Reporte = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARLOS ENRIQUE GUZMAN CABRERA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "9491-20-13013";
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(675, 140);
            this.cargar.Margin = new System.Windows.Forms.Padding(4);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(124, 55);
            this.cargar.TabIndex = 43;
            this.cargar.Text = "Cargar datos";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tabla: nombre de la tabla";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_alumno);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(32, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(523, 252);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Tabla";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cb_alumno
            // 
            this.cb_alumno.FormattingEnabled = true;
            this.cb_alumno.Location = new System.Drawing.Point(23, 136);
            this.cb_alumno.Margin = new System.Windows.Forms.Padding(4);
            this.cb_alumno.Name = "cb_alumno";
            this.cb_alumno.Size = new System.Drawing.Size(332, 24);
            this.cb_alumno.TabIndex = 12;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(675, 337);
            this.Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(124, 55);
            this.Salir.TabIndex = 42;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // ayuda
            // 
            this.ayuda.Location = new System.Drawing.Point(675, 203);
            this.ayuda.Margin = new System.Windows.Forms.Padding(4);
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(124, 55);
            this.ayuda.TabIndex = 44;
            this.ayuda.Text = "Ayudas";
            this.ayuda.UseVisualStyleBackColor = true;
            // 
            // Reporte
            // 
            this.Reporte.Location = new System.Drawing.Point(675, 272);
            this.Reporte.Margin = new System.Windows.Forms.Padding(4);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(124, 55);
            this.Reporte.TabIndex = 45;
            this.Reporte.Text = "Reporte";
            this.Reporte.UseVisualStyleBackColor = true;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // MantenimientoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 428);
            this.Controls.Add(this.Reporte);
            this.Controls.Add(this.ayuda);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoAlumno";
            this.Text = "MantenimientoAlumno";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_alumno;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button ayuda;
        private System.Windows.Forms.Button Reporte;
    }
}