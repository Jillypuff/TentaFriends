using System.Windows;

namespace Friends
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

        Lingo lingo = new();
        //Random rand = new();

        private void buttonSaying_Click(object sender, RoutedEventArgs e)
        {
            //int random = rand.Next(0, lingo.Sayings.Count);
            //string sentence = lingo.Sayings[random].Sentence;
            //string acronyme = lingo.Sayings[random].Acronyme;
            //int acronymeSum = lingo.Sayings[random].CalculateAcronymeSum();

            //string prompt = $"Ordspråket \"{sentence}\" förkortas" +
            //    $"\"{acronyme}\" och är värt {acronymeSum} poäng.";

            //MessageBox.Show(prompt);

            string prompt = FindPerfectSaying();
            MessageBox.Show(prompt);
        }

        string FindPerfectSaying()
        {
            string prompt = "Enligt noggranna studier är det bästa ordspråket: ";
            foreach (Saying saying in lingo.Sayings)
            {
                if (saying.IsPerfect)
                {
                    prompt += saying.Sentence;
                    break;
                }
            }

            prompt += "!";
            return prompt;
        }
    }
}