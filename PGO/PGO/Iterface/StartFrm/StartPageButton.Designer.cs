using System.Windows.Forms;

namespace PGO.Iterface.StartFrm
{
    partial class StartPageButton : Panel
    {
        private void InitializeComponent()
        {
            this.l = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            this.SuspendLayout();
            // 
            // l
            // 
            this.l.BackColor = System.Drawing.Color.Transparent;
            this.l.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.l.ForeColor = System.Drawing.Color.Black;
            this.l.Location = new System.Drawing.Point(0, 81);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(72, 45);
            this.l.TabIndex = 0;
            this.l.Text = "label1";
            this.l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l.Click += new System.EventHandler(this.item_Click);
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.Transparent;
            this.p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p.Image = global::PGO.Properties.Resources.Box;
            this.p.Location = new System.Drawing.Point(0, 0);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(72, 81);
            this.p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.p.TabIndex = 0;
            this.p.TabStop = false;
            this.p.Click += new System.EventHandler(this.item_Click);
            // 
            // StartPageButton
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.p);
            this.Controls.Add(this.l);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Size = new System.Drawing.Size(74, 128);
            this.Click += new System.EventHandler(this.ControlCLick);
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            this.ResumeLayout(false);
        }

        private Label l;
        private PictureBox p;
    }
}
