namespace Projeto4
{
    partial class FormCurso
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurso));
            materialTabControl2 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage3 = new TabPage();
            txt_Id = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btn_cancelar = new ReaLTaiizor.Controls.MaterialButton();
            btn_salvar = new ReaLTaiizor.Controls.MaterialButton();
            txt_Tipo = new ReaLTaiizor.Controls.MaterialComboBox();
            txt_AnoCriacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txt_Name = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            listView_Alunos = new ListView();
            imageList1 = new ImageList(components);
            materialTabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl2
            // 
            materialTabControl2.Controls.Add(tabPage3);
            materialTabControl2.Controls.Add(tabPage2);
            materialTabControl2.Depth = 0;
            materialTabControl2.Dock = DockStyle.Fill;
            materialTabControl2.ImageList = imageList1;
            materialTabControl2.Location = new Point(3, 64);
            materialTabControl2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl2.Multiline = true;
            materialTabControl2.Name = "materialTabControl2";
            materialTabControl2.SelectedIndex = 0;
            materialTabControl2.Size = new Size(834, 273);
            materialTabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txt_Id);
            tabPage3.Controls.Add(btn_cancelar);
            tabPage3.Controls.Add(btn_salvar);
            tabPage3.Controls.Add(txt_Tipo);
            tabPage3.Controls.Add(txt_AnoCriacao);
            tabPage3.Controls.Add(txt_Name);
            tabPage3.ImageKey = "form.png";
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(826, 245);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Cadastro";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // txt_Id
            // 
            txt_Id.AnimateReadOnly = false;
            txt_Id.AutoCompleteMode = AutoCompleteMode.None;
            txt_Id.AutoCompleteSource = AutoCompleteSource.None;
            txt_Id.BackgroundImageLayout = ImageLayout.None;
            txt_Id.CharacterCasing = CharacterCasing.Normal;
            txt_Id.Depth = 0;
            txt_Id.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_Id.HideSelection = true;
            txt_Id.Hint = "id";
            txt_Id.LeadingIcon = null;
            txt_Id.Location = new Point(690, 23);
            txt_Id.MaxLength = 32767;
            txt_Id.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txt_Id.Name = "txt_Id";
            txt_Id.PasswordChar = '\0';
            txt_Id.PrefixSuffixText = null;
            txt_Id.ReadOnly = true;
            txt_Id.RightToLeft = RightToLeft.No;
            txt_Id.SelectedText = "";
            txt_Id.SelectionLength = 0;
            txt_Id.SelectionStart = 0;
            txt_Id.ShortcutsEnabled = true;
            txt_Id.Size = new Size(90, 48);
            txt_Id.TabIndex = 0;
            txt_Id.TabStop = false;
            txt_Id.TextAlign = HorizontalAlignment.Left;
            txt_Id.TrailingIcon = null;
            txt_Id.UseSystemPasswordChar = false;
            txt_Id.Click += txt_Id_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_cancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_cancelar.Depth = 0;
            btn_cancelar.HighEmphasis = true;
            btn_cancelar.Icon = null;
            btn_cancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_cancelar.Location = new Point(111, 189);
            btn_cancelar.Margin = new Padding(4, 6, 4, 6);
            btn_cancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.NoAccentTextColor = Color.Empty;
            btn_cancelar.Size = new Size(96, 36);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_cancelar.UseAccentColor = false;
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_salvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_salvar.Depth = 0;
            btn_salvar.HighEmphasis = true;
            btn_salvar.Icon = null;
            btn_salvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_salvar.Location = new Point(9, 189);
            btn_salvar.Margin = new Padding(4, 6, 4, 6);
            btn_salvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_salvar.Name = "btn_salvar";
            btn_salvar.NoAccentTextColor = Color.Empty;
            btn_salvar.Size = new Size(76, 36);
            btn_salvar.TabIndex = 3;
            btn_salvar.Text = "Salvar";
            btn_salvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_salvar.UseAccentColor = false;
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txt_Tipo
            // 
            txt_Tipo.AutoResize = false;
            txt_Tipo.BackColor = Color.FromArgb(255, 255, 255);
            txt_Tipo.Depth = 0;
            txt_Tipo.DrawMode = DrawMode.OwnerDrawVariable;
            txt_Tipo.DropDownHeight = 174;
            txt_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_Tipo.DropDownWidth = 121;
            txt_Tipo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txt_Tipo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txt_Tipo.FormattingEnabled = true;
            txt_Tipo.Hint = "Tipo";
            txt_Tipo.IntegralHeight = false;
            txt_Tipo.ItemHeight = 43;
            txt_Tipo.Items.AddRange(new object[] { "Técnico", "Tecnólogo", "Bacharelado", "Licenciatura" });
            txt_Tipo.Location = new Point(9, 77);
            txt_Tipo.MaxDropDownItems = 4;
            txt_Tipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txt_Tipo.Name = "txt_Tipo";
            txt_Tipo.Size = new Size(774, 49);
            txt_Tipo.StartIndex = 0;
            txt_Tipo.TabIndex = 1;
            txt_Tipo.SelectedIndexChanged += txt_Tipo_SelectedIndexChanged;
            // 
            // txt_AnoCriacao
            // 
            txt_AnoCriacao.AnimateReadOnly = false;
            txt_AnoCriacao.AutoCompleteMode = AutoCompleteMode.None;
            txt_AnoCriacao.AutoCompleteSource = AutoCompleteSource.None;
            txt_AnoCriacao.BackgroundImageLayout = ImageLayout.None;
            txt_AnoCriacao.CharacterCasing = CharacterCasing.Normal;
            txt_AnoCriacao.Depth = 0;
            txt_AnoCriacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_AnoCriacao.HideSelection = true;
            txt_AnoCriacao.Hint = "Ano de Criação";
            txt_AnoCriacao.LeadingIcon = null;
            txt_AnoCriacao.Location = new Point(6, 132);
            txt_AnoCriacao.MaxLength = 32767;
            txt_AnoCriacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txt_AnoCriacao.Name = "txt_AnoCriacao";
            txt_AnoCriacao.PasswordChar = '\0';
            txt_AnoCriacao.PrefixSuffixText = null;
            txt_AnoCriacao.ReadOnly = false;
            txt_AnoCriacao.RightToLeft = RightToLeft.No;
            txt_AnoCriacao.SelectedText = "";
            txt_AnoCriacao.SelectionLength = 0;
            txt_AnoCriacao.SelectionStart = 0;
            txt_AnoCriacao.ShortcutsEnabled = true;
            txt_AnoCriacao.Size = new Size(774, 48);
            txt_AnoCriacao.TabIndex = 2;
            txt_AnoCriacao.TabStop = false;
            txt_AnoCriacao.TextAlign = HorizontalAlignment.Left;
            txt_AnoCriacao.TrailingIcon = null;
            txt_AnoCriacao.UseSystemPasswordChar = false;
            txt_AnoCriacao.Click += txt_AnoCriacao_Click;
            // 
            // txt_Name
            // 
            txt_Name.AnimateReadOnly = false;
            txt_Name.AutoCompleteMode = AutoCompleteMode.None;
            txt_Name.AutoCompleteSource = AutoCompleteSource.None;
            txt_Name.BackgroundImageLayout = ImageLayout.None;
            txt_Name.CharacterCasing = CharacterCasing.Normal;
            txt_Name.Depth = 0;
            txt_Name.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_Name.HideSelection = true;
            txt_Name.Hint = "Nome";
            txt_Name.LeadingIcon = null;
            txt_Name.Location = new Point(3, 23);
            txt_Name.MaxLength = 32767;
            txt_Name.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txt_Name.Name = "txt_Name";
            txt_Name.PasswordChar = '\0';
            txt_Name.PrefixSuffixText = null;
            txt_Name.ReadOnly = false;
            txt_Name.RightToLeft = RightToLeft.No;
            txt_Name.SelectedText = "";
            txt_Name.SelectionLength = 0;
            txt_Name.SelectionStart = 0;
            txt_Name.ShortcutsEnabled = true;
            txt_Name.Size = new Size(670, 48);
            txt_Name.TabIndex = 0;
            txt_Name.TabStop = false;
            txt_Name.TextAlign = HorizontalAlignment.Left;
            txt_Name.TrailingIcon = null;
            txt_Name.UseSystemPasswordChar = false;
            txt_Name.Click += txt_Name_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(btnExcluir);
            tabPage2.Controls.Add(btnEditar);
            tabPage2.Controls.Add(btnNovo);
            tabPage2.Controls.Add(listView_Alunos);
            tabPage2.ImageKey = "search.png";
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(826, 242);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(823, 233);
            dataGridView2.TabIndex = 4;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.Enter += dataGridView2_Enter;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(690, 310);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(89, 36);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "&Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(601, 310);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(81, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "&Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(522, 310);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(71, 36);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "&Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // listView_Alunos
            // 
            listView_Alunos.FullRowSelect = true;
            listView_Alunos.Location = new Point(3, 3);
            listView_Alunos.Name = "listView_Alunos";
            listView_Alunos.OwnerDraw = true;
            listView_Alunos.Size = new Size(604, 291);
            listView_Alunos.TabIndex = 0;
            listView_Alunos.UseCompatibleStateImageBehavior = false;
            listView_Alunos.View = View.Details;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // FormCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 340);
            Controls.Add(materialTabControl2);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl2;
            Name = "FormCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Curso";
            materialTabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl2;
        private TabPage tabPage3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txt_Id;
        private ReaLTaiizor.Controls.MaterialButton btn_cancelar;
        private ReaLTaiizor.Controls.MaterialButton btn_salvar;
        private ReaLTaiizor.Controls.MaterialComboBox txt_Tipo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txt_AnoCriacao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txt_Name;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ListView listView_Alunos;
        private ImageList imageList1;
    }
}