﻿namespace uprofe
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_reporte = new System.Windows.Forms.DataGridView();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registro Docente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(191, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Registro Asignatura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_reporte
            // 
            this.dgv_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reporte.Location = new System.Drawing.Point(18, 103);
            this.dgv_reporte.Name = "dgv_reporte";
            this.dgv_reporte.Size = new System.Drawing.Size(760, 210);
            this.dgv_reporte.TabIndex = 8;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(653, 339);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(105, 23);
            this.salir.TabIndex = 9;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 380);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.dgv_reporte);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_reporte;
        private System.Windows.Forms.Button salir;
    }
}