using PGO.Iterface.StartFrm;

namespace PGO.Forms
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.startPageButton1 = new PGO.Iterface.StartFrm.StartPageButton();
            this.startPageButton2 = new PGO.Iterface.StartFrm.StartPageButton();
            this.startPageButton3 = new PGO.Iterface.StartFrm.StartPageButton();
            this.startPageButton4 = new PGO.Iterface.StartFrm.StartPageButton();
            this.startPageButton5 = new PGO.Iterface.StartFrm.StartPageButton();
            this.startPageButton6 = new PGO.Iterface.StartFrm.StartPageButton();
            this.startPageButton7 = new PGO.Iterface.StartFrm.StartPageButton();
            this.startPageButton8 = new PGO.Iterface.StartFrm.StartPageButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.startPageButton1);
            this.flowLayoutPanel1.Controls.Add(this.startPageButton2);
            this.flowLayoutPanel1.Controls.Add(this.startPageButton3);
            this.flowLayoutPanel1.Controls.Add(this.startPageButton4);
            this.flowLayoutPanel1.Controls.Add(this.startPageButton5);
            this.flowLayoutPanel1.Controls.Add(this.startPageButton6);
            this.flowLayoutPanel1.Controls.Add(this.startPageButton7);
            this.flowLayoutPanel1.Controls.Add(this.startPageButton8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(491, 402);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(491, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(50);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(173, 402);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "ferrary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "swennn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "spec.png");
            this.imageList1.Images.SetKeyName(1, "House.png");
            this.imageList1.Images.SetKeyName(2, "direct.png");
            this.imageList1.Images.SetKeyName(3, "report.png");
            this.imageList1.Images.SetKeyName(4, "Settings-icon.png");
            this.imageList1.Images.SetKeyName(5, "people.png");
            // 
            // startPageButton1
            // 
            this.startPageButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startPageButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startPageButton1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPageButton1.Images = ((System.Drawing.Image)(resources.GetObject("startPageButton1.Images")));
            this.startPageButton1.Location = new System.Drawing.Point(3, 3);
            this.startPageButton1.Name = "startPageButton1";
            this.startPageButton1.Size = new System.Drawing.Size(112, 128);
            this.startPageButton1.Str = "Фізичні особи";
            this.startPageButton1.TabIndex = 0;
            this.startPageButton1.CClick += new PGO.Iterface.StartFrm.StartPageButton.ItemClick(this.startPageButton1_CClick);
            // 
            // startPageButton2
            // 
            this.startPageButton2.BackColor = System.Drawing.Color.White;
            this.startPageButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startPageButton2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPageButton2.Images = ((System.Drawing.Image)(resources.GetObject("startPageButton2.Images")));
            this.startPageButton2.Location = new System.Drawing.Point(121, 3);
            this.startPageButton2.Name = "startPageButton2";
            this.startPageButton2.Size = new System.Drawing.Size(112, 128);
            this.startPageButton2.Str = "Об\'єкти ПГО";
            this.startPageButton2.TabIndex = 1;
            this.startPageButton2.CClick += new PGO.Iterface.StartFrm.StartPageButton.ItemClick(this.startPageButton2_CClick);
            // 
            // startPageButton3
            // 
            this.startPageButton3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startPageButton3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startPageButton3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPageButton3.Images = ((System.Drawing.Image)(resources.GetObject("startPageButton3.Images")));
            this.startPageButton3.Location = new System.Drawing.Point(239, 3);
            this.startPageButton3.Name = "startPageButton3";
            this.startPageButton3.Size = new System.Drawing.Size(112, 128);
            this.startPageButton3.Str = "Будинки";
            this.startPageButton3.TabIndex = 2;
            this.startPageButton3.CClick += new PGO.Iterface.StartFrm.StartPageButton.ItemClick(this.startPageButton3_CClick);
            // 
            // startPageButton4
            // 
            this.startPageButton4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startPageButton4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startPageButton4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPageButton4.Images = ((System.Drawing.Image)(resources.GetObject("startPageButton4.Images")));
            this.startPageButton4.Location = new System.Drawing.Point(357, 3);
            this.startPageButton4.Name = "startPageButton4";
            this.startPageButton4.Size = new System.Drawing.Size(112, 128);
            this.startPageButton4.Str = "Землі";
            this.startPageButton4.TabIndex = 3;
            this.startPageButton4.CClick += new PGO.Iterface.StartFrm.StartPageButton.ItemClick(this.startPageButton4_CClick);
            // 
            // startPageButton5
            // 
            this.startPageButton5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startPageButton5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startPageButton5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPageButton5.Images = ((System.Drawing.Image)(resources.GetObject("startPageButton5.Images")));
            this.startPageButton5.Location = new System.Drawing.Point(3, 137);
            this.startPageButton5.Name = "startPageButton5";
            this.startPageButton5.Size = new System.Drawing.Size(112, 128);
            this.startPageButton5.Str = "Установи";
            this.startPageButton5.TabIndex = 5;
            // 
            // startPageButton6
            // 
            this.startPageButton6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startPageButton6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startPageButton6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPageButton6.Images = ((System.Drawing.Image)(resources.GetObject("startPageButton6.Images")));
            this.startPageButton6.Location = new System.Drawing.Point(121, 137);
            this.startPageButton6.Name = "startPageButton6";
            this.startPageButton6.Size = new System.Drawing.Size(112, 128);
            this.startPageButton6.Str = "Довідники";
            this.startPageButton6.TabIndex = 6;
            // 
            // startPageButton7
            // 
            this.startPageButton7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startPageButton7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startPageButton7.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPageButton7.Images = ((System.Drawing.Image)(resources.GetObject("startPageButton7.Images")));
            this.startPageButton7.Location = new System.Drawing.Point(239, 137);
            this.startPageButton7.Name = "startPageButton7";
            this.startPageButton7.Size = new System.Drawing.Size(112, 128);
            this.startPageButton7.Str = "Звіти";
            this.startPageButton7.TabIndex = 7;
            // 
            // startPageButton8
            // 
            this.startPageButton8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startPageButton8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startPageButton8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPageButton8.Images = global::PGO.Properties.Resources.Box;
            this.startPageButton8.Location = new System.Drawing.Point(357, 137);
            this.startPageButton8.Name = "startPageButton8";
            this.startPageButton8.Size = new System.Drawing.Size(112, 128);
            this.startPageButton8.Str = "Налаштування";
            this.startPageButton8.TabIndex = 8;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 402);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(680, 440);
            this.Name = "StartForm";
            this.Text = "Погосподарський облік";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private StartPageButton startPageButton1;
        private StartPageButton startPageButton2;
        private StartPageButton startPageButton3;
        private StartPageButton startPageButton4;
        private StartPageButton startPageButton5;
        private StartPageButton startPageButton6;
        private StartPageButton startPageButton7;
        private StartPageButton startPageButton8;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        //
        //
    }
}