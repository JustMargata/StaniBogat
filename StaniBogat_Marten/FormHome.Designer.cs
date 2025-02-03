namespace StaniBogat_Marten
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblToGame = new System.Windows.Forms.Label();
            this.lblToQuestions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(162, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(466, 87);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Стани Богат";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToGame
            // 
            this.lblToGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToGame.ForeColor = System.Drawing.Color.White;
            this.lblToGame.Location = new System.Drawing.Point(21, 327);
            this.lblToGame.Name = "lblToGame";
            this.lblToGame.Size = new System.Drawing.Size(266, 84);
            this.lblToGame.TabIndex = 8;
            this.lblToGame.Text = "Към Играта";
            this.lblToGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToGame.Click += new System.EventHandler(this.lblToGame_Click);
            // 
            // lblToQuestions
            // 
            this.lblToQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblToQuestions.ForeColor = System.Drawing.Color.White;
            this.lblToQuestions.Location = new System.Drawing.Point(510, 327);
            this.lblToQuestions.Name = "lblToQuestions";
            this.lblToQuestions.Size = new System.Drawing.Size(266, 84);
            this.lblToQuestions.TabIndex = 9;
            this.lblToQuestions.Text = "Попълване на въпроси";
            this.lblToQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToQuestions.Click += new System.EventHandler(this.lblToQuestions_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StaniBogat_Marten.Properties.Resources.pgzaimovLogoLikeStaniBogat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToQuestions);
            this.Controls.Add(this.lblToGame);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.Text = "Стани Богат";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblToGame;
        private System.Windows.Forms.Label lblToQuestions;
    }
}

