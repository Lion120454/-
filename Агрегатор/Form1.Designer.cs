
namespace Агрегатор
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
            this.GetButton = new System.Windows.Forms.Button();
            this.labelAvitoCount = new System.Windows.Forms.Label();
            this.textBoxStamp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGeneration = new System.Windows.Forms.TextBox();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAvitoPriceMin = new System.Windows.Forms.Label();
            this.labelAvitoPriceMax = new System.Windows.Forms.Label();
            this.textBoxVin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetButton.Location = new System.Drawing.Point(777, 109);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(197, 31);
            this.GetButton.TabIndex = 0;
            this.GetButton.Text = "Найти";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // labelAvitoCount
            // 
            this.labelAvitoCount.AutoSize = true;
            this.labelAvitoCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAvitoCount.Location = new System.Drawing.Point(95, 251);
            this.labelAvitoCount.Name = "labelAvitoCount";
            this.labelAvitoCount.Size = new System.Drawing.Size(0, 26);
            this.labelAvitoCount.TabIndex = 1;
            // 
            // textBoxStamp
            // 
            this.textBoxStamp.Location = new System.Drawing.Point(12, 67);
            this.textBoxStamp.Name = "textBoxStamp";
            this.textBoxStamp.Size = new System.Drawing.Size(149, 20);
            this.textBoxStamp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(218, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Модель";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(180, 67);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(134, 20);
            this.textBoxModel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(372, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Поколение";
            // 
            // textBoxGeneration
            // 
            this.textBoxGeneration.Location = new System.Drawing.Point(347, 67);
            this.textBoxGeneration.Name = "textBoxGeneration";
            this.textBoxGeneration.Size = new System.Drawing.Size(143, 20);
            this.textBoxGeneration.TabIndex = 7;
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Location = new System.Drawing.Point(545, 67);
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.Size = new System.Drawing.Size(429, 20);
            this.textBoxRequest.TabIndex = 8;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(791, 23);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(183, 20);
            this.textBoxCity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(720, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Город";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(103, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Авито";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Кол-во";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Цена";
            // 
            // labelAvitoPriceMin
            // 
            this.labelAvitoPriceMin.AutoSize = true;
            this.labelAvitoPriceMin.Location = new System.Drawing.Point(98, 326);
            this.labelAvitoPriceMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAvitoPriceMin.Name = "labelAvitoPriceMin";
            this.labelAvitoPriceMin.Size = new System.Drawing.Size(0, 13);
            this.labelAvitoPriceMin.TabIndex = 14;
            // 
            // labelAvitoPriceMax
            // 
            this.labelAvitoPriceMax.AutoSize = true;
            this.labelAvitoPriceMax.Location = new System.Drawing.Point(296, 320);
            this.labelAvitoPriceMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAvitoPriceMax.Name = "labelAvitoPriceMax";
            this.labelAvitoPriceMax.Size = new System.Drawing.Size(0, 13);
            this.labelAvitoPriceMax.TabIndex = 15;
            // 
            // textBoxVin
            // 
            this.textBoxVin.Location = new System.Drawing.Point(61, 120);
            this.textBoxVin.Name = "textBoxVin";
            this.textBoxVin.Size = new System.Drawing.Size(207, 20);
            this.textBoxVin.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "VIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 562);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxVin);
            this.Controls.Add(this.labelAvitoPriceMax);
            this.Controls.Add(this.labelAvitoPriceMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxRequest);
            this.Controls.Add(this.textBoxGeneration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStamp);
            this.Controls.Add(this.labelAvitoCount);
            this.Controls.Add(this.GetButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Label labelAvitoCount;
        private System.Windows.Forms.TextBox textBoxStamp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGeneration;
        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAvitoPriceMin;
        private System.Windows.Forms.Label labelAvitoPriceMax;
        private System.Windows.Forms.TextBox textBoxVin;
        private System.Windows.Forms.Label label8;
    }
}

