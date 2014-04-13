using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PGO.Iterface.Filter;

namespace PGO.Source
{
    public class FilterMenager
    {
        private readonly DataView _bs;
        public List<Filter> Filters = new List<Filter>();
        public FilterMenager(DataView bSource)
        {
            _bs = bSource;
        }

        public void FiltersUpdate()
        {
            string str = "";
            for (int i = 0; i < Filters.Count; i++)
            {
                var t = Filters[i];
                if (t.Active)
                    if (t.Value != "")
                        str += " AND ( `" + t.ColumnName + "` " + t.Value + ") ";
            }
            try
            {
                _bs.RowFilter = "1 = 1 " + str;
            }
            catch
            {
                _bs.RowFilter = "";
            }
        }
                /*    
            for (int i = 0; i < temp.Count; i++)
            {
                str += "`"+temp[i++] + "` Like '%" + temp[i]+"%'";
                str+=" and ";
            }
           .Substring(0, str.Length - 4);*/

        public class FilterD : Filter
        {
            public FilterD(Control parent, int width) : base(parent, width)
            {
                Body = new FilterData
                {
                    SetChange = () =>
                    {
                        Value = ((FilterData)Body).TextFilter;
                        Active = ((FilterData)Body).Active;
                        FilterTypeD = ((FilterData)Body).FilterState;
                        if (SetChange != null)
                            SetChange();
                    }
                };

                parent.Controls.Add(Body);
                Body.Width = width;
                
                Body.Show();
            }
        }
        public class FilterT : Filter
        {
            public FilterT(Control parent, int width)
                : base(parent, width)
            {
                Body = new FilterText
                {
                    SetChange = () =>
                    {
                        Value = ((FilterText) Body).TextFilter;
                        Active = ((FilterText)Body).Active;
                        FilterTypeT = ((FilterText) Body).FilterState;
                        if (SetChange != null)
                            SetChange();
                    }
                };

                parent.Controls.Add(Body);
                Body.Width = width;
                Body.Show();
            }
        }
        public class Filter
        {
            public TypeFilterDate FilterTypeD;
            public TypeFilterText FilterTypeT;
            public Form Body;
            public TypeFilter FilterType = TypeFilter.Text;
            public string ColumnName = "";
            public int ColumnId = -1;
            public string Value = "";
            public Action SetChange;
            public bool Active = false;

            public Filter(Control parent, int width){}
        }
    }
}
