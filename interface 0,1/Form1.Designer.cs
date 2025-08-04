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
            this.TextAdress = new System.Windows.Forms.TextBox();
            this.LabelAdress = new System.Windows.Forms.Label();
            this.LabelPort = new System.Windows.Forms.Label();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.LabelQuest = new System.Windows.Forms.Label();
            this.TextAnswer = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextAdress
            // 
            this.TextAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAdress.Location = new System.Drawing.Point(19, 60);
            this.TextAdress.Name = "TextAdress";
            this.TextAdress.Size = new System.Drawing.Size(317, 46);
            this.TextAdress.TabIndex = 0;
            this.TextAdress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelAdress
            // 
            this.LabelAdress.AutoSize = true;
            this.LabelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAdress.Location = new System.Drawing.Point(12, 18);
            this.LabelAdress.Name = "LabelAdress";
            this.LabelAdress.Size = new System.Drawing.Size(587, 39);
            this.LabelAdress.TabIndex = 1;
            this.LabelAdress.Text = "требуется ввести IP-adress сервера";
            this.LabelAdress.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPort.Location = new System.Drawing.Point(12, 178);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(596, 39);
            this.LabelPort.TabIndex = 2;
            this.LabelPort.Text = "требуется ввести порт подключения";
            this.LabelPort.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextPort
            // 
            this.TextPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextPort.Location = new System.Drawing.Point(19, 220);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(317, 46);
            this.TextPort.TabIndex = 3;
            this.TextPort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.Location = new System.Drawing.Point(575, 359);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(213, 79);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "отправить";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelQuest
            // 
            this.LabelQuest.AutoSize = true;
            this.LabelQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelQuest.Location = new System.Drawing.Point(205, 18);
            this.LabelQuest.Name = "LabelQuest";
            this.LabelQuest.Size = new System.Drawing.Size(379, 39);
            this.LabelQuest.TabIndex = 5;
            this.LabelQuest.Text = "Что выведет этот код?";
            this.LabelQuest.Visible = false;
            this.LabelQuest.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TextAnswer
            // 
            this.TextAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAnswer.Location = new System.Drawing.Point(116, 220);
            this.TextAnswer.Name = "TextAnswer";
            this.TextAnswer.Size = new System.Drawing.Size(577, 46);
            this.TextAnswer.TabIndex = 6;
            this.TextAnswer.Visible = false;
            this.TextAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button2.Location = new System.Drawing.Point(277, 331);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(213, 79);
            this.Button2.TabIndex = 7;
            this.Button2.Text = "отправить";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Visible = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.TextAnswer);
            this.Controls.Add(this.LabelQuest);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextPort);
            this.Controls.Add(this.LabelPort);
            this.Controls.Add(this.LabelAdress);
            this.Controls.Add(this.TextAdress);
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
        private System.Windows.Forms.Label LabelQuest;
        private System.Windows.Forms.TextBox TextAnswer;
        private System.Windows.Forms.Button Button2;
    }
}

