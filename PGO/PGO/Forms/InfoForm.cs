using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using PGO.Source;

namespace PGO.Forms
{
    public partial class InfoForm : Form
    {
        private string _res;
        public TableType FormInfo = TableType.None;
        public WorkState WhatNeedDo = WorkState.Update;
        private Action _ifNeedUpdate;
        #region FORM CONTROL

        // закрытие формы
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ОСВОБОЖЕНИЕ РЕСУРСОВ
        private void InfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                switch (FormInfo)
                {
                    case TableType.People:
                        ((LoadForm)tabPage10.Controls[0]).Close();
                        ((LoadForm)tabPage2.Controls[0]).Close();
                        ((LoadForm)tabPage9.Controls[0]).Close();
                        ((LoadForm)tabPage11.Controls[0]).Close();
                        ((LoadForm)tabPage12.Controls[0]).Close();
                        ((LoadForm)tabPage13.Controls[0]).Close();
                        break;
                    case TableType.Pgo:
                        break;
                }
            }
            catch
            {
            }
        }

        public InfoForm()
        {
            InitializeComponent();
        }

        #endregion

        private static string NullString(string s)
        {
            return s == "" ? "NULL" : s;
        }

        // СОЗДАНИЕ ТАБЛИЧЕК ВНУТРИ ВОРМЫ ПРИ СОСТОЯНИИ ОТОБРАЖЕНИЯ ИНФО О ЧЕЛОВЕКЕ
        private void CreatePeople()
        {
            var f = new LoadForm();
            f.StartInside();
            f.LoadTable(TableType.Education, SqlQuery.EducationView.Replace("(VALUE)", NullString(p_id.Text)));
            f.Show();
            tabPage10.Controls.Add(f);

            f = new LoadForm();
            f.StartInside();
            f.LoadTable(TableType.Work, SqlQuery.WorkView.Replace("(VALUE)", NullString(p_id.Text)));
            f.Show();
            tabPage2.Controls.Add(f);

            f = new LoadForm();
            f.StartInside();
            f.LoadTable(TableType.Registration, SqlQuery.RegistrationView.Replace("(VALUE)", NullString(p_id.Text)));
            f.Show();
            tabPage9.Controls.Add(f);

            f = new LoadForm();
            f.StartInside();
            f.LoadTable(TableType.Document, SqlQuery.DocumentView.Replace("(VALUE)", NullString(p_id.Text)));
            f.Show();
            tabPage11.Controls.Add(f);

            f = new LoadForm();
            f.StartInside();
            f.LoadTable(TableType.Family, SqlQuery.FamilyView.Replace("(VALUE)", NullString(p_id.Text)));
            f.Show();
            tabPage12.Controls.Add(f);

            f = new LoadForm();
            f.StartInside();
            f.LoadTable(TableType.Benefit, SqlQuery.BenefitView.Replace("(VALUE)", NullString(p_id.Text)));
            f.Show();
            tabPage13.Controls.Add(f);
        }

        public void LoadEducation(string[] key)
        {
            tabEducation.BringToFront();
            Text = @"Додати освіту";
            if (key == null) return;
            var mas = SqlQuery.EducationOneQuery.Split(
                new[]
                        {
                            "(VALUE)"
                        }
                , StringSplitOptions.None);


            var query = mas[0] + Links.IdPeople + mas[1] + key[0] + mas[2];

            var res = MySqlData.MySqlExecuteData.SqlReturnDataset(query);

            if (!res.HasError)
            {
                var t = res.ResultData.AsDataView();

                SqlCreateQuery.SetValue(e_id, key[0]);
                SqlCreateQuery.SetValue(e_idpeople, Links.IdPeople);
                SqlCreateQuery.SetValue(e_type, t[0].Row[0]);
                SqlCreateQuery.SetValue(e_education, t[0].Row[1]);
                SqlCreateQuery.SetValue(e_zaklad, t[0].Row[2]);
                SqlCreateQuery.SetValue(e_start_picker, t[0].Row[3]);
                SqlCreateQuery.SetValue(e_dataEnd_picker, t[0].Row[4]);
                Text = @"Інформація про освіту";
            }
            else
                MessageBox.Show(res.ErrorText);
        }
        public void LoadWork(string[] key)
        {
            tabWork.BringToFront();
            Text = @"Додати роботу";
            if (key == null) return;
            var mas = SqlQuery.WorkOneQuery.Split(
                new[]
                        {
                            "(VALUE)"
                        }
                , StringSplitOptions.None);


            var query = mas[0] + Links.IdPeople + mas[1] + key[0] + mas[2];

            var res = MySqlData.MySqlExecuteData.SqlReturnDataset(query);

            if (!res.HasError)
            {
                var t = res.ResultData.AsDataView();

                SqlCreateQuery.SetValue(w_id, key[0]);
                SqlCreateQuery.SetValue(w_idpeople, Links.IdPeople);
                SqlCreateQuery.SetValue(w_post, t[0].Row[0]);
                SqlCreateQuery.SetValue(w_description, t[0].Row[1]);
                SqlCreateQuery.SetValue(w_start, t[0].Row[2]);
                SqlCreateQuery.SetValue(w_failed_data, t[0].Row[3]);
                SqlCreateQuery.SetValue(w_info, t[0].Row[4]);
                Text = @"Інформація про роботу";
            }
            else
                MessageBox.Show(res.ErrorText);
        }
        public void LoadPgo(string[] key)
        {
            tabPgo.BringToFront();
            Text = @"Додати ПГО";
            if (key == null) return;
            var mas = SqlQuery.PgoOneQuery.Split(new[]{"(VALUE)"},StringSplitOptions.None);
            var query = mas[0] + key[0] + mas[1] + key[1] + mas[2];

            var res = MySqlData.MySqlExecuteData.SqlReturnDataset(query);

            if (!res.HasError)
            {
                var t = res.ResultData.AsDataView();

                SqlCreateQuery.SetValue(t_nomer, t[0].Row[0]);
                //выполняем запрос получение значения по номеру типа
                var typePgo = MySqlData.MySqlExecuteData.SqlReturnDataset(
                    SqlQuery.PgoTypeName.Replace("(VALUE)", t[0].Row[1].ToString())).
                    ResultData.AsDataView()[0].Row[0].ToString();

                SqlCreateQuery.SetValue(t_tip, t[0].Row[1] + @", " + typePgo);
                l_gospodarstvo.Text = @"Господарство: " + t_nomer.Text + t[0].Row[1];
                SqlCreateQuery.SetValue(t_selo, t[0].Row[2]);
                SqlCreateQuery.SetValue(t_ulicya, t[0].Row[3]);
                SqlCreateQuery.SetValue(t_nomerdoma, t[0].Row[4]);
                SqlCreateQuery.SetValue(t_nomerkavrt, t[0].Row[5]);
                Adress();
                SqlCreateQuery.SetValue(t_memo, t[0].Row[6]);
                SqlCreateQuery.SetValue(checkBox1, t[0].Row[7]);
                panel5.Visible = !checkBox1.Checked;
                SqlCreateQuery.SetValue(t_reason, t[0].Row[8]);
                SqlCreateQuery.SetValue(t_nomerknigi, t[0].Row[9]);
                SqlCreateQuery.SetValue(t_nomerstranici, t[0].Row[10]);
                Text = @"ПГО";
            }
            else
                MessageBox.Show(res.ErrorText);

        }
        public void LoadPeople(string[] key)
        {
            tabPeople.BringToFront();
            Text = @"Додати особу";
            if (key == null) return;
            Links.IdPeople = Convert.ToInt32(key[0]);
            var query = SqlQuery.PeopleOneQuery.Replace("(VALUE)", key[0]);
            var res = MySqlData.MySqlExecuteData.SqlReturnDataset(query);

            if (!res.HasError)
            {
                var t = res.ResultData.AsDataView();
                SqlCreateQuery.SetValue(p_id, t[0].Row[0]);
                SqlCreateQuery.SetValue(p_sename, t[0].Row[1]);
                SqlCreateQuery.SetValue(p_name, t[0].Row[2]);
                SqlCreateQuery.SetValue(p_father, t[0].Row[3]);
                SqlCreateQuery.SetValue(p_birthplace, t[0].Row[4]);
                SqlCreateQuery.SetValue(p_datebirth, t[0].Row[5]);
                SqlCreateQuery.SetValue(p_inn, t[0].Row[6]);
                SqlCreateQuery.SetValue(p_stat, t[0].Row[7]);
                SqlCreateQuery.SetValue(p_golovagospod, t[0].Row[8]);
                SqlCreateQuery.SetValue(p_dateofd, t[0].Row[9]);
                SqlCreateQuery.SetValue(p_reasondeath, t[0].Row[10]);
                Text = p_sename.Text + @" " + p_name.Text + @" " + p_father.Text;
                CreatePeople();
            }
            else
                MessageBox.Show(res.ErrorText);
        }
        public void LoadHouse(string[] key)
        {
            tabLand.BringToFront();
            Text = @"";
            if (key == null) return;
        }
        public void LoadLand(string[] key)
        {
            tabHouse.BringToFront();
            Text = @"";
            if (key == null) return;
        }
        
        
        
        
        public void SavePgo()
        {
            var stree = MySqlData.MySqlExecute.SqlScalar(SqlQuery.StreetIdGet.Replace("(VALUE)",
                          t_ulicya.Text.Trim())).ResultText[0].ToString(CultureInfo.InvariantCulture);
            var ulic = MySqlData.MySqlExecute.SqlScalar(SqlQuery.VillageIdGet.Replace("(VALUE)",
                t_selo.Text.Trim())).ResultText[0].ToString(CultureInfo.InvariantCulture);
            var mas = new[]
                    {
                        stree,
                        ulic,
                        t_memo.Text.Trim(),
                        t_nomerknigi.Text.Trim(),
                        t_nomerstranici.Text.Trim(),
                        t_nomerdoma.Text.Trim(),
                        t_nomerkavrt.Text.Trim(),
                        checkBox1.Checked ? "1" : "0",
                        t_reason.Text.Trim(),
                        t_tip.Text[0].ToString(CultureInfo.InvariantCulture),
                        t_nomer.Text.Trim()
                    };
            if (!SqlCreateQuery.Update(TableType.Pgo, WhatNeedDo, mas, ref _res))
                MessageBox.Show(_res);
           
        }
        public void SavePeople()
        {
            var pmas = new[]
                    {
                        p_sename.Text.Trim(),
                        p_name.Text.Trim(),
                        p_father.Text.Trim(),
                        p_birthplace.Text.Trim(),
                        SqlCreateQuery.SetData(p_datebirth.Text.Trim()),
                        p_inn.Text.Trim(),
                        p_stat.Text.Trim(),
                        p_golovagospod.Checked ? "1" : "0",
                        SqlCreateQuery.SetData(p_dateofdeath.Text.Trim()),
                        p_reasondeath.Text.Trim(),
                        p_id.Text.Trim()
                    };
            if (!SqlCreateQuery.Update(TableType.People, WhatNeedDo, pmas, ref _res))
                MessageBox.Show(_res);
        }
        public void SaveWork()
        {
            var pmas = new[]
                    {
                        w_post.Text.Trim(),
                        w_description.Text.Trim(),
                        SqlCreateQuery.SetData(w_start.Text.Trim()),
                        SqlCreateQuery.SetData(w_failed_textBox1.Text.Trim()),
                        w_info.Text.Trim(),
                        w_idpeople.Text.Trim(),
                        w_id.Text.Trim()
                    };
            if (!SqlCreateQuery.Update(TableType.Work, WhatNeedDo, pmas, ref _res))
                MessageBox.Show(_res);
        }
        //public void LoadLand(string[] key)
        //{

        //}

        /// <summary>
        /// ЗАГРУЗКА ИНФОРМАЦИИ В ФОРМУ ПО ЗАДАНЫМ КЛЮЧАМ
        /// </summary>
        /// <param name="key">КЛЮЧИ ДЛЯ ЗАПРОСА</param>
        /// <param name="ifNeedUpdate">КАЛБЕК ЧТО СДЕЛАТЬ ПОСЛЕ ЗАКРЫТИЯ ФОРМЫ</param>
        public void LoadInfoAbout(string[] key, Action ifNeedUpdate)
        {
            _ifNeedUpdate = ifNeedUpdate;

            var mi = typeof (InfoForm).GetMethod("Load"+FormInfo);
            mi.Invoke(this, new object[]{key});
        }
        // сохранение значений
        private void button2_Click(object sender, EventArgs e)
        {
            _res = "";

            var mi = typeof(InfoForm).GetMethod("Save" + FormInfo);
            mi.Invoke(this, null);

            if (_ifNeedUpdate != null)
                _ifNeedUpdate();
            if (_res == "")
                Close();
        }
       
        #region TabControl PGO

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel5.Visible = !checkBox1.Checked;
        }

        private void Adress()
        {
            l_adress.Text =
                @"c. " + t_selo.Text +
                @" вул. " + t_ulicya.Text +
                @" д. " + t_nomerdoma.Text;

            l_adress.Text +=
                t_nomerkavrt.Text.Trim() != ""
                    ? " кв. " + t_nomerkavrt.Text
                    : "";
        }

        // выбрать тип пго
        private void button3_Click(object sender, EventArgs e)
        {
            var f = new LoadForm
            {
                State = StateOfClick.Click,
                ClickCallBack = g =>
                {
                    t_tip.Text = g;
                }
            };
            f.LoadTable(TableType.PgoType, SqlQuery.PgoTypeShow);
            f.ShowDialog();
        }

        // выбрать названия села
        private void button4_Click(object sender, EventArgs e)
        {
            var f = new LoadForm
            {
                State = StateOfClick.Click,
                ClickCallBack = g =>
                {
                    t_selo.Text = g;
                }
            };
            f.LoadTable(TableType.Village, SqlQuery.VillageShow);
            f.ShowDialog();
        }

        // выбор назвагия улици
        private void button5_Click(object sender, EventArgs e)
        {
            var f = new LoadForm
            {
                State = StateOfClick.Click,
                ClickCallBack = g =>
                {
                    t_ulicya.Text = g;
                }
            };
            f.LoadTable(TableType.Street, SqlQuery.StreetShow);
            f.ShowDialog();
        }

       // В ПОЛЕ КНИГА И НОМЕР СТРАНИЦИ ДОЛЖНЫ БЫТЬ ЧИСЛА
        private void t_nomerknigi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(((TextBox) sender).Text);
                ((TextBox) sender).BackColor = Color.White;
            }
            catch
            {
                ((TextBox) sender).BackColor = Color.Red;
            }
        }

        #endregion

        #region People
        // связка для даты смерти
        private void p_dateofdeath_ValueChanged(object sender, EventArgs e)
        {
            p_dateofdeath.Text = p_dateofd.Value.Day + "." + p_dateofd.Value.Month + "." + p_dateofd.Value.Year;
        }
        private void p_dateofdeath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                p_dateofd.Value = Convert.ToDateTime(p_dateofdeath.Text.Trim());
            }
            catch { }
        }
        #endregion
       
        #region Work
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                w_failed_data.Value = Convert.ToDateTime(w_failed_textBox1.Text.Trim());
            }
            catch { }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            w_failed_textBox1.Text = w_failed_data.Text.ToString(CultureInfo.InvariantCulture);
        }
        #endregion
        #region Education
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            panel19.Visible = !e_education.Checked;
        }
        private void e_dataEnd_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                e_dataEnd_picker.Value = Convert.ToDateTime(e_dataEnd_text.Text.Trim());
            }
            catch { }
        }
        private void e_dataEnd_picker_ValueChanged(object sender, EventArgs e)
        {
            e_dataEnd_text.Text = e_dataEnd_picker.Value.Day + "." + p_dateofd.Value.Month + "." + p_dateofd.Value.Year;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var f = new LoadForm
            {
                State = StateOfClick.Click,
                ClickCallBack = g =>
                {
                    t_selo.Text = g;
                }
            };
            f.LoadTable(TableType.Village, SqlQuery.VillageShow);
            f.ShowDialog();
        }
        #endregion

       
    }
}