using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CenterSys
{
   
    public partial class addParameterView : UserControl
    {
        ParametersViweModel parametersViwe = new ParametersViweModel();
        public addParameterView()
        {
         
            InitializeComponent();
            this.DataContext = parametersViwe;
        }

        private void SaveBut_Click(object sender, RoutedEventArgs e)
        {
            //parametersViwe.ParameterCode = "cbc";
            //parametersViwe.ParameterName = "CBC";
            MessageBox.Show(parametersViwe.ParameterCode + "  " + parametersViwe.ParameterName);
        }
    }

    
}
