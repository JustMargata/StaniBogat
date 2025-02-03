using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaniBogat_Marten
{
    public partial class FormQuestData : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StaniBogat;Integrated Security=True;");

        public FormQuestData()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            string command = "SELECT Id, Question, AnsA, AnsB, AnsC, AnsD, CorrectAns, Points FROM dbo.Questions";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command, connection);
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при зареждането на въпросите: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int questionId = int.Parse(numID.Text);

            if (questionId > 0)
            {
                string command = "DELETE FROM dbo.Questions WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(command, connection);
                cmd.Parameters.AddWithValue("@Id", questionId);

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Въпрос с ID {questionId} е изтрит успешно!");
                    }
                    else
                    {
                        MessageBox.Show("Въпрос с такова ID не съществува.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Грешка при изтриването на въпроса: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                LoadQuestions();
            }
            else
            {
                MessageBox.Show("Моля, въведете валидно ID.");
            }
        }
    }
}
