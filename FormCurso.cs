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
    public partial class FormCurso : MaterialForm
    {
        bool isAlteracao = false;
        string cs = @"server=localhost;" +
                      "uid=root;" +
                      "pwd=;" +
                      "database=academico";
        public FormCurso()
        {
            InitializeComponent();
        }

        private void txt_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Name_Click(object sender, EventArgs e)
        {

        }

        private void txt_Id_Click(object sender, EventArgs e)
        {

        }

        private void txt_AnoCriacao_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl2_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private bool ValidarFormulario()
        {

            if (string.IsNullOrEmpty(txt_Name.Text))
            {
                MessageBox.Show("Nome é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Name.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txt_Tipo.Text))
            {
                MessageBox.Show("Tipo é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Tipo.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txt_AnoCriacao.Text))
            {
                MessageBox.Show("Ano de criacao é obrigatório", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AnoCriacao.Focus();
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
                sql = "INSERT INTO curso" +
         "(nome, tipo, ano_criacao)" +
         " VALUES " +
         "(@nome, @tipo, @ano_criacao)";

            }
            else
            {
                sql = "UPDATE curso set " +
                   "nome = @nome," +
                   "tipo = @tipo," +
                   "ano_criacao = @ano_criacao" +
                   " WHERE id = @id";

            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome", txt_Name.Text);
            cmd.Parameters.AddWithValue("@tipo", txt_Tipo.Text);
            cmd.Parameters.AddWithValue("@ano_criacao", txt_AnoCriacao.Text);

            if (isAlteracao)
                cmd.Parameters.AddWithValue("@id", txt_Id.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPage3.Controls)
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
                materialTabControl2.SelectedIndex = 1;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Salvar();
                materialTabControl2.SelectedIndex = 1;
            }
        }

        private void CarregaGrid()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM curso";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            materialTabControl2.SelectedIndex = 0;
            txt_Name.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                isAlteracao = true;
                var linha = dataGridView2.SelectedRows[0];
                txt_Id.Text = linha.Cells["id"].Value.ToString();
                txt_Name.Text = linha.Cells["nome"].Value.ToString();
                txt_Tipo.Text = linha.Cells["tipo"].Value.ToString();
                txt_AnoCriacao.Text = linha.Cells["ano_criacao"].Value.ToString();
                materialTabControl2.SelectedIndex = 0;
                txt_Name.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente deletar?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int id = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum curso!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM CURSO WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        private void dataGridView2_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
