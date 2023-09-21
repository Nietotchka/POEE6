using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace Projeto4
{
    public partial class FormProfessor : MaterialForm
    {
        bool isAlteracao = false;
        string cs = @"server=localhost;" +
                      "uid=root;" +
                      "pwd=;" +
                      "database=academico";
        public FormProfessor()
        {
            InitializeComponent();
        }

        private void txt_Matricula_Click(object sender, EventArgs e)
        {

        }

        private void txt_Name_Click(object sender, EventArgs e)
        {

        }

        private void txt_Data_Click(object sender, EventArgs e)
        {

        }

        private void txt_Id_Click(object sender, EventArgs e)
        {

        }

        private void txt_Endereço_Click(object sender, EventArgs e)
        {

        }

        private void txt_Bairro_Click(object sender, EventArgs e)
        {

        }

        private void txt_Cidade_Click(object sender, EventArgs e)
        {

        }

        private void txt_UF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Titulacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_AreaFormacao_Click(object sender, EventArgs e)
        {

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

            if (string.IsNullOrEmpty(txt_AreaFormacao.Text))
            {
                MessageBox.Show("Área de formação é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AreaFormacao.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txt_Cidade.Text))
            {
                MessageBox.Show("Cidade é obrigatória", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Cidade.Focus();
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

        private void Salvar()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "";
            if (!isAlteracao)
            {
                sql = "INSERT INTO professor" +
         "(Matricula, dt_nascimento, nome, titulacao, area_formacao, endereco, bairro, cidade, estado)" +
         " VALUES " +
         "(@matricula, @dt_nascimento, @nome, @titulacao, @area_formacao, @endereco, @bairro, @cidade, @estado)";


            }
            else
            {
                sql = "UPDATE professor set " +
                   "matricula = @matricula," +
                   "dt_nascimento = @dt_nascimento," +
                   "nome = @nome," +
                   "titulacao = @titulacao," +
                   "area_formacao = @areaformacao," +
                   "endereco = @endereco," +
                   "bairro = @bairro," +
                   "cidade = @cidade," +
                   "estado = @estado" +
                   " WHERE id = @id";

            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matricula", txt_Matricula.Text);
            DateTime.TryParse(txt_Data.Text, out var dataNascimento);
            cmd.Parameters.AddWithValue("@dt_nascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@nome", txt_Name.Text);
            cmd.Parameters.AddWithValue("@titulacao", txt_Titulacao.Text);
            cmd.Parameters.AddWithValue("@area_formacao", txt_AreaFormacao.Text);
            cmd.Parameters.AddWithValue("@endereco", txt_Endereço.Text);
            cmd.Parameters.AddWithValue("@bairro", txt_Bairro.Text);
            cmd.Parameters.AddWithValue("@cidade", txt_Cidade.Text);
            cmd.Parameters.AddWithValue("@estado", txt_UF.Text);
            if (isAlteracao)
                cmd.Parameters.AddWithValue("@id", txt_Id.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            LimpaCampos();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Salvar();
                materialTabControl1.SelectedIndex = 1;
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                materialTabControl1.SelectedIndex = 1;
            }
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
            if (dataGridView3.SelectedRows.Count > 0)
            {

                isAlteracao = true;
                var linha = dataGridView3.SelectedRows[0];
                txt_Id.Text = linha.Cells["id"].Value.ToString();
                txt_Matricula.Text = linha.Cells["matricula"].Value.ToString();
                txt_Data.Text = linha.Cells["dt_nascimento"].Value.ToString();
                txt_Name.Text = linha.Cells["nome"].Value.ToString();
                txt_Titulacao.Text = linha.Cells["titulacao"].Value.ToString();
                txt_AreaFormacao.Text = linha.Cells["area_formacao"].Value.ToString();
                txt_Endereço.Text = linha.Cells["endereco"].Value.ToString();
                txt_Bairro.Text = linha.Cells["bairro"].Value.ToString();
                txt_Cidade.Text = linha.Cells["cidade"].Value.ToString();
                txt_UF.Text = linha.Cells["estado"].Value.ToString();
                materialTabControl1.SelectedIndex = 0;
                txt_Matricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum professor!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM PROFESSOR WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        private void CarregaGrid()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM professor";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente deletar?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int id = (int)dataGridView3.SelectedRows[0].Cells[0].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum professor!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FormProfessor_Load(object sender, EventArgs e)
        {

        }
    }
}
