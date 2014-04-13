using System;
using System.Windows.Forms;
using PGO.Source;

namespace PGO.Iterface.Filter
{
    public partial class FilterData : Form
    {
        public TypeFilterDate FilterState = TypeFilterDate.Valid;
        public string TextFilter = "";
        public Action SetChange;
        public bool Active = false;
        
        public FilterData()
        {
            TopLevel = false;
            InitializeComponent();
            comboBox1.SelectedIndex = 2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterState = (TypeFilterDate)comboBox1.SelectedIndex;
            CreateFilter();
            if (SetChange != null)
                SetChange();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CreateFilter();
            if (SetChange != null)
                SetChange();
        }

        void CreateFilter()
        {
            string str = " ";
            switch (FilterState)
            {
                case TypeFilterDate.Max:
                    str += "< ";
                    break;
                case TypeFilterDate.Min:
                    str += "> ";
                    break;
                case TypeFilterDate.Valid:
                    str += "= ";
                    break;
                case TypeFilterDate.Not:
                    str += "<> ";
                    break;
            }
            str += " '"+dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" +
                         dateTimePicker1.Value.Day+"' ";

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
