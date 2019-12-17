using System;
using System.Collections.Generic;
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

namespace Day4
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
        List<int> passwords = new List<int>();
        IEnumerable<int> range = Enumerable.Range(372304, 474756);
        List<int> correctPasswords1 = new List<int>();
        List<int> correctPasswords2 = new List<int>();
        public bool IsThisPasswordValid() 
        {
            int numberToCompareWith = 0;
            int doubles = 0;
            foreach (int numberSequence in passwords)
            {
                string potentialPassword = numberSequence.ToString();
                foreach (char i in potentialPassword)
                {
                    string passwordCharacter = i.ToString();
                    int.TryParse(passwordCharacter, out int currentNumber);
                    if (numberToCompareWith > currentNumber)
                    {
                        return false;
                    }
                    numberToCompareWith = currentNumber;
                }
                for (int i = 0; i < (potentialPassword.Length - 1); i++)
                {
                    if (potentialPassword[i] == potentialPassword[i+1])
                    {
                        doubles++;
                    }
                }
            }
            if (doubles == 0)
            {
                return false;
            }
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            passwords.AddRange(range);
            int numberOfPossiblePasswords = 0;
            foreach (int numberSequence in passwords)
            {            
                int numberToCompareWith = 0;
                int doubles = 0;
                int numberOfTimesItDoesntDecrease = 0;
                string potentialPassword = numberSequence.ToString();
                foreach (char i in potentialPassword)
                {
                    string passwordCharacter = i.ToString();
                    int.TryParse(passwordCharacter, out int currentNumber);
                    if (numberToCompareWith <= currentNumber)
                    {
                        numberOfTimesItDoesntDecrease++;
                    }
                    numberToCompareWith = currentNumber;
                }
                for (int i = 0; i < (potentialPassword.Length - 1); i++)
                {
                    if (potentialPassword[i] == potentialPassword[i + 1])
                    {
                        doubles++;
                    }
                }
                if (doubles > 0 && numberOfTimesItDoesntDecrease == 6)
                {
                    numberOfPossiblePasswords++;
                    correctPasswords1.Add(numberSequence);
                }
            }
            txtResult.Text = numberOfPossiblePasswords.ToString();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            
            int numberOfPossiblePasswords = 0;
            foreach (int numberSequence in correctPasswords1)
            {
                int doubles = 0;
                int moreThanDoubles = 0;
                string potentialPassword = numberSequence.ToString();
                for (int i = 0; i < (potentialPassword.Length - 1); i ++)
                {
                    if (potentialPassword[i] == potentialPassword[i + 1])
                    {
                            doubles++;
                    }
                }
                for (int i = 0; i < (potentialPassword.Length - 2); i++)
                {
                    if (potentialPassword[i] == potentialPassword[i + 2] && doubles > 1)
                    {
                        moreThanDoubles++;
                    }
                }
                if (moreThanDoubles <= 1)
                {
                    numberOfPossiblePasswords++;
                    correctPasswords2.Add(numberSequence);
                }
            }
            txtResult.Text = "";
            txtResult.Text = numberOfPossiblePasswords.ToString();
        }
    }
}
