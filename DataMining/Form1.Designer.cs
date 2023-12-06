namespace DataMining
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPredict = new System.Windows.Forms.Button();
            this.buttonShowAllInputData = new System.Windows.Forms.Button();
            this.countPredictedDaysTextBox = new System.Windows.Forms.TextBox();
            this.countPredictedDaysLabel = new System.Windows.Forms.Label();
            this.percentFromInputDataTextBox = new System.Windows.Forms.TextBox();
            this.percentFromInputDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPredict
            // 
            this.buttonPredict.Location = new System.Drawing.Point(343, 135);
            this.buttonPredict.Name = "buttonPredict";
            this.buttonPredict.Size = new System.Drawing.Size(162, 49);
            this.buttonPredict.TabIndex = 0;
            this.buttonPredict.Text = "Спрогнозировать";
            this.buttonPredict.UseVisualStyleBackColor = true;
            this.buttonPredict.Click += new System.EventHandler(this.buttonPredict_Click);
            // 
            // buttonShowAllInputData
            // 
            this.buttonShowAllInputData.Location = new System.Drawing.Point(55, 135);
            this.buttonShowAllInputData.Name = "buttonShowAllInputData";
            this.buttonShowAllInputData.Size = new System.Drawing.Size(162, 49);
            this.buttonShowAllInputData.TabIndex = 1;
            this.buttonShowAllInputData.Text = "Вывести исходные данные";
            this.buttonShowAllInputData.UseVisualStyleBackColor = true;
            this.buttonShowAllInputData.Click += new System.EventHandler(this.buttonShowAllInputData_Click);
            // 
            // countPredictedDaysTextBox
            // 
            this.countPredictedDaysTextBox.Location = new System.Drawing.Point(375, 86);
            this.countPredictedDaysTextBox.Name = "countPredictedDaysTextBox";
            this.countPredictedDaysTextBox.Size = new System.Drawing.Size(100, 22);
            this.countPredictedDaysTextBox.TabIndex = 2;
            this.countPredictedDaysTextBox.Text = "500";
            // 
            // countPredictedDaysLabel
            // 
            this.countPredictedDaysLabel.AutoSize = true;
            this.countPredictedDaysLabel.Location = new System.Drawing.Point(320, 43);
            this.countPredictedDaysLabel.Name = "countPredictedDaysLabel";
            this.countPredictedDaysLabel.Size = new System.Drawing.Size(233, 16);
            this.countPredictedDaysLabel.TabIndex = 3;
            this.countPredictedDaysLabel.Text = "Количество прогнозируемых дней";
            // 
            // textBox1
            // 
            this.percentFromInputDataTextBox.Location = new System.Drawing.Point(84, 86);
            this.percentFromInputDataTextBox.Name = "percentFromInputDataTextBox";
            this.percentFromInputDataTextBox.Size = new System.Drawing.Size(100, 22);
            this.percentFromInputDataTextBox.TabIndex = 4;
            this.percentFromInputDataTextBox.Text = "100";
            // 
            // label1
            // 
            this.percentFromInputDataLabel.AutoSize = true;
            this.percentFromInputDataLabel.Location = new System.Drawing.Point(33, 43);
            this.percentFromInputDataLabel.Name = "percentFromInputDataLabel";
            this.percentFromInputDataLabel.Size = new System.Drawing.Size(226, 16);
            this.percentFromInputDataLabel.TabIndex = 5;
            this.percentFromInputDataLabel.Text = "Процент от начального датасета";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 249);
            this.Controls.Add(this.percentFromInputDataLabel);
            this.Controls.Add(this.percentFromInputDataTextBox);
            this.Controls.Add(this.countPredictedDaysLabel);
            this.Controls.Add(this.countPredictedDaysTextBox);
            this.Controls.Add(this.buttonShowAllInputData);
            this.Controls.Add(this.buttonPredict);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPredict;
        private System.Windows.Forms.Button buttonShowAllInputData;
        private System.Windows.Forms.TextBox countPredictedDaysTextBox;
        private System.Windows.Forms.Label countPredictedDaysLabel;
        private System.Windows.Forms.TextBox percentFromInputDataTextBox;
        private System.Windows.Forms.Label percentFromInputDataLabel;
    }
}

