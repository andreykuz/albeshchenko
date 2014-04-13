using System.Drawing;

namespace PGO.Iterface.StartFrm
{
    partial class StartPageButton
    {
        public delegate void ItemClick(object sender, System.EventArgs e);
        public event ItemClick CClick;

        public StartPageButton()
        {
            InitializeComponent();
        }
        
        public Image Images
        {
            get { return p.Image; }
            set { p.Image = value; }
        }
        public string Str
        {
            get { return l.Text; }
            set { l.Text = value; }
        }

        private void item_Click(object sender,System.EventArgs e)
        {
            ControlCLick(sender, e);
        }

        public void ControlCLick(object sender, System.EventArgs e)
        {
            if (CClick != null)
                CClick(sender, e);
        }
    }
}
