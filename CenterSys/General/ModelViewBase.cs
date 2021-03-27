using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows;
using System.Data;
using CenterSys;
using Dapper;

namespace CenterSys
{
    public class ModelViewBase : INotifyPropertyChanged, ICommand
    {
        private readonly string dbString = ConfigClass.Get_ConnectionString();
        public event PropertyChangedEventHandler PropertyChanged;
      
        Action<object> action;
        bool CanExecuteCache;
        public bool CanExecute(object parameter)
        {
            return CanExecuteCache;
        }

        public void ExecuteProcedure(object model , string ProcedureName)
        {
            if (model != null)
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbString))
                {
                    try
                    {
                        var Procedure = new DynamicParameters();
                        model.GetType().GetProperties().ToList().ForEach(q => {
                            Procedure.Add("@"+q.Name, q.GetValue(model, null));
                        });
                        connection.Execute(ProcedureName, Procedure, commandType: CommandType.StoredProcedure);
                        //return "successful";
                    }
                    catch (Exception ex)
                    {
                        //return ex.Message;
                    }


                }
              
            }

        }
        //public object FirstSelect(DynamicParameters parameter, string Query)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbString))
        //    {
        //        try
        //        {
        //            return  connection.Query<object>(Query, parameter, commandType: CommandType.Text).First();
        //        }
        //        catch (Exception ex)
        //        {
                    
        //            return null;
        //        }

        //    }
           

        //}

        public object ExecuteSelect(DynamicParameters parameter, string Query)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbString))
            {
                try
                {
                    return connection.Query<object>(Query, parameter, commandType: CommandType.Text).ToList();
                }
                catch (Exception ex)
                {

                    return null;
                }

            }


        }

        public object MultipleSelect(DynamicParameters parameter, string Query)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(dbString))
            {
                using (var multi = connection.QueryMultiple(Query, parameter, commandType: CommandType.Text))
                {
                     return multi;
                }
              

            }



        }


        public void Execute(object parameter)
        {
            this.action(parameter);
        }
        public ModelViewBase()
        {
        
        }
        public  ModelViewBase(Action<object> action,bool CanExecuteCache)
        {
            this.action = action;
            this.CanExecuteCache = CanExecuteCache;
        }
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (!string.IsNullOrEmpty(propertyName))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
