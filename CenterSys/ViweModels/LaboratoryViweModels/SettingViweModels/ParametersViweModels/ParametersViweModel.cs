using System;
using System.Collections.Generic;
using System.Windows;

namespace CenterSys
{
    public class ParametersViweModel : ModelViewBase
    {
        private ParametersModel parameter = new ParametersModel();
        public string ParameterId
        {
            get { return parameter.ParameterId; }
            set { 
                parameter.ParameterId = value;
                NotifyPropertyChanged("ParameterId");
            }
        }
        public string ParameterCode
        {
            get { return parameter.ParameterCode; }
            set
            {
                parameter.ParameterCode = value;
                NotifyPropertyChanged("ParameterCode");
                MessageBox.Show(value);
            }
        }
        public string ParameterName
        {
            get { return parameter.ParameterName; }
            set
            {
                parameter.ParameterName = value;
                NotifyPropertyChanged("ParameterName");
            }
        }
        public int ParameterInput
        {
            get { return parameter.ParameterInput; }
            set
            {
                parameter.ParameterInput = value;
                NotifyPropertyChanged("ParameterInput");
            }
        }
        public string MeasuringUnit
        {
            get { return parameter.MeasuringUnit; }
            set
            {
                parameter.MeasuringUnit = value;
                NotifyPropertyChanged("MeasuringUnit");
            }
        }
        public string Descrption
        {
            get { return parameter.Descrption; }
            set
            {
                parameter.Descrption = value;
                NotifyPropertyChanged("Descrption");
            }
        }
        public bool IsActive
        {
            get { return parameter.IsActive; }
            set
            {
                parameter.IsActive = value;
                NotifyPropertyChanged("IsActive");
            }
        }
        public bool OnReport
        {
            get { return parameter.OnReport; }
            set
            {
                parameter.OnReport = value;
                NotifyPropertyChanged("OnReport");
            }
        }
        public bool OnScreen
        {
            get { return parameter.OnScreen; }
            set
            {
                parameter.OnScreen = value;
                NotifyPropertyChanged("OnScreen");
            }
        }
        public string ParameterReport
        {
            get { return parameter.ParameterReport; }
            set
            {
                parameter.ParameterReport = value;
                NotifyPropertyChanged("ParameterReport");
            }
        }

        public int StateProcedure
        {
            get { return parameter.StateProcedure; }
            set
            {
                parameter.StateProcedure = value;
                NotifyPropertyChanged("StateProcedure");
            }
        }

        public List<ParametersRangsModel> ParametersRangs {

            get { return parameter.ParametersRangs; }
            set { parameter.ParametersRangs = value;
                NotifyPropertyChanged("ParametersRangs");
            }
        }
        public List<ParametersOptionsModel> ParametersOptions
        {

            get { return parameter.ParametersOptions; }
            set
            {
                parameter.ParametersOptions = value;
                NotifyPropertyChanged("ParametersOptions");
            }
        }



    }
}
