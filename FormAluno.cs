using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Data;

namespace Projeto3
{
    public partial class FormAluno : MaterialForm
    {
        bool isAlteracao = false;
        string cs = @"server=localhost;" +
                      "uid=root;" +
                      "pwd=;" +
                      "database=academico";
        public FormAluno()
        {
            InitializeComponent();
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBoxEdit1_Click(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBoxEdit3_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                materialTabControl1.SelectedIndex = 1;
            }
        }

        private void textNome_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBoxEdit5_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Salvar();
                materialTabControl1.SelectedIndex = 1;
            }
        }

        private void Salvar()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "";
            if (!isAlteracao)
            {
                sql = "INSERT INTO aluno" +
         "(Matricula, dt_nascimento, nome, endereco, bairro, cidade, estado, senha)" +
         " VALUES " +
         "(@matricula, @dt_nascimento, @nome, @endereco, @bairro, @cidade, @estado, @senha)";


            }
            else
            {
                sql = "UPDATE aluno set " +
                   "matricula = @matricula," +
                   "dt_nascimento = @dt_nascimento," +
                   "nome = @nome," +
                   "endereco = @endereco," +
                   "bairro = @bairro," +
                   "cidade = @cidade," +
                   "estado = @estado," +
                   "senha = @senha" +
                   " WHERE id = @id";

            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matricula", txt_Matricula.Text);
            DateTime.TryParse(txt_Data.Text, out var dataNascimento);
            cmd.Parameters.AddWithValue("@dt_nascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@nome", txt_Name.Text);
            cmd.Parameters.AddWithValue("@endereco", txt_Endereço.Text);
            cmd.Parameters.AddWithValue("@bairro", txt_Bairro.Text);
            cmd.Parameters.AddWithValue("@cidade", txt_Cidade.Text);
            cmd.Parameters.AddWithValue("@estado", txt_UF.Text);
            cmd.Parameters.AddWithValue("@senha", txt_Senha.Text);
            if (isAlteracao)
                cmd.Parameters.AddWithValue("@id", txt_Id.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            LimpaCampos();
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txt_Matricula.Text))
            {
                MessageBox.Show("Matricula é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Matricula.Focus();
                return false;

            }

            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                MessageBox.Show("Nome é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Name.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txt_Endereço.Text))
            {
                MessageBox.Show("Endereço é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Endereço.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txt_Bairro.Text))
            {
                MessageBox.Show("Bairro é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Bairro.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txt_Cidade.Text))
            {
                MessageBox.Show("Cidade é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Cidade.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txt_Senha.Text))
            {
                MessageBox.Show("Senha é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Senha.Focus();
                return false;

            }
            if (!DateTime.TryParse(txt_Data.Text, out DateTime _))
            {
                MessageBox.Show("Data é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Data.Focus();
                return false;

            }

            return true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void tabPage2_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void listView_Alunos_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if (e.ItemIndex % 2 == 1)
            {
                e.Item.BackColor = Color.FromArgb(230, 230, 255);
                e.Item.UseItemStyleForSubItems = true;
            }
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPage1.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }

                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void CarregaGrid()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM aluno";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            materialTabControl1.SelectedIndex = 0;
            txt_Matricula.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                isAlteracao = true;
                var linha = dataGridView1.SelectedRows[0];
                txt_Id.Text = linha.Cells["id"].Value.ToString();
                txt_Matricula.Text = linha.Cells["matricula"].Value.ToString();
                txt_Data.Text = linha.Cells["dt_nascimento"].Value.ToString();
                txt_Name.Text = linha.Cells["nome"].Value.ToString();
                txt_Endereço.Text = linha.Cells["endereco"].Value.ToString();
                txt_Bairro.Text = linha.Cells["bairro"].Value.ToString();
                txt_Cidade.Text = linha.Cells["cidade"].Value.ToString();
                txt_UF.Text = linha.Cells["estado"].Value.ToString();
                txt_Senha.Text = linha.Cells["senha"].Value.ToString();
                materialTabControl1.SelectedIndex = 0;
                txt_Matricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Deletar()
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente deletar?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM ALUNO WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        private void listView_Alunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void listView_Alunos_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialTabControl1_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void txtid_Click(object sender, EventArgs e)
        {

        }
    }
}
