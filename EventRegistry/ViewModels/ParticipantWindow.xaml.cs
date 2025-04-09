
using System.Collections.ObjectModel;
using System.Windows;

namespace EventRegistrationApp
{
    public partial class ParticipantWindow : Window
    {
        public ObservableCollection<Participant> Participants { get; set; } = new ObservableCollection<Participant>();

        public ParticipantWindow()
        {
            InitializeComponent();
            DataContext = this;
        }


        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Participants.Add(new Participant
            {
                Name = NameTextBox.Text,
                Email = EmailTextBox.Text,
                IsConfirmed = ConfirmCheckBox.IsChecked == true
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