
namespace CapaGUI
{
    partial class PantallaHomeTutor
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
            this.pacienteASuCargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosNecesariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguimientoDelPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videollamadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumenToolStripMenuItem,
            this.pacienteASuCargoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacienteASuCargoToolStripMenuItem
            // 
            this.pacienteASuCargoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProductosNecesariosToolStripMenuItem,
            this.seguimientoDelPacienteToolStripMenuItem,
            this.videollamadaToolStripMenuItem});
            this.pacienteASuCargoToolStripMenuItem.Name = "pacienteASuCargoToolStripMenuItem";
            this.pacienteASuCargoToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.pacienteASuCargoToolStripMenuItem.Text = "Paciente a su cargo";
            // 
            // verProductosNecesariosToolStripMenuItem
            // 
            this.verProductosNecesariosToolStripMenuItem.Name = "verProductosNecesariosToolStripMenuItem";
            this.verProductosNecesariosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.verProductosNecesariosToolStripMenuItem.Text = "Seguimiento Paciente";
            this.verProductosNecesariosToolStripMenuItem.Click += new System.EventHandler(this.verProductosNecesariosToolStripMenuItem_Click);
            // 
            // seguimientoDelPacienteToolStripMenuItem
            // 
            this.seguimientoDelPacienteToolStripMenuItem.Name = "seguimientoDelPacienteToolStripMenuItem";
            this.seguimientoDelPacienteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.seguimientoDelPacienteToolStripMenuItem.Text = "Productos Necesarios";
            // 
            // videollamadaToolStripMenuItem
            // 
            this.videollamadaToolStripMenuItem.Name = "videollamadaToolStripMenuItem";
            this.videollamadaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.videollamadaToolStripMenuItem.Text = "Videollamada";
            // 
            // resumenToolStripMenuItem
            // 
            this.resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
            this.resumenToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.resumenToolStripMenuItem.Text = "Resumen";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // PantallaHomeTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaHomeTutor";
            this.Text = "PantallaHomeTutor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacienteASuCargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductosNecesariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguimientoDelPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videollamadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}