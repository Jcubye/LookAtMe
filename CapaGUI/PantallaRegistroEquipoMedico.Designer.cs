
namespace CapaGUI
{
    partial class PantallaRegistroEquipoMedico
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
            System.Windows.Forms.Button btnActualizar;
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new System.Drawing.Point(241, 335);
            btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(100, 28);
            btnActualizar.TabIndex = 67;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(369, 371);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(100, 22);
            this.txtPosicion.TabIndex = 74;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(622, 371);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(100, 28);
            this.btnUltimo.TabIndex = 73;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(495, 371);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 28);
            this.btnSiguiente.TabIndex = 72;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(369, 335);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 71;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(241, 371);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 28);
            this.btnAnterior.TabIndex = 70;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(115, 371);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(100, 28);
            this.btnPrimero.TabIndex = 69;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(495, 335);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 28);
            this.btnListar.TabIndex = 68;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(622, 335);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 66;
            this.btnCancelar.Text = "Canelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(115, 335);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrar.TabIndex = 65;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // PantallaRegistroEquipoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "PantallaRegistroEquipoMedico";
            this.Text = "PantallaRegistroEquipoMedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}