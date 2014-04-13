using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using PGO.Source;

namespace PGO.Forms
{
    public partial class LoadForm : Form
    {
        //*********************************
        //
        public StateOfClick State = StateOfClick.Select;
        public TableType Table = TableType.None;
        public Action<string> ClickCallBack = null;
        //*********************************
        //
        private InfoForm _f;
        private string _query;
        private DataView _dv;
        private int _dateColumn = 0;
        //*********************************
        //
        private FilterMenager _filteres;
        public LoadForm()
        {
            InitializeComponent();
            _f = new InfoForm { FormInfo = TableType.None };
        }

        //////////////////////////////////////////////////////////////////////////////
        // Заполнение таблици на форме (тип заполнения, запрос к бд)
        public void LoadTable(TableType table, string query)
        {
            
            _query = query;
            Table = table;

            //включяем все компоненты на форме
            peopleToolBtn.Visible = pgoToolBtn.Visible =
                houseToolBtn.Visible = landToolBtn.Visible =
                    toolPEREHOD.Visible = toolREPORT.Visible = true;


            // устанавливаем заглавие формы, выключаем не нужные компоненты,
            // взависимости от отображаемой формы


            switch (Table)
            {
                case TableType.People:
                    Text = @"Фізичні особи";
                    peopleToolBtn.Visible = false;
                    break;

                case TableType.Pgo:
                    Text = @"Об'єкти погосподарського обліку";
                    pgoToolBtn.Visible = false;
                    break;

                case TableType.House:
                    Text = @"Бдинки";
                    houseToolBtn.Visible = false;
                    break;

                case TableType.Land:
                    Text = @"Землі";
                    landToolBtn.Visible = false;
                    break;

                case TableType.PgoType:
                    Text = @"Тип господарства";
                    toolPEREHOD.Visible = false;
                    toolREPORT.Visible = false;
                    break;

                case TableType.Village:
                    Text = @"Населений пункт";
                    toolPEREHOD.Visible = false;
                    toolREPORT.Visible = false;
                    break;

                case TableType.Street:
                    Text = @"Вулиця";
                    toolPEREHOD.Visible = false;
                    toolREPORT.Visible = false;
                    break;

                default:
                    toolPEREHOD.Visible = false;
                    toolREPORT.Visible = false;
                    break;
            }
            //Выполнение заполнение таблици
            ViewData();
        }
        // выполнение двойного клика на таблице (номер выбраной строки)
        private void OpenEdit(int index)
        {
            if (index == -1) return;
            // установка типа заполнения таблици
            _f = new InfoForm {FormInfo = Table};

            // состояние окна - выбор элемента для заполнения поля в форме информации (click)
            //                - заполнение окна данными для редактирования (select)
            switch (State)
            {
                    #region SELECT

                case StateOfClick.Select:
                    switch (Table)
                    {
                        #region SHOW PEOPLE

                        case TableType.People:
                        {
                            dTable.Columns[0].Visible = false;
                            _f.LoadInfoAbout(new[] {dTable[0, index].Value.ToString()}, ViewData);
                            _f.ShowDialog();
                        }
                            break;

                            #endregion

                            #region SHOW PGO

                        case TableType.Pgo:
                        {
                            var r = dTable[0, index].Value.ToString();

                            _f.LoadInfoAbout(
                                new[]
                                {
                                    r.Substring(0, r.Length - 1),
                                    r[r.Length - 1].ToString(CultureInfo.InvariantCulture)
                                },
                                ViewData);
                            _f.ShowDialog();
                        }
                            break;

                            #endregion

                            #region SHOW LAND

                        case TableType.Land:
                        {
                            dTable.Columns[0].Visible = false;
                        }
                            break;

                            #endregion
                        #region SHOW WORK

                        case TableType.Work:
                            {
                                dTable.Columns[0].Visible = false;
                                _f.LoadInfoAbout(new[]
                                {
                                    dTable[0, index].Value.ToString(),

                                }, ViewData);
                                _f.ShowDialog();
                            }
                            break;

                        #endregion
                        #region SHOW EDUCATION

                        case TableType.Education:
                            {
                                dTable.Columns[0].Visible = false;
                                _f.LoadInfoAbout(new[] { dTable[0, index].Value.ToString() }, ViewData);
                                _f.ShowDialog();
                            }
                            break;

                        #endregion
                    }
                    break;

                    #endregion

                    #region CLICK

                case StateOfClick.Click:
                    switch (Table)
                    {
                            #region SHOW VILLAGE

                        case TableType.Village:
                        {
                            if (ClickCallBack != null)
                                ClickCallBack(dTable[1, index].Value.ToString());
                            Close();
                        }
                            break;

                            #endregion

                            #region SHOW STREET

                        case TableType.Street:
                        {
                            if (ClickCallBack != null)
                                ClickCallBack(dTable[1, index].Value.ToString());
                            Close();
                        }
                            break;

                            #endregion

                            #region SHOW PGO TYPE

                        case TableType.PgoType:
                        {
                            var r = dTable[0, index].Value.ToString();
                            var r1 = dTable[1, index].Value.ToString();
                            var res = r + ", " + r1;
                            if (ClickCallBack != null)
                                ClickCallBack(res);
                            Close();
                        }
                            break;

                            #endregion
                    }
                    break;

                    #endregion
            }
        }

