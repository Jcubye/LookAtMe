
namespace CapaGUI
{
    partial class PantallaListadoTutores
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
            this.gridViewTutor = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTutor)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewTutor
            // 
            this.gridViewTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTutor.Location = new System.Drawing.Point(175, 44);
            this.gridViewTutor.Name = "gridViewTutor";
            this.gridViewTutor.RowHeadersWidth = 51;
            this.gridViewTutor.RowTemplate.Height = 24;
            this.gridViewTutor.Size = new System.Drawing.Size(464, 273);
            this.gridViewTutor.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(564, 345);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(469, 345);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // PantallaListadoTutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gridViewTutor);
            this.Name = "PantallaListadoTutores";
            this.Text = "PantallaListadoTutores";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewTutor;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnMostrar;
    }
}