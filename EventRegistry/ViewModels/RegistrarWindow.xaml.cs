using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace EventRegistrationApp
{
    public partial class RegistrarWindow : Window
    {
        public ObservableCollection<Attendance> Attendances { get; set; } = new ObservableCollection<Attendance>();

        public RegistrarWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void MarkAttendanceButton_Click(object sender, RoutedEventArgs e)
        {
            Attendances.Add(new Attendance
            {
                Participant = new Participant { Name = "Иван", Email = "ivan@example.com" },
                Event = new Event { Title = "Семинар", Date = DateTime.Now, Format = "Офлайн" },
                IsPresent = true
            });
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}