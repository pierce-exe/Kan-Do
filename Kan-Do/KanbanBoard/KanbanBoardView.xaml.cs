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

namespace Kan_Do.KanbanBoard
{
    /// <summary>
    /// Interaction logic for KanbanBoardView.xaml
    /// </summary>
    public partial class KanbanBoardView : Page
    {
        public KanbanBoardViewModel KBoardVM; 
        public KanbanBoardView()
        {
            InitializeComponent();
            KBoardVM = new KanbanBoardViewModel();
            ColumnsList.ItemsSource = KBoardVM.boardColumns;
        }

        private void AddColumn(object sender, RoutedEventArgs e)
        {
            //Call the function in the ViewModel that adds a column
            KBoardVM.addColumn();
        }

        private void DeleteColumn(object sender, RoutedEventArgs e)
        {
            //Get the index of the element of the list that the Remove button was selected in
            KanbanColumn kcol = ((Button)sender).Tag as KanbanColumn;

            //Call the function in the VM, that will remove the element at the index 
            KBoardVM.deleteColumn(kcol.ColumnNumber);
        }
    }
}
