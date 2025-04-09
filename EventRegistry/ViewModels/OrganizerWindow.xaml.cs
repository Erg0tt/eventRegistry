using EventRegistrationApp;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace EventRegistrationApp
{
    public partial class OrganizerWindow : Window
    {
        public ObservableCollection<Event> Events { get; set; } = new ObservableCollection<Event>();

        public OrganizerWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void AddEventButton_Click(object sender, RoutedEventArgs e)
        {
            Events.Add(new Event
            {
                Title = TitleTextBox.Text,
                Date = EventDatePicker.SelectedDate ?? DateTime.Today,
                Format = FormatComboBox.Text
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
