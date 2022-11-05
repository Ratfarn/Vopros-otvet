using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PrepodsAndAnswers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var currentDiscipline = StudyEntities.GetContext().Disciplines.ToList();
            datagrid.ItemsSource = currentDiscipline;
        }

        private void ButtonQA_Click(object sender, RoutedEventArgs e)
        {
            Disciplines discipline = (sender as Button).DataContext as Disciplines;
            List <Questions> Q = discipline.Questions.ToList();
            List<Answers> A = discipline.Answers.ToList();
            MessageBox.Show($"Вопрос: {Q[0].Question}\nОтвет: {A[0].Correct}", "Вопросики на ответики");
        }
    }
}
