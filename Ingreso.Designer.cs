namespace uprofe
{
    partial class Ingreso
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
            this.ingresoProfe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_reporte = new System.Windows.Forms.DataGridView();
            this.salir = new System.Windows.Forms.Button();
            this.eliminarRegistro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Mes = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // ingresoProfe
            // 
            this.ingresoProfe.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoProfe.Location = new System.Drawing.Point(18, 28);
            this.ingresoProfe.Name = "ingresoProfe";
            this.ingresoProfe.Size = new System.Drawing.Size(144, 40);
            this.ingresoProfe.TabIndex = 5;
            this.ingresoProfe.Text = "Registro Docente";
            this.ingresoProfe.UseVisualStyleBackColor = true;
            this.ingresoProfe.Click += new System.EventHandler(this.ingresoProfe_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(291, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Registro Asignatura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_reporte
            // 
            this.dgv_reporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_reporte.Location = new System.Drawing.Point(18, 103);
            this.dgv_reporte.Name = "dgv_reporte";
            this.dgv_reporte.Size = new System.Drawing.Size(984, 220);
            this.dgv_reporte.TabIndex = 8;
            this.dgv_reporte.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reporte_CellClick);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(892, 370);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(110, 33);
            this.salir.TabIndex = 9;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // eliminarRegistro
            // 
            this.eliminarRegistro.Location = new System.Drawing.Point(772, 370);
            this.eliminarRegistro.Name = "eliminarRegistro";
            this.eliminarRegistro.Size = new System.Drawing.Size(105, 33);
            this.eliminarRegistro.TabIndex = 10;
            this.eliminarRegistro.Text = "Eliminar Registro";
            this.eliminarRegistro.UseVisualStyleBackColor = true;
            this.eliminarRegistro.Click += new System.EventHandler(this.eliminarRegistro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "INGRESA EL MES";
            // 
            // txt_Mes
            // 
            this.txt_Mes.Location = new System.Drawing.Point(750, 39);
            this.txt_Mes.Name = "txt_Mes";
            this.txt_Mes.Size = new System.Drawing.Size(94, 20);
            this.txt_Mes.TabIndex = 13;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(872, 63);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(110, 34);
            this.buscar.TabIndex = 14;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 415);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.txt_Mes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eliminarRegistro);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.dgv_reporte);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ingresoProfe);
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ingresoProfe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_reporte;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button eliminarRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Mes;
        private System.Windows.Forms.Button buscar;
    }
}