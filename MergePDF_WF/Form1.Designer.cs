namespace MergePDF_WF
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
            this.lstFicheros = new System.Windows.Forms.ListView();
            this.chPosicion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombreFichero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblNombreFichero = new System.Windows.Forms.Label();
            this.txtFicheroDestino = new System.Windows.Forms.TextBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnFicheroDestino = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnRotar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFicheros
            // 
            this.lstFicheros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPosicion,
            this.chNombreFichero});
            this.lstFicheros.FullRowSelect = true;
            this.lstFicheros.GridLines = true;
            this.lstFicheros.HideSelection = false;
            this.lstFicheros.Location = new System.Drawing.Point(10, 40);
            this.lstFicheros.Name = "lstFicheros";
            this.lstFicheros.Size = new System.Drawing.Size(571, 333);
            this.lstFicheros.TabIndex = 0;
            this.lstFicheros.UseCompatibleStateImageBehavior = false;
            this.lstFicheros.View = System.Windows.Forms.View.Details;
            // 
            // chPosicion
            // 
            this.chPosicion.Text = "Posición";
            // 
            // chNombreFichero
            // 
            this.chNombreFichero.Text = "Fichero";
            this.chNombreFichero.Width = 506;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(587, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(248, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Fichero";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblNombreFichero
            // 
            this.lblNombreFichero.AutoSize = true;
            this.lblNombreFichero.Location = new System.Drawing.Point(18, 394);
            this.lblNombreFichero.Name = "lblNombreFichero";
            this.lblNombreFichero.Size = new System.Drawing.Size(81, 13);
            this.lblNombreFichero.TabIndex = 3;
            this.lblNombreFichero.Text = "Fichero Destino";
            // 
            // txtFicheroDestino
            // 
            this.txtFicheroDestino.Location = new System.Drawing.Point(105, 391);
            this.txtFicheroDestino.Name = "txtFicheroDestino";
            this.txtFicheroDestino.Size = new System.Drawing.Size(425, 20);
            this.txtFicheroDestino.TabIndex = 4;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(251, 428);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(88, 47);
            this.btnJuntar.TabIndex = 5;
            this.btnJuntar.Text = "Unir Ficheros";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnFicheroDestino
            // 
            this.btnFicheroDestino.Location = new System.Drawing.Point(539, 389);
            this.btnFicheroDestino.Name = "btnFicheroDestino";
            this.btnFicheroDestino.Size = new System.Drawing.Size(36, 23);
            this.btnFicheroDestino.TabIndex = 6;
            this.btnFicheroDestino.Text = "...";
            this.btnFicheroDestino.UseVisualStyleBackColor = true;
            this.btnFicheroDestino.Click += new System.EventHandler(this.btnFicheroDestino_Click);
            // 
            // btnRotar
            // 
            this.btnRotar.Location = new System.Drawing.Point(345, 428);
            this.btnRotar.Name = "btnRotar";
            this.btnRotar.Size = new System.Drawing.Size(88, 47);
            this.btnRotar.TabIndex = 7;
            this.btnRotar.Text = "Rotar Ficheros";
            this.btnRotar.UseVisualStyleBackColor = true;
            this.btnRotar.Click += new System.EventHandler(this.btnRotar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Angulo Rotación";
            // 
            // txtAngulo
            // 
            this.txtAngulo.Location = new System.Drawing.Point(443, 444);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(92, 20);
            this.txtAngulo.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 500);
            this.Controls.Add(this.txtAngulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRotar);
            this.Controls.Add(this.btnFicheroDestino);
            this.Controls.Add(this.btnJuntar);
            this.Controls.Add(this.txtFicheroDestino);
            this.Controls.Add(this.lblNombreFichero);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lstFicheros);
            this.Name = "Form1";
            this.Text = "Merge PDF";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFicheros;
        private System.Windows.Forms.ColumnHeader chNombreFichero;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader chPosicion;
        private System.Windows.Forms.Button btnFicheroDestino;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.TextBox txtFicheroDestino;
        private System.Windows.Forms.Label lblNombreFichero;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnRotar;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.Label label1;
    }
}

