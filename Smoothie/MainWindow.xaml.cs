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

namespace Smoothie
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

        readonly string[] ingredients = { "Äpple", "Lingon", "Apelsin", "Mango", "Jordgubbar", "Blåbär", "Ananas", "Kiwi", "Persika", "Citron" };

        private void buttonMix_Click(object sender, RoutedEventArgs e)
        {
            int amountOfIngredients = Int32.Parse(textAmount.Text);

            string drink = "";
            for(int i = 0; i < amountOfIngredients; i++)
            {
                drink += ingredients[i];
            }

            textOutput.Text = $"En {drink} juice.";
        }

        private void buttonRandomize_Click(object sender, RoutedEventArgs e)
        {
            int amountOfIngredients = Int32.Parse(textAmount.Text);
            string drink = MakeMagicDrink(amountOfIngredients);

            bool toxic = IsToxic(drink);
            if (toxic)
            {
                MessageBox.Show($"Varning! En {drink} juice är giftig.");
            }

            textOutput.Text = $"En {drink} juice.";
        }

        string MakeMagicDrink(int amountOfIngredients)
        {
            if (amountOfIngredients == 0)
            {
                return "Mata in antal ingredienser";
            }

            Random rand = new();
            int randIndex;

            string prompt = "";
            for (int i = 0; i < amountOfIngredients; i++)
            {
                randIndex = rand.Next(0, ingredients.Length);
                prompt += ingredients[randIndex];
            }

            return prompt;
        }

        bool IsToxic(string drink)
            => drink.Contains("Kiwi") && drink.Contains("Lingon");
    }
}