namespace Системный_анализ
{
    partial class AnalystInterface
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
            this.AddProblemButton = new System.Windows.Forms.Button();
            this.ProblemsComboBox = new System.Windows.Forms.ComboBox();
            this.ProblemsListLable = new System.Windows.Forms.Label();
            this.FormuletionProblemLabel = new System.Windows.Forms.Label();
            this.CurrentProblemFormulation = new System.Windows.Forms.Label();
            this.ProblemChangeButton = new System.Windows.Forms.Button();
            this.DelProblemButton = new System.Windows.Forms.Button();
            this.SolotionsList = new System.Windows.Forms.ListBox();
            this.AddSolutionButton = new System.Windows.Forms.Button();
            this.EditSolutionButton = new System.Windows.Forms.Button();
            this.DelSolutionButton = new System.Windows.Forms.Button();
            this.SolutionFormulationLabel = new System.Windows.Forms.Label();
            this.SolutionsListLabel = new System.Windows.Forms.Label();
            this.SolutionsComboBox = new System.Windows.Forms.ComboBox();
            this.SolutionFormulationLabelHead = new System.Windows.Forms.Label();
            this.ExpertsListBox = new System.Windows.Forms.ListBox();
            this.ExpertComboBox = new System.Windows.Forms.ComboBox();
            this.ExpertListLabel = new System.Windows.Forms.Label();
            this.ExpertAddButton = new System.Windows.Forms.Button();
            this.ExpertEditButton = new System.Windows.Forms.Button();
            this.ExpertDelButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ExpertDiscriptionLabel = new System.Windows.Forms.Label();
            this.ExpertLabelHead = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Problems
            // 
            this.Problems.FormattingEnabled = true;
            this.Problems.Location = new System.Drawing.Point(12, 15);
            this.Problems.Name = "Problems";
            this.Problems.Size = new System.Drawing.Size(698, 212);
            this.Problems.TabIndex = 10;
            // 
            // AddProblemButton
            // 
            this.AddProblemButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddProblemButton.Location = new System.Drawing.Point(19, 52);
            this.AddProblemButton.Name = "AddProblemButton";
            this.AddProblemButton.Size = new System.Drawing.Size(128, 22);
            this.AddProblemButton.TabIndex = 11;
            this.AddProblemButton.Text = "Добавить проблему";
            this.AddProblemButton.UseVisualStyleBackColor = false;
            this.AddProblemButton.Click += new System.EventHandler(this.AddProblemButton_Click_1);
            // 
            // ProblemsComboBox
            // 
            this.ProblemsComboBox.FormattingEnabled = true;
            this.ProblemsComboBox.Location = new System.Drawing.Point(148, 19);
            this.ProblemsComboBox.Name = "ProblemsComboBox";
            this.ProblemsComboBox.Size = new System.Drawing.Size(138, 21);
            this.ProblemsComboBox.TabIndex = 12;
            // 
            // ProblemsListLable
            // 
            this.ProblemsListLable.AutoSize = true;
            this.ProblemsListLable.BackColor = System.Drawing.Color.White;
            this.ProblemsListLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProblemsListLable.Location = new System.Drawing.Point(16, 19);
            this.ProblemsListLable.Name = "ProblemsListLable";
            this.ProblemsListLable.Size = new System.Drawing.Size(130, 18);
            this.ProblemsListLable.TabIndex = 13;
            this.ProblemsListLable.Text = "Список проблем:";
            // 
            // FormuletionProblemLabel
            // 
            this.FormuletionProblemLabel.AutoSize = true;
            this.FormuletionProblemLabel.BackColor = System.Drawing.Color.White;
            this.FormuletionProblemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormuletionProblemLabel.Location = new System.Drawing.Point(295, 22);
            this.FormuletionProblemLabel.Name = "FormuletionProblemLabel";
            this.FormuletionProblemLabel.Size = new System.Drawing.Size(195, 18);
            this.FormuletionProblemLabel.TabIndex = 14;
            this.FormuletionProblemLabel.Text = "Формулировка проблемы:";
            // 
            // CurrentProblemFormulation
            // 
            this.CurrentProblemFormulation.BackColor = System.Drawing.Color.White;
            this.CurrentProblemFormulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentProblemFormulation.Location = new System.Drawing.Point(292, 52);
            this.CurrentProblemFormulation.Name = "CurrentProblemFormulation";
            this.CurrentProblemFormulation.Size = new System.Drawing.Size(410, 157);
            this.CurrentProblemFormulation.TabIndex = 15;
            // 
            // ProblemChangeButton
            // 
            this.ProblemChangeButton.Location = new System.Drawing.Point(19, 80);
            this.ProblemChangeButton.Name = "ProblemChangeButton";
            this.ProblemChangeButton.Size = new System.Drawing.Size(128, 21);
            this.ProblemChangeButton.TabIndex = 16;
            this.ProblemChangeButton.Text = "Редактировать";
            this.ProblemChangeButton.UseVisualStyleBackColor = true;
            this.ProblemChangeButton.Click += new System.EventHandler(this.ProblemChangeButton_Click_1);
            // 
            // DelProblemButton
            // 
            this.DelProblemButton.Location = new System.Drawing.Point(19, 107);
            this.DelProblemButton.Name = "DelProblemButton";
            this.DelProblemButton.Size = new System.Drawing.Size(128, 21);
            this.DelProblemButton.TabIndex = 17;
            this.DelProblemButton.Text = "Удалить";
            this.DelProblemButton.UseVisualStyleBackColor = true;
            this.DelProblemButton.Click += new System.EventHandler(this.DelProblemButton_Click);
            // 
            // SolotionsList
            // 
            this.SolotionsList.FormattingEnabled = true;
            this.SolotionsList.Location = new System.Drawing.Point(12, 233);
            this.SolotionsList.Name = "SolotionsList";
            this.SolotionsList.Size = new System.Drawing.Size(698, 212);
            this.SolotionsList.TabIndex = 18;
            // 
            // AddSolutionButton
            // 
            this.AddSolutionButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddSolutionButton.Location = new System.Drawing.Point(19, 270);
            this.AddSolutionButton.Name = "AddSolutionButton";
            this.AddSolutionButton.Size = new System.Drawing.Size(128, 22);
            this.AddSolutionButton.TabIndex = 19;
            this.AddSolutionButton.Text = "Добавить решение";
            this.AddSolutionButton.UseVisualStyleBackColor = false;
            this.AddSolutionButton.Click += new System.EventHandler(this.AddSolutionButton_Click);
            // 
            // EditSolutionButton
            // 
            this.EditSolutionButton.Location = new System.Drawing.Point(19, 298);
            this.EditSolutionButton.Name = "EditSolutionButton";
            this.EditSolutionButton.Size = new System.Drawing.Size(128, 21);
            this.EditSolutionButton.TabIndex = 20;
            this.EditSolutionButton.Text = "Редактировать";
            this.EditSolutionButton.UseVisualStyleBackColor = true;
            this.EditSolutionButton.Click += new System.EventHandler(this.EditSolutionButton_Click);
            // 
            // DelSolutionButton
            // 
            this.DelSolutionButton.Location = new System.Drawing.Point(18, 325);
            this.DelSolutionButton.Name = "DelSolutionButton";
            this.DelSolutionButton.Size = new System.Drawing.Size(128, 21);
            this.DelSolutionButton.TabIndex = 21;
            this.DelSolutionButton.Text = "Удалить";
            this.DelSolutionButton.UseVisualStyleBackColor = true;
            this.DelSolutionButton.Click += new System.EventHandler(this.DelSolutionButton_Click);
            // 
            // SolutionFormulationLabel
            // 
            this.SolutionFormulationLabel.BackColor = System.Drawing.Color.White;
            this.SolutionFormulationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionFormulationLabel.Location = new System.Drawing.Point(292, 274);
            this.SolutionFormulationLabel.Name = "SolutionFormulationLabel";
            this.SolutionFormulationLabel.Size = new System.Drawing.Size(410, 157);
            this.SolutionFormulationLabel.TabIndex = 22;
            // 
            // SolutionsListLabel
            // 
            this.SolutionsListLabel.AutoSize = true;
            this.SolutionsListLabel.BackColor = System.Drawing.Color.White;
            this.SolutionsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolutionsListLabel.Location = new System.Drawing.Point(16, 237);
            this.SolutionsListLabel.Name = "SolutionsListLabel";
            this.SolutionsListLabel.Size = new System.Drawing.Size(127, 18);
            this.SolutionsListLabel.TabIndex = 23;
            this.SolutionsListLabel.Text = "Список решений:";
            // 
            // SolutionsComboBox
            // 
            this.SolutionsComboBox.FormattingEnabled = true;
            this.SolutionsComboBox.Location = new System.Drawing.Point(148, 237);
            this.SolutionsComboBox.Name = "SolutionsComboBox";
            this.SolutionsComboBox.Size = new System.Drawing.Size(138, 21);
            this.SolutionsComboBox.TabIndex = 24;
            // 
            // SolutionFormulationLabelHead
            // 
            this.SolutionFormulationLabelHead.AutoSize = true;
            this.SolutionFormulationLabelHead.BackColor = System.Drawing.Color.White;
            this.SolutionFormulationLabelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolutionFormulationLabelHead.Location = new System.Drawing.Point(295, 240);
            this.SolutionFormulationLabelHead.Name = "SolutionFormulationLabelHead";
            this.SolutionFormulationLabelHead.Size = new System.Drawing.Size(181, 18);
            this.SolutionFormulationLabelHead.TabIndex = 25;
            this.SolutionFormulationLabelHead.Text = "Формулировка решения:";
            // 
            // ExpertsListBox
            // 
            this.ExpertsListBox.FormattingEnabled = true;
            this.ExpertsListBox.Location = new System.Drawing.Point(716, 15);
            this.ExpertsListBox.Name = "ExpertsListBox";
            this.ExpertsListBox.Size = new System.Drawing.Size(698, 212);
            this.ExpertsListBox.TabIndex = 26;
            // 
            // ExpertComboBox
            // 
            this.ExpertComboBox.FormattingEnabled = true;
            this.ExpertComboBox.Location = new System.Drawing.Point(858, 19);
            this.ExpertComboBox.Name = "ExpertComboBox";
            this.ExpertComboBox.Size = new System.Drawing.Size(138, 21);
            this.ExpertComboBox.TabIndex = 27;
            // 
            // ExpertListLabel
            // 
            this.ExpertListLabel.AutoSize = true;
            this.ExpertListLabel.BackColor = System.Drawing.Color.White;
            this.ExpertListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpertListLabel.Location = new System.Drawing.Point(718, 19);
            this.ExpertListLabel.Name = "ExpertListLabel";
            this.ExpertListLabel.Size = new System.Drawing.Size(140, 18);
            this.ExpertListLabel.TabIndex = 28;
            this.ExpertListLabel.Text = "Список экспертов:";
            // 
            // ExpertAddButton
            // 
            this.ExpertAddButton.BackColor = System.Drawing.SystemColors.Control;
            this.ExpertAddButton.Location = new System.Drawing.Point(722, 52);
            this.ExpertAddButton.Name = "ExpertAddButton";
            this.ExpertAddButton.Size = new System.Drawing.Size(128, 22);
            this.ExpertAddButton.TabIndex = 29;
            this.ExpertAddButton.Text = "Добавить эксперта";
            this.ExpertAddButton.UseVisualStyleBackColor = false;
            this.ExpertAddButton.Click += new System.EventHandler(this.ExpertAddButton_Click);
            // 
            // ExpertEditButton
            // 
            this.ExpertEditButton.Location = new System.Drawing.Point(722, 80);
            this.ExpertEditButton.Name = "ExpertEditButton";
            this.ExpertEditButton.Size = new System.Drawing.Size(128, 21);
            this.ExpertEditButton.TabIndex = 30;
            this.ExpertEditButton.Text = "Изменить";
            this.ExpertEditButton.UseVisualStyleBackColor = true;
            this.ExpertEditButton.Click += new System.EventHandler(this.ExpertEditButton_Click);
            // 
            // ExpertDelButton
            // 
            this.ExpertDelButton.Location = new System.Drawing.Point(721, 107);
            this.ExpertDelButton.Name = "ExpertDelButton";
            this.ExpertDelButton.Size = new System.Drawing.Size(128, 21);
            this.ExpertDelButton.TabIndex = 31;
            this.ExpertDelButton.Text = "Удалить";
            this.ExpertDelButton.UseVisualStyleBackColor = true;
            this.ExpertDelButton.Click += new System.EventHandler(this.ExpertDelButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(716, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 48);
            this.button4.TabIndex = 32;
            this.button4.Text = "Информация об оценивании";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ExpertDiscriptionLabel
            // 
            this.ExpertDiscriptionLabel.BackColor = System.Drawing.Color.White;
            this.ExpertDiscriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpertDiscriptionLabel.Location = new System.Drawing.Point(996, 52);
            this.ExpertDiscriptionLabel.Name = "ExpertDiscriptionLabel";
            this.ExpertDiscriptionLabel.Size = new System.Drawing.Size(410, 157);
            this.ExpertDiscriptionLabel.TabIndex = 34;
            // 
            // ExpertLabelHead
            // 
            this.ExpertLabelHead.AutoSize = true;
            this.ExpertLabelHead.BackColor = System.Drawing.Color.White;
            this.ExpertLabelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpertLabelHead.Location = new System.Drawing.Point(1004, 22);
            this.ExpertLabelHead.Name = "ExpertLabelHead";
            this.ExpertLabelHead.Size = new System.Drawing.Size(187, 18);
            this.ExpertLabelHead.TabIndex = 35;
            this.ExpertLabelHead.Text = "Характеристики эксперта";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(716, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 48);
            this.button5.TabIndex = 36;
            this.button5.Text = "Результаты оценивания";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(716, 341);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 48);
            this.button6.TabIndex = 37;
            this.button6.Text = "Оценки";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(716, 395);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(219, 48);
            this.button7.TabIndex = 38;
            this.button7.Text = "Сохранить в файл";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1195, 395);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(219, 48);
            this.ExitButton.TabIndex = 39;
            this.ExitButton.Text = "Выйти в меню";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AnalystInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 462);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ExpertLabelHead);
            this.Controls.Add(this.ExpertDiscriptionLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ExpertDelButton);
            this.Controls.Add(this.ExpertEditButton);
            this.Controls.Add(this.ExpertAddButton);
            this.Controls.Add(this.ExpertListLabel);
            this.Controls.Add(this.ExpertComboBox);
            this.Controls.Add(this.ExpertsListBox);
            this.Controls.Add(this.SolutionFormulationLabelHead);
            this.Controls.Add(this.SolutionsComboBox);
            this.Controls.Add(this.SolutionsListLabel);
            this.Controls.Add(this.SolutionFormulationLabel);
            this.Controls.Add(this.DelSolutionButton);
            this.Controls.Add(this.EditSolutionButton);
            this.Controls.Add(this.AddSolutionButton);
            this.Controls.Add(this.SolotionsList);
            this.Controls.Add(this.DelProblemButton);
            this.Controls.Add(this.ProblemChangeButton);
            this.Controls.Add(this.CurrentProblemFormulation);
            this.Controls.Add(this.FormuletionProblemLabel);
            this.Controls.Add(this.ProblemsListLable);
            this.Controls.Add(this.ProblemsComboBox);
            this.Controls.Add(this.AddProblemButton);
            this.Controls.Add(this.Problems);
            this.Name = "AnalystInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интерфейс аналитика:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Problems;
        private System.Windows.Forms.Button AddProblemButton;
        private System.Windows.Forms.ComboBox ProblemsComboBox;
        private System.Windows.Forms.Label ProblemsListLable;
        private System.Windows.Forms.Label FormuletionProblemLabel;
        private System.Windows.Forms.Label CurrentProblemFormulation;
        private System.Windows.Forms.Button ProblemChangeButton;
        private System.Windows.Forms.Button DelProblemButton;
        private System.Windows.Forms.ListBox SolotionsList;
        private System.Windows.Forms.Button AddSolutionButton;
        private System.Windows.Forms.Button EditSolutionButton;
        private System.Windows.Forms.Button DelSolutionButton;
        private System.Windows.Forms.Label SolutionFormulationLabel;
        private System.Windows.Forms.Label SolutionsListLabel;
        private System.Windows.Forms.ComboBox SolutionsComboBox;
        private System.Windows.Forms.Label SolutionFormulationLabelHead;
        private System.Windows.Forms.ListBox ExpertsListBox;
        private System.Windows.Forms.ComboBox ExpertComboBox;
        private System.Windows.Forms.Label ExpertListLabel;
        private System.Windows.Forms.Button ExpertAddButton;
        private System.Windows.Forms.Button ExpertEditButton;
        private System.Windows.Forms.Button ExpertDelButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label ExpertDiscriptionLabel;
        private System.Windows.Forms.Label ExpertLabelHead;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button ExitButton;
    }
}