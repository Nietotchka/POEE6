namespace WinFormsApp1
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeAlunosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeProfessoresToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeCursosToolStripMenuItem = new ToolStripMenuItem();
            reToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeAlunosToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeProfessoresToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeCursosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem, reToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(684, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeAlunosToolStripMenuItem, cadastroDeProfessoresToolStripMenuItem, cadastroDeCursosToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            opçõesToolStripMenuItem.Click += opçõesToolStripMenuItem_Click;
            // 
            // cadastroDeAlunosToolStripMenuItem
            // 
            cadastroDeAlunosToolStripMenuItem.Name = "cadastroDeAlunosToolStripMenuItem";
            cadastroDeAlunosToolStripMenuItem.Size = new Size(200, 22);
            cadastroDeAlunosToolStripMenuItem.Text = "Cadastro de Alunos";
            cadastroDeAlunosToolStripMenuItem.Click += cadastroDeAlunosToolStripMenuItem_Click;
            // 
            // cadastroDeProfessoresToolStripMenuItem
            // 
            cadastroDeProfessoresToolStripMenuItem.Name = "cadastroDeProfessoresToolStripMenuItem";
            cadastroDeProfessoresToolStripMenuItem.Size = new Size(200, 22);
            cadastroDeProfessoresToolStripMenuItem.Text = "Cadastro de Professores";
            cadastroDeProfessoresToolStripMenuItem.Click += cadastroDeProfessoresToolStripMenuItem_Click;
            // 
            // cadastroDeCursosToolStripMenuItem
            // 
            cadastroDeCursosToolStripMenuItem.Name = "cadastroDeCursosToolStripMenuItem";
            cadastroDeCursosToolStripMenuItem.Size = new Size(200, 22);
            cadastroDeCursosToolStripMenuItem.Text = "Cadastro de Cursos";
            cadastroDeCursosToolStripMenuItem.Click += cadastroDeCursosToolStripMenuItem_Click;
            // 
            // reToolStripMenuItem
            // 
            reToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatórioDeAlunosToolStripMenuItem, relatórioDeProfessoresToolStripMenuItem, relatórioDeCursosToolStripMenuItem });
            reToolStripMenuItem.Name = "reToolStripMenuItem";
            reToolStripMenuItem.Size = new Size(71, 20);
            reToolStripMenuItem.Text = "Relatórios";
            reToolStripMenuItem.Click += reToolStripMenuItem_Click;
            // 
            // relatórioDeAlunosToolStripMenuItem
            // 
            relatórioDeAlunosToolStripMenuItem.Name = "relatórioDeAlunosToolStripMenuItem";
            relatórioDeAlunosToolStripMenuItem.Size = new Size(200, 22);
            relatórioDeAlunosToolStripMenuItem.Text = "Relatório de Alunos";
            relatórioDeAlunosToolStripMenuItem.Click += relatórioDeAlunosToolStripMenuItem_Click;
            // 
            // relatórioDeProfessoresToolStripMenuItem
            // 
            relatórioDeProfessoresToolStripMenuItem.Name = "relatórioDeProfessoresToolStripMenuItem";
            relatórioDeProfessoresToolStripMenuItem.Size = new Size(200, 22);
            relatórioDeProfessoresToolStripMenuItem.Text = "Relatório de Professores";
            relatórioDeProfessoresToolStripMenuItem.Click += relatórioDeProfessoresToolStripMenuItem_Click;
            // 
            // relatórioDeCursosToolStripMenuItem
            // 
            relatórioDeCursosToolStripMenuItem.Name = "relatórioDeCursosToolStripMenuItem";
            relatórioDeCursosToolStripMenuItem.Size = new Size(200, 22);
            relatórioDeCursosToolStripMenuItem.Text = "Relatório de Cursos";
            relatórioDeCursosToolStripMenuItem.Click += relatórioDeCursosToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(690, 442);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IFSP - Sistema de Gerenciamento Acadêmico";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem cadastroDeAlunosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProfessoresToolStripMenuItem;
        private ToolStripMenuItem cadastroDeCursosToolStripMenuItem;
        private ToolStripMenuItem reToolStripMenuItem;
        private ToolStripMenuItem relatórioDeAlunosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeProfessoresToolStripMenuItem;
        private ToolStripMenuItem relatórioDeCursosToolStripMenuItem;
    }
}