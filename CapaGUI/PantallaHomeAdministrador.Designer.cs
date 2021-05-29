
namespace CapaGUI
{
    partial class PantallaHomeAdministrador
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPersonalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeEquiposMédicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumenToolStripMenuItem,
            this.registroPersonalToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroPersonalToolStripMenuItem
            // 
            this.registroPersonalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroPersonalToolStripMenuItem1,
            this.registroToolStripMenuItem,
            this.registroPacientesToolStripMenuItem});
            this.registroPersonalToolStripMenuItem.Name = "registroPersonalToolStripMenuItem";
            this.registroPersonalToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registroPersonalToolStripMenuItem.Text = "Registros";
            this.registroPersonalToolStripMenuItem.Click += new System.EventHandler(this.registroPersonalToolStripMenuItem_Click);
            // 
            // registroPersonalToolStripMenuItem1
            // 
            this.registroPersonalToolStripMenuItem1.Name = "registroPersonalToolStripMenuItem1";
            this.registroPersonalToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.registroPersonalToolStripMenuItem1.Text = "Registro Personal";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroToolStripMenuItem.Text = "Registro Tutores";
            // 
            // registroPacientesToolStripMenuItem
            // 
            this.registroPacientesToolStripMenuItem.Name = "registroPacientesToolStripMenuItem";
            this.registroPacientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroPacientesToolStripMenuItem.Text = "Registro Pacientes";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDePacientesToolStripMenuItem,
            this.cantidadDePersonalToolStripMenuItem,
            this.cantidadDeEquiposMédicosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // cantidadDePacientesToolStripMenuItem
            // 
            this.cantidadDePacientesToolStripMenuItem.Name = "cantidadDePacientesToolStripMenuItem";
            this.cantidadDePacientesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.cantidadDePacientesToolStripMenuItem.Text = "Cantidad de Pacientes";
            // 
            // cantidadDePersonalToolStripMenuItem
            // 
            this.cantidadDePersonalToolStripMenuItem.Name = "cantidadDePersonalToolStripMenuItem";
            this.cantidadDePersonalToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.cantidadDePersonalToolStripMenuItem.Text = "Cantidad de Personal";
            // 
            // cantidadDeEquiposMédicosToolStripMenuItem
            // 
            this.cantidadDeEquiposMédicosToolStripMenuItem.Name = "cantidadDeEquiposMédicosToolStripMenuItem";
            this.cantidadDeEquiposMédicosToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.cantidadDeEquiposMédicosToolStripMenuItem.Text = "Cantidad de Equipos Médicos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // resumenToolStripMenuItem
            // 
            this.resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
            this.resumenToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.resumenToolStripMenuItem.Text = "Resumen";
            // 
            // PantallaHomeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaHomeAdministrador";
            this.Text = "PantallaHomeAdministrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroPersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroPersonalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDePersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeEquiposMédicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}