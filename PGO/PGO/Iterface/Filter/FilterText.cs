using System;
using System.Windows.Forms;
using PGO.Source;

namespace PGO.Iterface.Filter
{
    public partial class FilterText : Form
    {
        public TypeFilterText FilterState = TypeFilterText.LikeC;
        public string TextFilter = "";
        public Action SetChange;
        public bool Active = false;

        public FilterText()
        {
            TopLevel = false;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterState = (TypeFilterText)comboBox1.SelectedIndex;
            CreateFilter();
            if (SetChange != null)
                SetChange();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CreateFilter();
            if (SetChange != null)
                SetChange();
        }

        private void CreateFilter()
        {
            string temp = textBox1.Text.Trim();
            string str = " ";
            switch (FilterState)
            {
                case TypeFilterText.LikeC:
                    str += "Like '%" + temp + "%' ";
                    break;
                case TypeFilterText.LikeR:
                    str += "Like '%" + temp + "' ";
                    break;
                case TypeFilterText.LikeL:
                    str += "Like '" + temp + "%' ";
                    break;
                case TypeFilterText.Valid:
                    str += "= '" + temp + "' ";
                    break;
                case TypeFilterText.Not:
                    str += "<> '" + temp + "' ";
                    break;
            }
            TextFilter = str;
            Active = true;
        }

        private void вимкнутиФільтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Active = false;
            if (SetChange != null)
                SetChange();
        }
    }
}
