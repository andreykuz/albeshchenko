using System;
using System.Linq;
using System.Windows.Forms;

namespace PGO.Source
{
    internal class SqlCreateQuery
    {
        private static void ClearMass(ref string[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].ToLower() == "null") continue;
                mas[i] = "'" + mas[i] + "'";
            }
        }
        public static void SetValue(object obj, object value)
        {
            switch (obj.GetType().Name)
            {
                case "Label":
                    ((Label)obj).Text = value.ToString().Trim();
                    break;
                case "RichTextBox":
                    ((RichTextBox)obj).Text = value.ToString().Trim();
                    break;
                case "TextBox":
                    ((TextBox)obj).Text = value.ToString().Trim();
                    break;
                case "MaskedTextBox":
                    ((MaskedTextBox)obj).Text = value.ToString().Trim();
                    break;
                case "DateTimePicker":
                    if (value.ToString() == "") break;
                    ((DateTimePicker)obj).Value = Convert.ToDateTime(value.ToString());
                    break;
                case "CheckBox":
                    if (value.ToString() == "") break;
                    ((CheckBox)obj).Checked = Convert.ToBoolean(value.ToString());
                    break;
                case "ComboBox":
                    ((ComboBox)obj).SelectedItem = value.ToString();
                    break;
            }
        }
        public static string GetFinalQuery(string[] sql, string[] val, int count, bool update)
        {
            string result = "";
            for (int index = 0; index < val.Length-1; index++)
                result += sql[index] + val[index];

            if (update) result += sql[sql.Length - 1];
            if (update) result += val[val.Length-1];
            else result += sql[sql.Length - 1];

            return result;
        }
        public static string SetData(string date)
        {
            string result;
            if (date == "") return "NULL";

            DateTime dt = Convert.ToDateTime(date);

            result = dt.Date.Year + "-";
            result += dt.Date.Month + "-";
            result += dt.Date.Day;

            return result;
        }
        public static bool Update(TableType type, WorkState work, string[] values, ref string result)
        {
            string[] temp;
            string sql;
            MySqlData.MySqlExecute.MyResult res;
            ClearMass(ref values);
            switch (type)
            {
                #region PEOPLE
                case TableType.People:
                      temp = work == WorkState.Update ?
                        SqlQuery.PeopleUpdate.Split(new[] { "(VALUE)" }, StringSplitOptions.RemoveEmptyEntries) :
                        SqlQuery.PeopleInsert.Split(new[] { "(VALUE)" }, StringSplitOptions.RemoveEmptyEntries);

                    sql = GetFinalQuery(temp, values, values.Length, work == WorkState.Update);
                    res = MySqlData.MySqlExecute.SqlNoneQuery(sql);
                    if (res.HasError)
                    {
                        result = res.ErrorText;
                        return false;
                    }
                    break;
#endregion
                #region PGO
                case TableType.Pgo:

                    temp = work == WorkState.Update ?
                        SqlQuery.PgoUpdate.Split(new[] { "(VALUE)" }, StringSplitOptions.RemoveEmptyEntries) :
                        SqlQuery.PgoInsert.Split(new[] { "(VALUE)" }, StringSplitOptions.RemoveEmptyEntries);

                    sql = GetFinalQuery(temp, values, values.Length, work == WorkState.Update);
                    res = MySqlData.MySqlExecute.SqlNoneQuery(sql);
                    if (res.HasError)
                    {
                        result = res.ErrorText;
                        return false;
                    }
                    break;
                #endregion
                case TableType.House:
                    break;
                case TableType.Land:
                    break;
                case TableType.Village:
                    break;
                case TableType.Street:
                    break;
                #region PGO
                case TableType.Work:

                    temp = work == WorkState.Update ?
                        SqlQuery.WorkUpadte.Split(new[] { "(VALUE)" }, StringSplitOptions.RemoveEmptyEntries) :
                        SqlQuery.WorkInsert.Split(new[] { "(VALUE)" }, StringSplitOptions.RemoveEmptyEntries);

                    sql = GetFinalQuery(temp, values, values.Length, work == WorkState.Update);
                    res = MySqlData.MySqlExecute.SqlNoneQuery(sql);
                    if (res.HasError)
                    {
                        result = res.ErrorText;
                        return false;
                    }
                    break;
                #endregion
            }
            return true;
        }
    }
}