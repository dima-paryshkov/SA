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
            this.BackButton = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DataGridView();
            this.ExpertList = new System.Windows.Forms.Button();
            this.ExpertListBack = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 427);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Data
            // 
            this.Data.BackgroundColor = System.Drawing.Color.White;
            this.Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(12, 12);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(773, 409);
            this.Data.TabIndex = 2;
            // 
            // ExpertList
            // 
            this.ExpertList.Location = new System.Drawing.Point(625, 427);
            this.ExpertList.Name = "ExpertList";
            this.ExpertList.Size = new System.Drawing.Size(154, 23);
            this.ExpertList.TabIndex = 3;
            this.ExpertList.Text = "Список экспертов";
            this.ExpertList.UseVisualStyleBackColor = true;
            this.ExpertList.Click += new System.EventHandler(this.ExpertList_Click);
            // 
            // ExpertListBack
            // 
            this.ExpertListBack.Location = new System.Drawing.Point(307, 427);
            this.ExpertListBack.Name = "ExpertListBack";
            this.ExpertListBack.Size = new System.Drawing.Size(171, 23);
            this.ExpertListBack.TabIndex = 4;
            this.ExpertListBack.Text = "Назад к списку проблем";
            this.ExpertListBack.UseVisualStyleBackColor = true;
            this.ExpertListBack.Visible = false;
            this.ExpertListBack.Click += new System.EventHandler(this.ExpertListBack_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(773, 409);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.Visible = false;
            // 
            // AnalystInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 462);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ExpertListBack);
            this.Controls.Add(this.ExpertList);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.BackButton);
            this.Name = "AnalystInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интерфейс аналитика:";
            this.Load += new System.EventHandler(this.AnalystInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.Button ExpertList;
        private System.Windows.Forms.Button ExpertListBack;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}