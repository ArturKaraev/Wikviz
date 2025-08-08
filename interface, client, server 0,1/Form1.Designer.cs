namespace @interface
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
       

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextAdress = new System.Windows.Forms.TextBox();
            this.LabelAdress = new System.Windows.Forms.Label();
            this.LabelPort = new System.Windows.Forms.Label();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextAnswer = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.LabelResult = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelQuest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextAdress
            // 
            this.TextAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAdress.Location = new System.Drawing.Point(25, 74);
            this.TextAdress.Margin = new System.Windows.Forms.Padding(4);
            this.TextAdress.Name = "TextAdress";
            this.TextAdress.Size = new System.Drawing.Size(421, 55);
            this.TextAdress.TabIndex = 0;
            this.TextAdress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelAdress
            // 
            this.LabelAdress.AutoSize = true;
            this.LabelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAdress.Location = new System.Drawing.Point(16, 22);
            this.LabelAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAdress.Name = "LabelAdress";
            this.LabelAdress.Size = new System.Drawing.Size(745, 51);
            this.LabelAdress.TabIndex = 1;
            this.LabelAdress.Text = "требуется ввести IP-adress сервера";
            this.LabelAdress.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPort.Location = new System.Drawing.Point(16, 219);
            this.LabelPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(757, 51);
            this.LabelPort.TabIndex = 2;
            this.LabelPort.Text = "требуется ввести порт подключения";
            this.LabelPort.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextPort
            // 
            this.TextPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextPort.Location = new System.Drawing.Point(25, 271);
            this.TextPort.Margin = new System.Windows.Forms.Padding(4);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(421, 55);
            this.TextPort.TabIndex = 3;
            this.TextPort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.Location = new System.Drawing.Point(767, 442);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(284, 97);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "отправить";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextAnswer
            // 
            this.TextAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAnswer.Location = new System.Drawing.Point(100, 155);
            this.TextAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.TextAnswer.Name = "TextAnswer";
            this.TextAnswer.Size = new System.Drawing.Size(768, 55);
            this.TextAnswer.TabIndex = 6;
            this.TextAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextAnswer.Visible = false;
            this.TextAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button2.Location = new System.Drawing.Point(367, 390);
            this.Button2.Margin = new System.Windows.Forms.Padding(4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(284, 97);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "отправить";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Visible = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelResult.Location = new System.Drawing.Point(26, 22);
            this.LabelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(242, 51);
            this.LabelResult.TabIndex = 8;
            this.LabelResult.Text = "Результат:";
            this.LabelResult.Visible = false;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.ForeColor = System.Drawing.Color.DarkGreen;
            this.Label.Location = new System.Drawing.Point(302, 291);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(398, 95);
            this.Label.TabIndex = 9;
            this.Label.Text = "ПОБЕДА";
            this.Label.Visible = false;
            this.Label.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(317, 331);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 95);
            this.label3.TabIndex = 11;
            this.label3.Visible = false;
            // 
            // LabelQuest
            // 
            this.LabelQuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelQuest.Location = new System.Drawing.Point(0, 0);
            this.LabelQuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQuest.Name = "LabelQuest";
            this.LabelQuest.Size = new System.Drawing.Size(1039, 547);
            this.LabelQuest.TabIndex = 5;
            this.LabelQuest.Text = "1 вопрос";
            this.LabelQuest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelQuest.Visible = false;
            this.LabelQuest.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.TextAnswer);
            this.Controls.Add(this.LabelQuest);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextPort);
            this.Controls.Add(this.LabelPort);
            this.Controls.Add(this.LabelAdress);
            this.Controls.Add(this.TextAdress);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Wilviz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextAdress;
        private System.Windows.Forms.Label LabelAdress;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.TextBox TextPort;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox TextAnswer;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelQuest;
    }
}

