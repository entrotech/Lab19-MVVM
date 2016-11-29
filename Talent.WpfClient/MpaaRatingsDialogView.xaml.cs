using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Talent.Domain;

namespace Talent.WpfClient
{
    /// <summary>
    /// Interaction logic for MpaaRatingsDialogView.xaml
    /// </summary>
    public partial class MpaaRatingsDialogView : UserControl
    {
        public MpaaRatingsDialogView()
        {
            InitializeComponent();
            this.DataContext = new MpaaRatingsViewModel();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var vm = (MpaaRatingsViewModel)this.DataContext;
            vm.OnAdd();
            Edit();
        }


        private void ResultsGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = ResultsDataGrid.SelectedItem;
            if (item == null) return;
            Edit();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var item = ResultsDataGrid.SelectedItem;
            if (item == null) return;
            Edit();
        }

        private void Edit()
        {
            var dlg = new MpaaRatingDialog();
            dlg.DataContext = this.DataContext;
            if (dlg.ShowDialog() == true)
            {
            }
        }


    }
}
