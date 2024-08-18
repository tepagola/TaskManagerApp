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
using TaskManagerApp.Models;
using TaskManagerApp.ViewModels;

namespace TaskManagerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            DataContext = _viewModel;

            // Agregar el evento de cambio de selección
            TaskList.SelectionChanged += TaskList_SelectionChanged;
        }

        private void TaskList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedTask = (TaskModel)TaskList.SelectedItem;
            if (selectedTask != null)
            {
                TaskTitleTextBox.Text = selectedTask.Title;
            }
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            string title = TaskTitleTextBox.Text;

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a title for the task.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var task = new TaskModel { Title = title };
            _viewModel.AddTask(task);

            // Limpiar el TextBox después de agregar la tarea
            TaskTitleTextBox.Text = string.Empty;
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            var selectedTask = (TaskModel)TaskList.SelectedItem;
            if (selectedTask != null)
            {
                _viewModel.DeleteTask(selectedTask);
            }

            // Limpiar el TextBox después de agregar la tarea
            TaskTitleTextBox.Text = string.Empty;
        }

        private void EditTask_Click(object sender, RoutedEventArgs e)
        {
            var selectedTask = (TaskModel)TaskList.SelectedItem;
            if (selectedTask != null)
            {
                string newTitle = TaskTitleTextBox.Text;

                if (string.IsNullOrWhiteSpace(newTitle))
                {
                    MessageBox.Show("Please enter a valid title.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                selectedTask.Title = newTitle;
                _viewModel.UpdateTask(selectedTask);

                // Limpiar el TextBox después de editar la tarea
                TaskTitleTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please select a task to edit.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            var task = checkBox?.DataContext as TaskModel;

            if (task != null)
            {
                _viewModel.UpdateTask(task);
            }
        }
    }
}