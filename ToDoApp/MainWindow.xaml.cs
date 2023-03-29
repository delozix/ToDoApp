using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using ToDoApp.Models;

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<ToDoModel> _ToDoDataList;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dgToDoList_Loaded(object sender, RoutedEventArgs e)
        {
            _ToDoDataList = new BindingList<ToDoModel>()
            {
                new ToDoModel(){TaskText = "Сделать кувырок"},
                new ToDoModel() { CreationDate = new DateTime() }
            };
            dgToDoList.ItemsSource = _ToDoDataList;

            _ToDoDataList.ListChanged += _ToDoDataList_ListChanged;
        }

        private void _ToDoDataList_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.Reset:
                    break;
                case ListChangedType.ItemAdded:
                    break;
                case ListChangedType.ItemDeleted:
                    break;
                case ListChangedType.ItemMoved:
                    break;
                case ListChangedType.ItemChanged:
                    break;
                case ListChangedType.PropertyDescriptorAdded:
                    break;
                case ListChangedType.PropertyDescriptorDeleted:
                    break;
                case ListChangedType.PropertyDescriptorChanged:
                    break;
            }
        }
    }
}