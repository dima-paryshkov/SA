namespace Системный_анализ
{
    partial class AddProblem
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
            this.components = new System.ComponentModel.Container();
            this.ProblemFormulationTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ProblemNameTextBox = new System.Windows.Forms.TextBox();
            this.ProblemNameLabel = new System.Windows.Forms.Label();
            this.ProblemFormulationLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProblemFormulationTextBox
            // 
            this.ProblemFormulationTextBox.Location = new System.Drawing.Point(12, 90);
            this.ProblemFormulationTextBox.Multiline = true;
            this.ProblemFormulationTextBox.Name = "ProblemFormulationTextBox";
            this.ProblemFormulationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ProblemFormulationTextBox.Size = new System.Drawing.Size(297, 171);
            this.ProblemFormulationTextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ProblemNameTextBox
            // 
            this.ProblemNameTextBox.Location = new System.Drawing.Point(12, 34);
            this.ProblemNameTextBox.Name = "ProblemNameTextBox";
            this.ProblemNameTextBox.Size = new System.Drawing.Size(297, 20);
            this.ProblemNameTextBox.TabIndex = 2;
            // 
            // ProblemNameLabel
            // 
            this.ProblemNameLabel.AutoSize = true;
            this.ProblemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProblemNameLabel.Location = new System.Drawing.Point(12, 13);
            this.ProblemNameLabel.Name = "ProblemNameLabel";
            this.ProblemNameLabel.Size = new System.Drawing.Size(152, 18);
            this.ProblemNameLabel.TabIndex = 3;
            this.ProblemNameLabel.Text = "Название проблемы";
            // 
            // ProblemFormulationLabel
            // 
            this.ProblemFormulationLabel.AutoSize = true;
            this.ProblemFormulationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProblemFormulationLabel.Location = new System.Drawing.Point(12, 69);
            this.ProblemFormulationLabel.Name = "ProblemFormulationLabel";
            this.ProblemFormulationLabel.Size = new System.Drawing.Size(191, 18);
            this.ProblemFormulationLabel.TabIndex = 4;
            this.ProblemFormulationLabel.Text = "Формулировка проблемы";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 336);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(73, 24);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(107, 280);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 30);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 373);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ProblemFormulationLabel);
            this.Controls.Add(this.ProblemNameLabel);
            this.Controls.Add(this.ProblemNameTextBox);
            this.Controls.Add(this.ProblemFormulationTextBox);
            this.Name = "AddProblem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление проблемы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProblemFormulationTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ProblemNameTextBox;
        private System.Windows.Forms.Label ProblemNameLabel;
        private System.Windows.Forms.Label ProblemFormulationLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
    }
}