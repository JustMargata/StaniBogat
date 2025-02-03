using System.Drawing;
using System.Windows.Forms;

namespace StaniBogat_Marten
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblAllQuestions = new System.Windows.Forms.Label();
            this.lblAnsA = new System.Windows.Forms.Label();
            this.lblAnsC = new System.Windows.Forms.Label();
            this.lblAnsB = new System.Windows.Forms.Label();
            this.lblAnsD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(94, 71);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(596, 70);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionNumber.ForeColor = System.Drawing.Color.White;
            this.lblQuestionNumber.Location = new System.Drawing.Point(225, 42);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(347, 25);
            this.lblQuestionNumber.TabIndex = 5;
            this.lblQuestionNumber.Text = "Number";
            this.lblQuestionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAllQuestions
            // 
            this.lblAllQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAllQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAllQuestions.ForeColor = System.Drawing.Color.White;
            this.lblAllQuestions.Location = new System.Drawing.Point(2, 0);
            this.lblAllQuestions.Name = "lblAllQuestions";
            this.lblAllQuestions.Size = new System.Drawing.Size(170, 42);
            this.lblAllQuestions.TabIndex = 6;
            this.lblAllQuestions.Text = "All Questions";
            this.lblAllQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnsA
            // 
            this.lblAnsA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAnsA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnsA.ForeColor = System.Drawing.Color.White;
            this.lblAnsA.Location = new System.Drawing.Point(47, 197);
            this.lblAnsA.Name = "lblAnsA";
            this.lblAnsA.Size = new System.Drawing.Size(266, 84);
            this.lblAnsA.TabIndex = 7;
            this.lblAnsA.Text = "A";
            this.lblAnsA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnsA.Click += new System.EventHandler(this.lblAnsA_Click);
            // 
            // lblAnsC
            // 
            this.lblAnsC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAnsC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnsC.ForeColor = System.Drawing.Color.White;
            this.lblAnsC.Location = new System.Drawing.Point(47, 303);
            this.lblAnsC.Name = "lblAnsC";
            this.lblAnsC.Size = new System.Drawing.Size(266, 84);
            this.lblAnsC.TabIndex = 8;
            this.lblAnsC.Text = "C";
            this.lblAnsC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnsC.Click += new System.EventHandler(this.lblAnsC_Click);
            // 
            // lblAnsB
            // 
            this.lblAnsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAnsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnsB.ForeColor = System.Drawing.Color.White;
            this.lblAnsB.Location = new System.Drawing.Point(491, 197);
            this.lblAnsB.Name = "lblAnsB";
            this.lblAnsB.Size = new System.Drawing.Size(266, 84);
            this.lblAnsB.TabIndex = 9;
            this.lblAnsB.Text = "B";
            this.lblAnsB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnsB.Click += new System.EventHandler(this.lblAnsB_Click);
            // 
            // lblAnsD
            // 
            this.lblAnsD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAnsD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnsD.ForeColor = System.Drawing.Color.White;
            this.lblAnsD.Location = new System.Drawing.Point(491, 303);
            this.lblAnsD.Name = "lblAnsD";
            this.lblAnsD.Size = new System.Drawing.Size(266, 84);
            this.lblAnsD.TabIndex = 10;
            this.lblAnsD.Text = "D";
            this.lblAnsD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnsD.Click += new System.EventHandler(this.lblAnsD_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StaniBogat_Marten.Properties.Resources.BackgroundStaniBogat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnsD);
            this.Controls.Add(this.lblAnsB);
            this.Controls.Add(this.lblAnsC);
            this.Controls.Add(this.lblAnsA);
            this.Controls.Add(this.lblAllQuestions);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.lblQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.Text = "Стани Богат";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblAllQuestions;
        private Label lblAnsA;
        private Label lblAnsC;
        private Label lblAnsB;
        private Label lblAnsD;
    }
}