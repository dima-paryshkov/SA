namespace Системный_анализ
{
    partial class ExpertInterface
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
            this.Problems = new System.Windows.Forms.ListBox();
            this.ProblemsListLable = new System.Windows.Forms.Label();
            this.ProblemsComboBox = new System.Windows.Forms.ComboBox();
            this.FormuletionProblemLabel = new System.Windows.Forms.Label();
            this.CurrentProblemFormulation = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Problems
            // 
            this.Problems.FormattingEnabled = true;
            this.Problems.Location = new System.Drawing.Point(3, 2);
            this.Problems.Name = "Problems";
            this.Problems.Size = new System.Drawing.Size(698, 212);
            this.Problems.TabIndex = 11;
            // 
            // ProblemsListLable
            // 
            this.ProblemsListLable.AutoSize = true;
            this.ProblemsListLable.BackColor = System.Drawing.Color.White;
            this.ProblemsListLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProblemsListLable.Location = new System.Drawing.Point(7, 5);
            this.ProblemsListLable.Name = "ProblemsListLable";
            this.ProblemsListLable.Size = new System.Drawing.Size(130, 18);
            this.ProblemsListLable.TabIndex = 14;
            this.ProblemsListLable.Text = "Список проблем:";
            // 
            // ProblemsComboBox
            // 
            this.ProblemsComboBox.FormattingEnabled = true;
            this.ProblemsComboBox.Location = new System.Drawing.Point(143, 5);
            this.ProblemsComboBox.Name = "ProblemsComboBox";
            this.ProblemsComboBox.Size = new System.Drawing.Size(138, 21);
            this.ProblemsComboBox.TabIndex = 15;
            // 
            // FormuletionProblemLabel
            // 
            this.FormuletionProblemLabel.AutoSize = true;
            this.FormuletionProblemLabel.BackColor = System.Drawing.Color.White;
            this.FormuletionProblemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormuletionProblemLabel.Location = new System.Drawing.Point(287, 9);
            this.FormuletionProblemLabel.Name = "FormuletionProblemLabel";
            this.FormuletionProblemLabel.Size = new System.Drawing.Size(195, 18);
            this.FormuletionProblemLabel.TabIndex = 16;
            this.FormuletionProblemLabel.Text = "Формулировка проблемы:";
            // 
            // CurrentProblemFormulation
            // 
            this.CurrentProblemFormulation.BackColor = System.Drawing.Color.White;
            this.CurrentProblemFormulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentProblemFormulation.Location = new System.Drawing.Point(290, 35);
            this.CurrentProblemFormulation.Name = "CurrentProblemFormulation";
            this.CurrentProblemFormulation.Size = new System.Drawing.Size(397, 157);
            this.CurrentProblemFormulation.TabIndex = 17;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(482, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(219, 48);
            this.button7.TabIndex = 39;
            this.button7.Text = "Сохранить в файл";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 48);
            this.button1.TabIndex = 40;
            this.button1.Text = "Ввести оценку проблемы";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(3, 220);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(219, 48);
            this.BackButton.TabIndex = 41;
            this.BackButton.Text = "Вернуться в меню";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ExpertInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 284);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.CurrentProblemFormulation);
            this.Controls.Add(this.FormuletionProblemLabel);
            this.Controls.Add(this.ProblemsComboBox);
            this.Controls.Add(this.ProblemsListLable);
            this.Controls.Add(this.Problems);
            this.Name = "ExpertInterface";
            this.Text = "ExpertInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Problems;
        private System.Windows.Forms.Label ProblemsListLable;
        private System.Windows.Forms.ComboBox ProblemsComboBox;
        private System.Windows.Forms.Label FormuletionProblemLabel;
        private System.Windows.Forms.Label CurrentProblemFormulation;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackButton;
    }
}