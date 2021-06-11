
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
            this.resumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPersonalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeEquiposMédicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEquipoMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumenToolStripMenuItem,
            this.registroPersonalToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.cargosToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resumenToolStripMenuItem
            // 
            this.resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
            this.resumenToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.resumenToolStripMenuItem.Text = "Resumen";
            this.resumenToolStripMenuItem.Click += new System.EventHandler(this.resumenToolStripMenuItem_Click);
            // 
            // registroPersonalToolStripMenuItem
            // 
            this.registroPersonalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroPersonalToolStripMenuItem1,
            this.registroToolStripMenuItem,
            this.registroPacientesToolStripMenuItem});
            this.registroPersonalToolStripMenuItem.Name = "registroPersonalToolStripMenuItem";
            this.registroPersonalToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.registroPersonalToolStripMenuItem.Text = "Usuarios";
            this.registroPersonalToolStripMenuItem.Click += new System.EventHandler(this.registroPersonalToolStripMenuItem_Click);
            // 
            // registroPersonalToolStripMenuItem1
            // 
            this.registroPersonalToolStripMenuItem1.Name = "registroPersonalToolStripMenuItem1";
            this.registroPersonalToolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
            this.registroPersonalToolStripMenuItem1.Text = "Registro Personal";
            this.registroPersonalToolStripMenuItem1.Click += new System.EventHandler(this.registroPersonalToolStripMenuItem1_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.registroToolStripMenuItem.Text = "Registro Tutores";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // registroPacientesToolStripMenuItem
            // 
            this.registroPacientesToolStripMenuItem.Name = "registroPacientesToolStripMenuItem";
            this.registroPacientesToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.registroPacientesToolStripMenuItem.Text = "Registro Pacientes";
            this.registroPacientesToolStripMenuItem.Click += new System.EventHandler(this.registroPacientesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDePacientesToolStripMenuItem,
            this.cantidadDePersonalToolStripMenuItem,
            this.cantidadDeEquiposMédicosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // cantidadDePacientesToolStripMenuItem
            // 
            this.cantidadDePacientesToolStripMenuItem.Name = "cantidadDePacientesToolStripMenuItem";
            this.cantidadDePacientesToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.cantidadDePacientesToolStripMenuItem.Text = "Cantidad de Pacientes";
            // 
            // cantidadDePersonalToolStripMenuItem
            // 
            this.cantidadDePersonalToolStripMenuItem.Name = "cantidadDePersonalToolStripMenuItem";
            this.cantidadDePersonalToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.cantidadDePersonalToolStripMenuItem.Text = "Cantidad de Personal";
            // 
            // cantidadDeEquiposMédicosToolStripMenuItem
            // 
            this.cantidadDeEquiposMédicosToolStripMenuItem.Name = "cantidadDeEquiposMédicosToolStripMenuItem";
            this.cantidadDeEquiposMédicosToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.cantidadDeEquiposMédicosToolStripMenuItem.Text = "Cantidad de Equipos Médicos";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem1});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // registroToolStripMenuItem1
            // 
            this.registroToolStripMenuItem1.Name = "registroToolStripMenuItem1";
            this.registroToolStripMenuItem1.Size = new System.Drawing.Size(147, 26);
            this.registroToolStripMenuItem1.Text = "Registro";
            this.registroToolStripMenuItem1.Click += new System.EventHandler(this.registroToolStripMenuItem1_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem2});
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.cargosToolStripMenuItem.Text = "Cargos";
            // 
            // registroToolStripMenuItem2
            // 
            this.registroToolStripMenuItem2.Name = "registroToolStripMenuItem2";
            this.registroToolStripMenuItem2.Size = new System.Drawing.Size(147, 26);
            this.registroToolStripMenuItem2.Text = "Registro";
            this.registroToolStripMenuItem2.Click += new System.EventHandler(this.registroToolStripMenuItem2_Click);
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEquipoMedicoToolStripMenuItem});
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // crearEquipoMedicoToolStripMenuItem
            // 
            this.crearEquipoMedicoToolStripMenuItem.Name = "crearEquipoMedicoToolStripMenuItem";
            this.crearEquipoMedicoToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.crearEquipoMedicoToolStripMenuItem.Text = "Crear Equipo Medico";
            this.crearEquipoMedicoToolStripMenuItem.Click += new System.EventHandler(this.crearEquipoMedicoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Pacientes Hospitalizados:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(625, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(625, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad de Personal Medico:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(625, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de Camas Disponibles:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(625, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad de Equipos Médicos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PantallaHomeAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem crearEquipoMedicoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
    }
}