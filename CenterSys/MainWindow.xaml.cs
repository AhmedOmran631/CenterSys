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
using System.Windows.Shapes;
using DevExpress.Xpf.Core;


namespace CenterSys
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        void addTabItem(UserControl Viwe, string header)
        {
            DXTabItem New_XT_Page = new DXTabItem();

            New_XT_Page.Content = Viwe.Content;
            New_XT_Page.Header = header;
            New_XT_Page.AllowHide = DevExpress.Utils.DefaultBoolean.True;
            MainTab.Items.Add(New_XT_Page);
            MainTab.SelectedIndex = MainTab.Items.Count - 1;
        }

        private void DeviceViewBut_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var View = new addDeviceView();
            addTabItem(View, e.Item.Content.ToString());



        }

        private void MainTap_TabAdding(object sender, TabControlTabAddingEventArgs e)
        {
            var View = new AddSourcesView();
            e.Item = new DXTabItem() { Header = "Custom Item", Content = View.Content };
        }



        private void AddPriceViewBut_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var View = new AddPriceView();
            addTabItem(View, e.Item.Content.ToString());

        }

        private void QuickListsViewBut_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

            var View = new addQuickListsView();
            addTabItem(View, e.Item.Content.ToString());
        }

        private void addAnalyzesViewBut_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var View = new addAnalyzesView();
            addTabItem(View, e.Item.Content.ToString());
        }

        private void SampleViewBut_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var View = new addSampleView();
            addTabItem(View, e.Item.Content.ToString());
        }

        private void MainTap_SelectionChanged(object sender, TabControlSelectionChangedEventArgs e)
        {

        }



        private void ParameterViewBut_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var View = new addParameterView();
            addTabItem(View, e.Item.Content.ToString());
        }

        private void AnlysisFamiliesViewBut_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var View = new addAnalysisFamilies();
            addTabItem(View, e.Item.Content.ToString());
        }

        private void AddSourcesViewBut_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var View = new AddSourcesView();
            addTabItem(View, e.Item.Content.ToString());
        }


        private void PatientReservationBtn_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var View = new PatientReservationView();
            addTabItem(View, e.Item.Content.ToString());
        }
    }
}
