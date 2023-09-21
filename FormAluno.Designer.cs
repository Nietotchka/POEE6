namespace Projeto3
{
    partial class FormAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAluno));
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            txt_Id = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txt_Matricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btn_cancelar = new ReaLTaiizor.Controls.MaterialButton();
            btn_salvar = new ReaLTaiizor.Controls.MaterialButton();
            txt_UF = new ReaLTaiizor.Controls.MaterialComboBox();
            txt_Cidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txt_Senha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txt_Bairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txt_Endereço = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txt_Data = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txt_Name = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            listView_Alunos = new ListView();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(618, 383);
            materialTabControl1.TabIndex = 0;
            materialTabControl1.Enter += materialTabControl1_Enter;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txt_Id);
            tabPage1.Controls.Add(txt_Matricula);
            tabPage1.Controls.Add(btn_cancelar);
            tabPage1.Controls.Add(btn_salvar);
            tabPage1.Controls.Add(txt_UF);
            tabPage1.Controls.Add(txt_Cidade);
            tabPage1.Controls.Add(txt_Senha);
            tabPage1.Controls.Add(txt_Bairro);
            tabPage1.Controls.Add(txt_Endereço);
            tabPage1.Controls.Add(txt_Data);
            tabPage1.Controls.Add(txt_Name);
            tabPage1.ImageKey = "form.png";
            tabPage1.Location = new Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(610, 348);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
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
            txt_Id.Location = new Point(447, 37);
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
            txt_Id.TabIndex = 10;
            txt_Id.TabStop = false;
            txt_Id.TextAlign = HorizontalAlignment.Left;
            txt_Id.TrailingIcon = null;
            txt_Id.UseSystemPasswordChar = false;
            txt_Id.Click += txtid_Click;
            // 
            // txt_Matricula
            // 
            txt_Matricula.AnimateReadOnly = false;
            txt_Matricula.AutoCompleteMode = AutoCompleteMode.None;
            txt_Matricula.AutoCompleteSource = AutoCompleteSource.None;
            txt_Matricula.BackgroundImageLayout = ImageLayout.None;
            txt_Matricula.CharacterCasing = CharacterCasing.Normal;
            txt_Matricula.Depth = 0;
            txt_Matricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_Matricula.HideSelection = true;
            txt_Matricula.Hint = "Prontuário";
            txt_Matricula.LeadingIcon = null;
            txt_Matricula.Location = new Point(3, 37);
            txt_Matricula.MaxLength = 32767;
            txt_Matricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.PasswordChar = '\0';
            txt_Matricula.PrefixSuffixText = null;
            txt_Matricula.ReadOnly = false;
            txt_Matricula.RightToLeft = RightToLeft.No;
            txt_Matricula.SelectedText = "";
            txt_Matricula.SelectionLength = 0;
            txt_Matricula.SelectionStart = 0;
            txt_Matricula.ShortcutsEnabled = true;
            txt_Matricula.Size = new Size(250, 48);
            txt_Matricula.TabIndex = 9;
            txt_Matricula.TabStop = false;
            txt_Matricula.TextAlign = HorizontalAlignment.Left;
            txt_Matricula.TrailingIcon = null;
            txt_Matricula.UseSystemPasswordChar = false;
            txt_Matricula.Click += materialTextBoxEdit5_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_cancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_cancelar.Depth = 0;
            btn_cancelar.HighEmphasis = true;
            btn_cancelar.Icon = null;
            btn_cancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_cancelar.Location = new Point(423, 303);
            btn_cancelar.Margin = new Padding(4, 6, 4, 6);
            btn_cancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.NoAccentTextColor = Color.Empty;
            btn_cancelar.Size = new Size(96, 36);
            btn_cancelar.TabIndex = 8;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_cancelar.UseAccentColor = false;
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += materialButton2_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_salvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_salvar.Depth = 0;
            btn_salvar.HighEmphasis = true;
            btn_salvar.Icon = null;
            btn_salvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_salvar.Location = new Point(527, 303);
            btn_salvar.Margin = new Padding(4, 6, 4, 6);
            btn_salvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_salvar.Name = "btn_salvar";
            btn_salvar.NoAccentTextColor = Color.Empty;
            btn_salvar.Size = new Size(76, 36);
            btn_salvar.TabIndex = 7;
            btn_salvar.Text = "Salvar";
            btn_salvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_salvar.UseAccentColor = false;
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // txt_UF
            // 
            txt_UF.AutoResize = false;
            txt_UF.BackColor = Color.FromArgb(255, 255, 255);
            txt_UF.Depth = 0;
            txt_UF.DrawMode = DrawMode.OwnerDrawVariable;
            txt_UF.DropDownHeight = 174;
            txt_UF.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_UF.DropDownWidth = 121;
            txt_UF.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txt_UF.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txt_UF.FormattingEnabled = true;
            txt_UF.Hint = "UF";
            txt_UF.IntegralHeight = false;
            txt_UF.ItemHeight = 43;
            txt_UF.Items.AddRange(new object[] { "", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            txt_UF.Location = new Point(447, 242);
            txt_UF.MaxDropDownItems = 4;
            txt_UF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txt_UF.Name = "txt_UF";
            txt_UF.Size = new Size(121, 49);
            txt_UF.StartIndex = 0;
            txt_UF.TabIndex = 6;
            txt_UF.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            // 
            // txt_Cidade
            // 
            txt_Cidade.AnimateReadOnly = false;
            txt_Cidade.AutoCompleteMode = AutoCompleteMode.None;
            txt_Cidade.AutoCompleteSource = AutoCompleteSource.None;
            txt_Cidade.BackgroundImageLayout = ImageLayout.None;
            txt_Cidade.CharacterCasing = CharacterCasing.Normal;
            txt_Cidade.Depth = 0;
            txt_Cidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_Cidade.HideSelection = true;
            txt_Cidade.Hint = "Cidade";
            txt_Cidade.LeadingIcon = null;
            txt_Cidade.Location = new Point(3, 243);
            txt_Cidade.MaxLength = 32767;
            txt_Cidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txt_Cidade.Name = "txt_Cidade";
            txt_Cidade.PasswordChar = '\0';
            txt_Cidade.PrefixSuffixText = null;
            txt_Cidade.ReadOnly = false;
            txt_Cidade.RightToLeft = RightToLeft.No;
            txt_Cidade.SelectedText = "";
            txt_Cidade.SelectionLength = 0;
            txt_Cidade.SelectionStart = 0;
            txt_Cidade.ShortcutsEnabled = true;
            txt_Cidade.Size = new Size(419, 48);
            txt_Cidade.TabIndex = 5;
            txt_Cidade.TabStop = false;
            txt_Cidade.TextAlign = HorizontalAlignment.Left;
            txt_Cidade.TrailingIcon = null;
            txt_Cidade.UseSystemPasswordChar = false;
            // 
            // txt_Senha
            // 
            txt_Senha.AnimateReadOnly = false;
            txt_Senha.AutoCompleteMode = AutoCompleteMode.None;
            txt_Senha.AutoCompleteSource = AutoCompleteSource.None;
            txt_Senha.BackgroundImageLayout = ImageLayout.None;
            txt_Senha.CharacterCasing = CharacterCasing.Normal;
            txt_Senha.Depth = 0;
            txt_Senha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_Senha.HideSelection = true;
            txt_Senha.Hint = "Senha";
            txt_Senha.LeadingIcon = (Image)resources.GetObject("txt_Senha.LeadingIcon");
            txt_Senha.Location = new Point(3, 297);
            txt_Senha.MaxLength = 32767;
            txt_Senha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txt_Senha.Name = "txt_Senha";
            txt_Senha.PasswordChar = '*';
            txt_Senha.PrefixSuffixText = null;
            txt_Senha.ReadOnly = false;
            txt_Senha.RightToLeft = RightToLeft.No;
            txt_Senha.SelectedText = "";
            txt_Senha.SelectionLength = 0;
            txt_Senha.SelectionStart = 0;
            txt_Senha.ShortcutsEnabled = true;
            txt_Senha.Size = new Size(419, 48);
            txt_Senha.TabIndex = 4;
            txt_Senha.TabStop = false;
            txt_Senha.TextAlign = HorizontalAlignment.Left;
            txt_Senha.TrailingIcon = null;
            txt_Senha.UseSystemPasswordChar = false;
            txt_Senha.Click += materialTextBoxEdit3_Click;
            // 
            // txt_Bairro
            // 
            txt_Bairro.AnimateReadOnly = false;
            txt_Bairro.AutoCompleteMode = AutoCompleteMode.None;
            txt_Bairro.AutoCompleteSource = AutoCompleteSource.None;
            txt_Bairro.BackgroundImageLayout = ImageLayout.None;
            txt_Bairro.CharacterCasing = CharacterCasing.Normal;
            txt_Bairro.Depth = 0;
            txt_Bairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_Bairro.HideSelection = true;
            txt_Bairro.Hint = "Bairro";
            txt_Bairro.LeadingIcon = null;
            txt_Bairro.Location = new Point(3, 189);
            txt_Bairro.MaxLength = 32767;
            txt_Bairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txt_Bairro.Name = "txt_Bairro";
            txt_Bairro.PasswordChar = '\0';
            txt_Bairro.PrefixSuffixText = null;
            txt_Bairro.ReadOnly = false;
            txt_Bairro.RightToLeft = RightToLeft.No;
            txt_Bairro.SelectedText = "";
            txt_Bairro.SelectionLength = 0;
            txt_Bairro.SelectionStart = 0;
            txt_Bairro.ShortcutsEnabled = true;
            txt_Bairro.Size = new Size(534, 48);
            txt_Bairro.TabIndex = 3;
            txt_Bairro.TabStop = false;
            txt_Bairro.TextAlign = HorizontalAlignment.Left;
            txt_Bairro.TrailingIcon = null;
            txt_Bairro.UseSystemPasswordChar = false;
            // 
            // txt_Endereço
            // 
            txt_Endereço.AnimateReadOnly = false;
            txt_Endereço.AutoCompleteMode = AutoCompleteMode.None;
            txt_Endereço.AutoCompleteSource = AutoCompleteSource.None;
            txt_Endereço.BackgroundImageLayout = ImageLayout.None;
            txt_Endereço.CharacterCasing = CharacterCasing.Normal;
            txt_Endereço.Depth = 0;
            txt_Endereço.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_Endereço.HideSelection = true;
            txt_Endereço.Hint = "Endereço";
            txt_Endereço.LeadingIcon = null;
            txt_Endereço.Location = new Point(3, 135);
            txt_Endereço.MaxLength = 32767;
            txt_Endereço.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txt_Endereço.Name = "txt_Endereço";
            txt_Endereço.PasswordChar = '\0';
            txt_Endereço.PrefixSuffixText = null;
            txt_Endereço.ReadOnly = false;
            txt_Endereço.RightToLeft = RightToLeft.No;
            txt_Endereço.SelectedText = "";
            txt_Endereço.SelectionLength = 0;
            txt_Endereço.SelectionStart = 0;
            txt_Endereço.ShortcutsEnabled = true;
            txt_Endereço.Size = new Size(534, 48);
            txt_Endereço.TabIndex = 2;
            txt_Endereço.TabStop = false;
            txt_Endereço.TextAlign = HorizontalAlignment.Left;
            txt_Endereço.TrailingIcon = null;
            txt_Endereço.UseSystemPasswordChar = false;
            txt_Endereço.Click += textNome_Click;
            // 
            // txt_Data
            // 
            txt_Data.AllowPromptAsInput = true;
            txt_Data.AnimateReadOnly = false;
            txt_Data.AsciiOnly = false;
            txt_Data.BackgroundImageLayout = ImageLayout.None;
            txt_Data.BeepOnError = false;
            txt_Data.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txt_Data.Depth = 0;
            txt_Data.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_Data.HidePromptOnLeave = false;
            txt_Data.HideSelection = true;
            txt_Data.Hint = "Data de Nascimento";
            txt_Data.InsertKeyMode = InsertKeyMode.Default;
            txt_Data.LeadingIcon = null;
            txt_Data.Location = new Point(269, 37);
            txt_Data.Mask = "99/99/99";
            txt_Data.MaxLength = 32767;
            txt_Data.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txt_Data.Name = "txt_Data";
            txt_Data.PasswordChar = '\0';
            txt_Data.PrefixSuffixText = null;
            txt_Data.PromptChar = '_';
            txt_Data.ReadOnly = false;
            txt_Data.RejectInputOnFirstFailure = false;
            txt_Data.ResetOnPrompt = true;
            txt_Data.ResetOnSpace = true;
            txt_Data.RightToLeft = RightToLeft.No;
            txt_Data.SelectedText = "";
            txt_Data.SelectionLength = 0;
            txt_Data.SelectionStart = 0;
            txt_Data.ShortcutsEnabled = true;
            txt_Data.Size = new Size(153, 48);
            txt_Data.SkipLiterals = true;
            txt_Data.TabIndex = 1;
            txt_Data.TabStop = false;
            txt_Data.Text = "  /  /";
            txt_Data.TextAlign = HorizontalAlignment.Left;
            txt_Data.TextMaskFormat = MaskFormat.IncludeLiterals;
            txt_Data.TrailingIcon = null;
            txt_Data.UseSystemPasswordChar = false;
            txt_Data.ValidatingType = null;
            txt_Data.Click += materialMaskedTextBox1_Click;
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
            txt_Name.Location = new Point(3, 81);
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
            txt_Name.Size = new Size(534, 48);
            txt_Name.TabIndex = 0;
            txt_Name.TabStop = false;
            txt_Name.TextAlign = HorizontalAlignment.Left;
            txt_Name.TrailingIcon = null;
            txt_Name.UseSystemPasswordChar = false;
            txt_Name.Click += materialTextBoxEdit1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(btnExcluir);
            tabPage2.Controls.Add(btnEditar);
            tabPage2.Controls.Add(btnNovo);
            tabPage2.Controls.Add(listView_Alunos);
            tabPage2.ImageKey = "search.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(610, 348);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            tabPage2.Enter += tabPage2_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(604, 291);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(514, 303);
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
            btnEditar.Location = new Point(425, 303);
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
            btnNovo.Location = new Point(346, 303);
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
            listView_Alunos.DrawColumnHeader += listView_Alunos_DrawColumnHeader;
            listView_Alunos.DrawItem += listView_Alunos_DrawItem;
            listView_Alunos.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView_Alunos.MouseDoubleClick += listView_Alunos_MouseDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "search.png");
            imageList1.Images.SetKeyName(1, "form.png");
            // 
            // FormAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 450);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Aluno";
            Load += FormAluno_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txt_Name;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txt_Data;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txt_Endereço;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txt_Cidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txt_Senha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txt_Bairro;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialComboBox txt_UF;
        private ReaLTaiizor.Controls.MaterialButton btn_cancelar;
        private ReaLTaiizor.Controls.MaterialButton btn_salvar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txt_Matricula;
        private ListView listView_Alunos;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txt_Id;
    }
}