using System.Windows;

namespace Bonus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSaying_Click(object sender, RoutedEventArgs e)
        {
            List<string> actors = new List<string>()
            {
                "Ross", "Monica", "Phoebe", "Rachel", "Chandler"
            };

            List<string> attendanceList = new List<string>
            {
                "Ross", "Monica", "Phoebe", "Rachel", "Chandler",
                "Chandler", "Rachel", "Monica", "Ross", "Phoebe",
                "Ross", "Phoebe", "Rachel", "Monica", "Chandler",
                "Ross", "Rachel", "Phoebe", "Chandler", "Monica",
                "Phoebe", "Ross", "Chandler", "Monica", "Rachel",
                "Rachel", "Monica", "Phoebe", "Chandler", "Ross",
                "Ross", "Phoebe", "Rachel", "Monica", "Chandler",
                "Phoebe", "Ross", "Chandler", "Monica", "Rachel",
                "Monica", "Phoebe", "Ross", "Chandler", "Rachel",
                "Chandler", "Ross", "Rachel", "Monica", "Rachel",
                "Ross", "Monica", "Rachel", "Phoebe", "Chandler",
                "Ross", "Rachel", "Monica", "Chandler", "Phoebe",
                "Monica", "Chandler", "Rachel", "Ross", "Phoebe",
                "Phoebe", "Ross", "Monica", "Rachel", "Chandler",
                "Chandler", "Phoebe", "Rachel", "Monica", "Ross",
                "Monica", "Chandler", "Rachel", "Ross", "Phoebe",
                "Ross", "Phoebe", "Rachel", "Monica", "Chandler",
                "Rachel", "Chandler", "Ross", "Phoebe", "Monica",
                "Monica", "Rachel", "Phoebe", "Chandler", "Ross",
                "Phoebe", "Monica", "Chandler", "Rachel", "Ross"
            };

            int ross = 0;
            int monica = 0;
            int phoebe = 0;
            int rachel = 0;
            int chandler = 0;

            foreach (string attendee in attendanceList)
            {
                switch (attendee)
                {
                    case ("Ross"):
                        ross++;
                        break;
                    case ("Monica"):               
                        monica++;
                        break; 
                    case ("Phoebe"):
                        phoebe++;
                        break;
                    case ("Rachel"):
                        rachel++;
                        break;
                    case ("Chandler"):
                        chandler++;
                        break;
                }
            }

            string prompt = "";

            if (ross != 20) prompt += $"Ross: {ross} ";
            if (monica != 20) prompt += $"Monica: {monica} ";
            if (phoebe != 20) prompt += $"Phoebe: {phoebe} ";
            if (rachel != 20) prompt += $"Rachel: {rachel} ";
            if (chandler != 20) prompt += $"Chandler: {chandler} ";

            MessageBox.Show(prompt);
        }
    }
}