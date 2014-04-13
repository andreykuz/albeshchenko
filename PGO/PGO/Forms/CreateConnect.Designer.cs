namespace PGO.Forms
{
    partial class CreateConnect
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Встановлення підключення до серверу з базою даних";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(36, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.Tag = "Укажіть ім\'я серверу";
            this.textBox1.Text = "Укажіть ім\'я серверу";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox1, "Укажіть ім\'я серверу до якого треба підключитися");
            this.textBox1.Click += new System.EventHandler(this.fName_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.fName_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.fName_Leave);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Silver;
            this.textBox2.Location = new System.Drawing.Point(36, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(443, 30);
            this.textBox2.TabIndex = 2;
            this.textBox2.Tag = "Укажіть ім\'я користувача сервером";
            this.textBox2.Text = "Укажіть ім\'я користувача сервером";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox2, "Ім\'я користувача сервером");
            this.textBox2.Click += new System.EventHandler(this.fName_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.fName_TextChanged);
            this.textBox2.Leave += new System.EventHandler(this.fName_Leave);
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.Silver;
            this.textBox3.Location = new System.Drawing.Point(36, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(443, 30);
            this.textBox3.TabIndex = 3;
            this.textBox3.Tag = "Укажіть пароль користувача";
            this.textBox3.Text = "Укажіть пароль користувача";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox3, "Власний пароль користувача");
            this.textBox3.Click += new System.EventHandler(this.fName_Click);
            this.textBox3.TextChanged += new System.EventHandler(this.fName_TextChanged);
            this.textBox3.Leave += new System.EventHandler(this.fName_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 81);
            this.label2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Підключення";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Вихід";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateConnect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}