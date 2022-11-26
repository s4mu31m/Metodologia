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
            this.buscar = new System.Windows.Forms.Button();
            this.cbx_mes = new System.Windows.Forms.ComboBox();
            this.cbx_profe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(522, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Busca por mes";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(872, 63);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(110, 34);
            this.buscar.TabIndex = 14;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // cbx_mes
            // 
            this.cbx_mes.FormattingEnabled = true;
            this.cbx_mes.Location = new System.Drawing.Point(631, 27);
            this.cbx_mes.Name = "cbx_mes";
            this.cbx_mes.Size = new System.Drawing.Size(114, 21);
            this.cbx_mes.TabIndex = 15;
            // 
            // cbx_profe
            // 
            this.cbx_profe.FormattingEnabled = true;
            this.cbx_profe.Location = new System.Drawing.Point(631, 63);
            this.cbx_profe.Name = "cbx_profe";
            this.cbx_profe.Size = new System.Drawing.Size(114, 21);
            this.cbx_profe.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Busca por profesor";
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(870, 25);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(111, 22);
            this.volver.TabIndex = 18;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 415);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.cbx_profe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_mes);
            this.Controls.Add(this.buscar);
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
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.ComboBox cbx_mes;
        private System.Windows.Forms.ComboBox cbx_profe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volver;
    }
}