        // выполнение запроса и вывод результата в таблицу
        private void ViewData()
        {
            dTable.Columns.Clear();
            // проверка запроса
            var res = MySqlData.MySqlExecuteData.SqlReturnDataset(_query);
            if (res.HasError)
            {
                // ошибка в запросе
                dTable.DataSource = null;
                MessageBox.Show(res.ErrorText);
                return;
            }
            
            // Установка фильтров
            dTable.DataSource = res.ResultData.DefaultView;
            _dv = (DataView)dTable.DataSource;
            _dateColumn = -1;
            #region скрытие столбцов которые не нужно отображать
            switch (Table)
            {
                case TableType.People:
                    dTable.Columns[0].Visible = false;
                    _dateColumn = 4;
                    break;

                case TableType.Land:
                    dTable.Columns[0].Visible = false;
                    break;

                case TableType.Street:
                    dTable.Columns[0].Visible = false;
                    break;

                case TableType.Village:
                    dTable.Columns[0].Visible = false;
                    break;

                case TableType.Family:
                    dTable.Columns[0].Visible = false;
                    dTable.Columns[1].Visible = false;
                    break;

                case TableType.Work:
                    dTable.Columns[0].Visible = false;
                    break;

                case TableType.Education:
                    dTable.Columns[0].Visible = false;
                    break;

                case TableType.Benefit:
                    dTable.Columns[0].Visible = false;
                    dTable.Columns[1].Visible = false;
                    break;
            }

            #endregion

            CreateFilter();
        }
        // удаление записи из таблици
        private void RemoveComponent(int index)
        {
            string sql;
            string temp;

            switch (Table)
            {
                    #region DELETE PEOPLE

                case TableType.People:
                    MySqlData.MySqlExecute.SqlNoneQuery(SqlQuery.PeopleDelete.Replace("(VALUE)",
                        dTable[0, index].Value.ToString()));
                    ViewData();
                    break;

                    #endregion

                    #region DELETE PGO

                case TableType.Pgo:
                    temp = dTable[0, index].Value.ToString();
                    var mas = SqlQuery.PgoDelete.Split(new[] {"(VALUE)"}, StringSplitOptions.RemoveEmptyEntries);

                    sql = mas[0] + temp.Substring(0, temp.Length - 1) + mas[1] +
                          temp[temp.Length - 1].ToString(CultureInfo.InvariantCulture) + mas[2];

                    MySqlData.MySqlExecute.SqlNoneQuery(sql);
                    ViewData();
                    break;

                    #endregion
            }
        }

        // ДЛЯ ОТОБРАЖЕНИЯ ФОРМЫ В ФОРМЕ
        public void StartInside()
        {
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
        }

        //////////////////////////////////////////////////////////////////////////////
        // 2xClick on dTable
        private void dTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenEdit(e.RowIndex);
        }
        // переходы
        private void peopleToolBtn_Click(object sender, EventArgs e)
        {
            LoadTable(TableType.People,SqlQuery.PeopleView);
        }
        private void landToolBtn_Click(object sender, EventArgs e)
        {
            LoadTable(TableType.Land,_query = SqlQuery.LandView);
        }
        private void pgoToolBtn_Click(object sender, EventArgs e)
        {
            LoadTable(TableType.Pgo,_query = SqlQuery.PgoView);
        }
        private void houseToolBtn_Click(object sender, EventArgs e)
        {
            LoadTable(TableType.House,_query = SqlQuery.HouseView);
        }
        // обновить
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            LoadTable(Table,_query);
        }
        // редактировать
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if(dTable.SelectedRows.Count>0)
                OpenEdit(dTable.SelectedRows[0].Index);
        }
        // удалить
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dTable.SelectedRows.Count > 0)
                RemoveComponent(dTable.SelectedRows[0].Index);
        }
        // создать
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _f = new InfoForm { FormInfo = Table };
           
            _f.LoadInfoAbout(null, ViewData);
            _f.WhatNeedDo = WorkState.Insert;
            _f.ShowDialog();
        }


        
        private void CreateFilter()
        {
            _filteres = new FilterMenager(_dv);
            filter_parent.Controls.Clear();

            int k = 0;
            for (int i = 0; i < dTable.Columns.Count; i++)
            {
                if (dTable.Columns[i].Visible)
                {
                    if (_dateColumn == i)
                    {
                        _filteres.Filters.Add(
                            new FilterMenager.FilterD(filter_parent, 
                                dTable.Columns[i].Width) 
                                { 
                                    SetChange = () => _filteres.FiltersUpdate(),
                                    ColumnId = i,
                                    FilterType = TypeFilter.Date,
                                    ColumnName = dTable.Columns[i].HeaderText,
                                    Value = ""
                                });
                    }
                    else
                    {
                        _filteres.Filters.Add(new FilterMenager.FilterT(filter_parent,  dTable.Columns[i].Width)
                        {
                            SetChange = () => _filteres.FiltersUpdate(),
                            ColumnId = i,
                            FilterType = TypeFilter.Text,
                            ColumnName = dTable.Columns[i].HeaderText,
                            Value = ""
                        });
                    }
                    k++;
                }
            }
        }
        
        private void LoadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_filteres != null)
            {
                foreach (var t in _filteres.Filters)
                    t.Body.Close();
                _filteres.Filters.Clear();
                filter_parent.Controls.Clear();
            }
        }

        private void dTable_Resize(object sender, EventArgs e)
        {
            
        }

        private void dTable_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if(_filteres!=null&&ContainsFocus)
                foreach (var t in _filteres.Filters)
                {
                    if (t.ColumnId < dTable.Columns.Count)
                    {
                        t.Body.Width = dTable.Columns[t.ColumnId].Width;
                    }
                }
        }

        private void filter_parent_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.Margin = new Padding(0);
            e.Control.Padding = new Padding(0);
        }

    }
}