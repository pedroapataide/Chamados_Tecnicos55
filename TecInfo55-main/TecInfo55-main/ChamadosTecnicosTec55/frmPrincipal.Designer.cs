﻿namespace ChamadosTecnicosTec55
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.técnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorDeChamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharSoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.gestorDeClienteToolStripMenuItem,
            this.gestorDeChamadosToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.documentaçãoToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.fecharSoluçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clintToolStripMenuItem,
            this.técnicoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clintToolStripMenuItem
            // 
            this.clintToolStripMenuItem.Name = "clintToolStripMenuItem";
            this.clintToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clintToolStripMenuItem.Text = "Cliente";
            this.clintToolStripMenuItem.Click += new System.EventHandler(this.clintToolStripMenuItem_Click);
            // 
            // técnicoToolStripMenuItem
            // 
            this.técnicoToolStripMenuItem.Name = "técnicoToolStripMenuItem";
            this.técnicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.técnicoToolStripMenuItem.Text = "Técnico";
            this.técnicoToolStripMenuItem.Click += new System.EventHandler(this.técnicoToolStripMenuItem_Click);
            // 
            // gestorDeClienteToolStripMenuItem
            // 
            this.gestorDeClienteToolStripMenuItem.Name = "gestorDeClienteToolStripMenuItem";
            this.gestorDeClienteToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.gestorDeClienteToolStripMenuItem.Text = "Gestor de Cliente";
            this.gestorDeClienteToolStripMenuItem.Click += new System.EventHandler(this.gestorDeClienteToolStripMenuItem_Click);
            // 
            // gestorDeChamadosToolStripMenuItem
            // 
            this.gestorDeChamadosToolStripMenuItem.Name = "gestorDeChamadosToolStripMenuItem";
            this.gestorDeChamadosToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.gestorDeChamadosToolStripMenuItem.Text = "Gestor de Chamados";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // documentaçãoToolStripMenuItem
            // 
            this.documentaçãoToolStripMenuItem.Name = "documentaçãoToolStripMenuItem";
            this.documentaçãoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.documentaçãoToolStripMenuItem.Text = "Documentação";
            this.documentaçãoToolStripMenuItem.Click += new System.EventHandler(this.documentaçãoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // fecharSoluçãoToolStripMenuItem
            // 
            this.fecharSoluçãoToolStripMenuItem.Name = "fecharSoluçãoToolStripMenuItem";
            this.fecharSoluçãoToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.fecharSoluçãoToolStripMenuItem.Text = "Fechar solução";
            this.fecharSoluçãoToolStripMenuItem.Click += new System.EventHandler(this.fecharSoluçãoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de chamados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem técnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorDeChamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharSoluçãoToolStripMenuItem;
    }
}