using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaniBogat_Marten
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void lblToGame_Click(object sender, EventArgs e)
        {
            FormGame game = new FormGame();
            game.Show();
            this.Hide();
        }

        private void lblToQuestions_Click(object sender, EventArgs e)
        {
            FormQuestions questions = new FormQuestions();
            questions.Show();
            this.Hide();
        }
    }
}
