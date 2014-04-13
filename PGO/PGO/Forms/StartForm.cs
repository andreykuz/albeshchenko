using System;
using System.Windows.Forms;
using PGO.Source;

namespace PGO.Forms
{
    public partial class StartForm : Form
    {
        public static StartForm Instaniate;
        private LoadForm _f;

        public StartForm()
        {
            InitializeComponent();
            if (Instaniate == null)
                Instaniate = this;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            startPageButton1.Images = imageList1.Images[5];
            //startPageButton2.Images = imageList1.Images[4];
            startPageButton3.Images = imageList1.Images[1];
            //startPageButton4.Images = imageList1.Images[4];
            startPageButton5.Images = imageList1.Images[0];
            startPageButton6.Images = imageList1.Images[2];
            startPageButton7.Images = imageList1.Images[3];
            startPageButton8.Images = imageList1.Images[4];

            _f = new LoadForm {Table = TableType.None};

            MySqlData.ConnectionString =
                @"server=localhost;User Id=root;password=swennn;Persist Security Info=True;database=pgo";
            
            /*
            var cc = new CreateConnect
            {
                CallBack = g =>
                {
                    MySqlData.ConnectionString = g;
                }
            };
            cc.ShowDialog();
             */
        }

        public void startPageButton1_CClick(object sender, EventArgs e)
        {
            if (_f.IsDisposed)
                _f = new LoadForm();
            _f.LoadTable(TableType.People,SqlQuery.PeopleView);
            _f.ShowDialog();
        }

        private void startPageButton2_CClick(object sender, EventArgs e)
        {
            if (_f.IsDisposed)
                _f = new LoadForm();

            _f.LoadTable(TableType.Pgo, SqlQuery.PgoView);
            _f.ShowDialog();
        }

        private void startPageButton3_CClick(object sender, EventArgs e)
        {
            if (_f.IsDisposed)
                _f = new LoadForm();
            _f.LoadTable(TableType.House, SqlQuery.HouseView);
            _f.ShowDialog();
        }

        private void startPageButton4_CClick(object sender, EventArgs e)
        {
            if (_f.IsDisposed)
                _f = new LoadForm();
            _f.LoadTable(TableType.Land, SqlQuery.LandView);
            _f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlData.ConnectionString =
                @"server=localhost;User Id=root;password=ferrary;Persist Security Info=True;database=pgo";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlData.ConnectionString =
                @"server=localhost;User Id=root;password=swennn;Persist Security Info=True;database=pgo";
            
        }
    }
}
