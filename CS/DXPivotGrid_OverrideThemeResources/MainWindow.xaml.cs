using System.Windows;
using DXPivotGrid_OverrideThemeResources.DataSet1TableAdapters;

namespace DXPivotGrid_OverrideThemeResources {
    public partial class MainWindow : Window {
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();
        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = salesPersonDataAdapter.GetData();
        }
    }
}
