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
    public partial class FormQuestions : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StaniBogat;Integrated Security=True;");

        public FormQuestions()
        {            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "" && txtAnsA.Text == "" && txtAnsB.Text == "" && txtAnsC.Text == "" &&
                txtAnsD.Text == "")
            {
                if (radioAnsA.Checked == false || radioAnsB.Checked == false || radioAnsC.Checked == false ||
                    radioAnsD.Checked == false)
                {
                    MessageBox.Show("Всичко трябва да е попълнено!!!", "ГРЕШКА!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }

            connection.Open();

            // Заявката за добавяне на нов въпрос
            string query = "INSERT INTO [dbo].[Questions] (Question, AnsA, AnsB, AnsC, AnsD, CorrectAns, Points) " +
                           "VALUES (@Question, @AnsA, @AnsB, @AnsC, @AnsD, @CorrectAns, @Points)";

            // Подготовка на командата
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Question", txtQuestion.Text);
            cmd.Parameters.AddWithValue("@AnsA", txtAnsA.Text);
            cmd.Parameters.AddWithValue("@AnsB", txtAnsB.Text);
            cmd.Parameters.AddWithValue("@AnsC", txtAnsC.Text);
            cmd.Parameters.AddWithValue("@AnsD", txtAnsD.Text);
            if (radioAnsA.Checked)
            {
                cmd.Parameters.AddWithValue("@CorrectAns", radioAnsA.Text);
            }
            if (radioAnsB.Checked)
            {
                cmd.Parameters.AddWithValue("@CorrectAns", radioAnsB.Text);
            }
            if (radioAnsC.Checked)
            {
                cmd.Parameters.AddWithValue("@CorrectAns", radioAnsC.Text);
            }
            if (radioAnsD.Checked)
            {
                cmd.Parameters.AddWithValue("@CorrectAns", radioAnsD.Text);
            }
            cmd.Parameters.AddWithValue("@Points", int.Parse(numPoints.Text)); // Точки

            // Изпълняваме заявката
            cmd.ExecuteNonQuery();

            // Извеждаме съобщение за успешен запис
            MessageBox.Show("Въпросът беше успешно добавен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtQuestion.Clear();
            txtAnsA.Clear();
            txtAnsB.Clear();
            txtAnsC.Clear();
            txtAnsD.Clear();

            radioAnsA.Checked = false;
            radioAnsB.Checked = false;
            radioAnsC.Checked = false;
            radioAnsD.Checked = false;
            numPoints.Text = "1";

            // Затваряме връзката
            connection.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();
            this.Close();
        }

        private void btnAllQuest_Click(object sender, EventArgs e)
        {
            FormQuestData frmQuestData = new FormQuestData();
            frmQuestData.Show();
        }
    }
}
