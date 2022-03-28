﻿using System;
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
            //Call the function in the ViewModel that adds a column
            MessageBox.Show(String.Format("Delete column function clicked with {0}", sender.ToString()));
            //Bind the delete button to the IsDelete boolean in the observable collection object list 
            //The button will set the boolean value to true, and the delete function in the VM will look for an element
            //Where the IsDelete value is true, and remove it from the list 
        }
    }
}
