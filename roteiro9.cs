using System;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsPostgres
{
    public partial class Form1 : Form
    {
        private string connString = "Host=localhost;Username=postgres;Password=123456;Database=exemplo_db";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(sobrenome))
            {
                MessageBox.Show("Digite nome e sobrenome.");
                return;
            }

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string insertSql = "INSERT INTO usuarios (nome, sobrenome) VALUES (@nome, @sobrenome)";
                using (var cmd = new NpgsqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("sobrenome", sobrenome);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Usuário salvo com sucesso!");
            txtNome.Clear();
            txtSobrenome.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listUsuarios.Items.Clear();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT id, nome, sobrenome FROM usuarios";
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nome = reader.GetString(1);
                        string sobrenome = reader.GetString(2);
                        listUsuarios.Items.Add($"{id} - {nome} {sobrenome}");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Selecione um usuário para excluir.");
                return;
            }

            string selectedItem = listUsuarios.SelectedItem.ToString();
            int id = int.Parse(selectedItem.Split('-')[0].Trim());

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string deleteSql = "DELETE FROM usuarios WHERE id = @id";
                using (var cmd = new NpgsqlCommand(deleteSql, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Usuário excluído com sucesso!");
            btnListar_Click(sender, e);
        }
    }
}
