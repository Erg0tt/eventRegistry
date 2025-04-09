using System.Windows;

namespace EventRegistrationApp
{
    public partial class MainWindow : Window
    {
     
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OrganizerButton_Click(object sender, RoutedEventArgs e)
        {
            new OrganizerWindow().Show();
            Close();
        }

        private void ParticipantButton_Click(object sender, RoutedEventArgs e)
        {
            new ParticipantWindow().Show();
            Close();
        }

        private void RegistrarButton_Click(object sender, RoutedEventArgs e)
        {
            new RegistrarWindow().Show();
            Close();
        }
    }
}