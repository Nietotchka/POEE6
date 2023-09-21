namespace Projeto4
{
    partial class FormRelatorioProfessor
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
            groupBox1 = new GroupBox();
            cboCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox2 = new GroupBox();
            materialComboBox1 = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox3 = new GroupBox();
            cboImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            btn_imprimir = new ReaLTaiizor.Controls.MaterialButton();
            btn_visualizar = new ReaLTaiizor.Controls.MaterialButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboCidade);
            groupBox1.Controls.Add(cboEstado);
            groupBox1.Location = new Point(6, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(709, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // cboCidade
            // 
            cboCidade.AnimateReadOnly = false;
            cboCidade.AutoCompleteMode = AutoCompleteMode.None;
            cboCidade.AutoCompleteSource = AutoCompleteSource.None;
            cboCidade.BackgroundImageLayout = ImageLayout.None;
            cboCidade.CharacterCasing = CharacterCasing.Normal;
            cboCidade.Depth = 0;
            cboCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboCidade.HideSelection = true;
            cboCidade.Hint = "Cidade";
            cboCidade.LeadingIcon = null;
            cboCidade.Location = new Point(6, 34);
            cboCidade.MaxLength = 32767;
            cboCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCidade.Name = "cboCidade";
            cboCidade.PasswordChar = '\0';
            cboCidade.PrefixSuffixText = null;
            cboCidade.ReadOnly = false;
            cboCidade.RightToLeft = RightToLeft.No;
            cboCidade.SelectedText = "";
            cboCidade.SelectionLength = 0;
            cboCidade.SelectionStart = 0;
            cboCidade.ShortcutsEnabled = true;
            cboCidade.Size = new Size(567, 48);
            cboCidade.TabIndex = 8;
            cboCidade.TabStop = false;
            cboCidade.TextAlign = HorizontalAlignment.Left;
            cboCidade.TrailingIcon = null;
            cboCidade.UseSystemPasswordChar = false;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "Estado";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Items.AddRange(new object[] { "", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboEstado.Location = new Point(579, 34);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(materialComboBox1);
            groupBox2.Location = new Point(6, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(709, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agrupamento";
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.Hint = "Agrupamento";
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Items.AddRange(new object[] { "Nenhum", "Cidade", "Estado" });
            materialComboBox1.Location = new Point(6, 32);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(697, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboImpressora);
            groupBox3.Location = new Point(6, 291);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(709, 100);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Impressora";
            // 
            // cboImpressora
            // 
            cboImpressora.AutoResize = false;
            cboImpressora.BackColor = Color.FromArgb(255, 255, 255);
            cboImpressora.Depth = 0;
            cboImpressora.DrawMode = DrawMode.OwnerDrawVariable;
            cboImpressora.DropDownHeight = 174;
            cboImpressora.DropDownStyle = ComboBoxStyle.DropDownList;
            cboImpressora.DropDownWidth = 121;
            cboImpressora.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboImpressora.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboImpressora.FormattingEnabled = true;
            cboImpressora.Hint = "Impressora";
            cboImpressora.IntegralHeight = false;
            cboImpressora.ItemHeight = 43;
            cboImpressora.Location = new Point(3, 26);
            cboImpressora.MaxDropDownItems = 4;
            cboImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboImpressora.Name = "cboImpressora";
            cboImpressora.Size = new Size(697, 49);
            cboImpressora.StartIndex = 0;
            cboImpressora.TabIndex = 9;
            // 
            // btn_imprimir
            // 
            btn_imprimir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_imprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_imprimir.Depth = 0;
            btn_imprimir.HighEmphasis = true;
            btn_imprimir.Icon = null;
            btn_imprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_imprimir.Location = new Point(498, 400);
            btn_imprimir.Margin = new Padding(4, 6, 4, 6);
            btn_imprimir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_imprimir.Name = "btn_imprimir";
            btn_imprimir.NoAccentTextColor = Color.Empty;
            btn_imprimir.Size = new Size(97, 36);
            btn_imprimir.TabIndex = 10;
            btn_imprimir.Text = "&IMPRIMIR";
            btn_imprimir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_imprimir.UseAccentColor = false;
            btn_imprimir.UseVisualStyleBackColor = true;
            btn_imprimir.Click += btn_imprimir_Click;
            // 
            // btn_visualizar
            // 
            btn_visualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_visualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_visualizar.Depth = 0;
            btn_visualizar.HighEmphasis = true;
            btn_visualizar.Icon = null;
            btn_visualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_visualizar.Location = new Point(603, 400);
            btn_visualizar.Margin = new Padding(4, 6, 4, 6);
            btn_visualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_visualizar.Name = "btn_visualizar";
            btn_visualizar.NoAccentTextColor = Color.Empty;
            btn_visualizar.Size = new Size(112, 36);
            btn_visualizar.TabIndex = 11;
            btn_visualizar.Text = "&VISUALIZAR";
            btn_visualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_visualizar.UseAccentColor = false;
            btn_visualizar.UseVisualStyleBackColor = true;
            btn_visualizar.Click += btn_visualizar_Click;
            // 
            // FormRelatorioProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_visualizar);
            Controls.Add(btn_imprimir);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormRelatorioProfessor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório de Professores";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit cboCidade;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private GroupBox groupBox3;
        private ReaLTaiizor.Controls.MaterialComboBox cboImpressora;
        private ReaLTaiizor.Controls.MaterialButton btn_imprimir;
        private ReaLTaiizor.Controls.MaterialButton btn_visualizar;
    }
}