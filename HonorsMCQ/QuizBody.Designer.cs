namespace HonorsMCQ
{
    partial class QuizBody
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
            this.labQuestion = new System.Windows.Forms.Label();
            this.radAnsw1 = new System.Windows.Forms.RadioButton();
            this.radAnsw2 = new System.Windows.Forms.RadioButton();
            this.radAnsw3 = new System.Windows.Forms.RadioButton();
            this.radAnsw4 = new System.Windows.Forms.RadioButton();
            this.butSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labQuestion
            // 
            this.labQuestion.AutoSize = true;
            this.labQuestion.Location = new System.Drawing.Point(34, 61);
            this.labQuestion.Name = "labQuestion";
            this.labQuestion.Size = new System.Drawing.Size(35, 13);
            this.labQuestion.TabIndex = 0;
            this.labQuestion.Text = "label1";
            // 
            // radAnsw1
            // 
            this.radAnsw1.AutoSize = true;
            this.radAnsw1.Location = new System.Drawing.Point(37, 151);
            this.radAnsw1.Name = "radAnsw1";
            this.radAnsw1.Size = new System.Drawing.Size(85, 17);
            this.radAnsw1.TabIndex = 1;
            this.radAnsw1.TabStop = true;
            this.radAnsw1.Text = "radioButton1";
            this.radAnsw1.UseVisualStyleBackColor = true;
            // 
            // radAnsw2
            // 
            this.radAnsw2.AutoSize = true;
            this.radAnsw2.Location = new System.Drawing.Point(37, 204);
            this.radAnsw2.Name = "radAnsw2";
            this.radAnsw2.Size = new System.Drawing.Size(85, 17);
            this.radAnsw2.TabIndex = 2;
            this.radAnsw2.TabStop = true;
            this.radAnsw2.Text = "radioButton2";
            this.radAnsw2.UseVisualStyleBackColor = true;
            // 
            // radAnsw3
            // 
            this.radAnsw3.AutoSize = true;
            this.radAnsw3.Location = new System.Drawing.Point(37, 257);
            this.radAnsw3.Name = "radAnsw3";
            this.radAnsw3.Size = new System.Drawing.Size(85, 17);
            this.radAnsw3.TabIndex = 3;
            this.radAnsw3.TabStop = true;
            this.radAnsw3.Text = "radioButton3";
            this.radAnsw3.UseVisualStyleBackColor = true;
            // 
            // radAnsw4
            // 
            this.radAnsw4.AutoSize = true;
            this.radAnsw4.Location = new System.Drawing.Point(37, 311);
            this.radAnsw4.Name = "radAnsw4";
            this.radAnsw4.Size = new System.Drawing.Size(85, 17);
            this.radAnsw4.TabIndex = 4;
            this.radAnsw4.TabStop = true;
            this.radAnsw4.Text = "radioButton4";
            this.radAnsw4.UseVisualStyleBackColor = true;
            // 
            // butSubmit
            // 
            this.butSubmit.Location = new System.Drawing.Point(572, 371);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(96, 52);
            this.butSubmit.TabIndex = 5;
            this.butSubmit.Text = "Submit";
            this.butSubmit.UseVisualStyleBackColor = true;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // QuizBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butSubmit);
            this.Controls.Add(this.radAnsw4);
            this.Controls.Add(this.radAnsw3);
            this.Controls.Add(this.radAnsw2);
            this.Controls.Add(this.radAnsw1);
            this.Controls.Add(this.labQuestion);
            this.Name = "QuizBody";
            this.Text = "QuizBody";
            this.Load += new System.EventHandler(this.QuizBody_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labQuestion;
        private System.Windows.Forms.RadioButton radAnsw1;
        private System.Windows.Forms.RadioButton radAnsw2;
        private System.Windows.Forms.RadioButton radAnsw3;
        private System.Windows.Forms.RadioButton radAnsw4;
        private System.Windows.Forms.Button butSubmit;
    }
}