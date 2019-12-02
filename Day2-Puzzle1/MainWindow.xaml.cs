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

namespace Day2_Puzzle1
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
        public List<int> opcodeList = new List<int>();
        public void AddToList()
        {
            opcodeList.Add(1);
            opcodeList.Add(53);
            opcodeList.Add(98);
            opcodeList.Add(3);
            opcodeList.Add(1);
            opcodeList.Add(1);
            opcodeList.Add(2);
            opcodeList.Add(3);
            opcodeList.Add(1);
            opcodeList.Add(3);
            opcodeList.Add(4);
            opcodeList.Add(3);
            opcodeList.Add(1);
            opcodeList.Add(5);
            opcodeList.Add(0);
            opcodeList.Add(3);
            opcodeList.Add(2);
            opcodeList.Add(6);
            opcodeList.Add(1);
            opcodeList.Add(19);
            opcodeList.Add(2);
            opcodeList.Add(19);
            opcodeList.Add(9);
            opcodeList.Add(23);
            opcodeList.Add(1);
            opcodeList.Add(23);
            opcodeList.Add(5);
            opcodeList.Add(27);
            opcodeList.Add(2);
            opcodeList.Add(6);
            opcodeList.Add(27);
            opcodeList.Add(31);
            opcodeList.Add(1);
            opcodeList.Add(31);
            opcodeList.Add(5);
            opcodeList.Add(35);
            opcodeList.Add(1);
            opcodeList.Add(35);
            opcodeList.Add(5);
            opcodeList.Add(39);
            opcodeList.Add(2);
            opcodeList.Add(39);
            opcodeList.Add(6);
            opcodeList.Add(43);
            opcodeList.Add(2);
            opcodeList.Add(43);
            opcodeList.Add(10);
            opcodeList.Add(47);
            opcodeList.Add(1);
            opcodeList.Add(47);
            opcodeList.Add(6);
            opcodeList.Add(51);
            opcodeList.Add(1);
            opcodeList.Add(51);
            opcodeList.Add(6);
            opcodeList.Add(55);
            opcodeList.Add(2);
            opcodeList.Add(55);
            opcodeList.Add(6);
            opcodeList.Add(59);
            opcodeList.Add(1);
            opcodeList.Add(10);
            opcodeList.Add(59);
            opcodeList.Add(63);
            opcodeList.Add(1);
            opcodeList.Add(5);
            opcodeList.Add(63);
            opcodeList.Add(67);
            opcodeList.Add(2);
            opcodeList.Add(10);
            opcodeList.Add(67);
            opcodeList.Add(71);
            opcodeList.Add(1);
            opcodeList.Add(6);
            opcodeList.Add(71);
            opcodeList.Add(75); 
            opcodeList.Add(1);
            opcodeList.Add(5);
            opcodeList.Add(75);
            opcodeList.Add(79);
            opcodeList.Add(1);
            opcodeList.Add(10);
            opcodeList.Add(79);
            opcodeList.Add(83);
            opcodeList.Add(2);
            opcodeList.Add(83);
            opcodeList.Add(10);
            opcodeList.Add(87);
            opcodeList.Add(1);
            opcodeList.Add(87);
            opcodeList.Add(9);
            opcodeList.Add(91);
            opcodeList.Add(1);
            opcodeList.Add(91);
            opcodeList.Add(10);
            opcodeList.Add(95);
            opcodeList.Add(2);
            opcodeList.Add(6);
            opcodeList.Add(95);
            opcodeList.Add(99);
            opcodeList.Add(1);
            opcodeList.Add(5);
            opcodeList.Add(99);
            opcodeList.Add(103);
            opcodeList.Add(1);
            opcodeList.Add(103);
            opcodeList.Add(13);
            opcodeList.Add(107);
            opcodeList.Add(1);
            opcodeList.Add(107);
            opcodeList.Add(10);
            opcodeList.Add(111);
            opcodeList.Add(2);
            opcodeList.Add(9);
            opcodeList.Add(111);
            opcodeList.Add(115);
            opcodeList.Add(1);
            opcodeList.Add(115);
            opcodeList.Add(6);
            opcodeList.Add(119);
            opcodeList.Add(2);
            opcodeList.Add(13);
            opcodeList.Add(119);
            opcodeList.Add(123);
            opcodeList.Add(1);
            opcodeList.Add(123);
            opcodeList.Add(6);
            opcodeList.Add(127);
            opcodeList.Add(1);
            opcodeList.Add(5);
            opcodeList.Add(127);
            opcodeList.Add(131);
            opcodeList.Add(2);
            opcodeList.Add(6);
            opcodeList.Add(131);
            opcodeList.Add(135);
            opcodeList.Add(2);
            opcodeList.Add(6);
            opcodeList.Add(135);
            opcodeList.Add(139);
            opcodeList.Add(1);
            opcodeList.Add(139);
            opcodeList.Add(5);
            opcodeList.Add(143);
            opcodeList.Add(1);
            opcodeList.Add(143);
            opcodeList.Add(10);
            opcodeList.Add(147);
            opcodeList.Add(1);
            opcodeList.Add(147);
            opcodeList.Add(2);
            opcodeList.Add(151);
            opcodeList.Add(1);
            opcodeList.Add(151);
            opcodeList.Add(13);
            opcodeList.Add(0);
            opcodeList.Add(99);
            opcodeList.Add(2);
            opcodeList.Add(0);
            opcodeList.Add(14);
            opcodeList.Add(0);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddToList();
            for (int i = 0; i < opcodeList.Count; i+=4)
            {
                int noun = opcodeList[1];
                int verb = opcodeList[2];
                if (opcodeList[i] == 1)
                {
                    int firstPosition = opcodeList[i + 1];
                    int secondPosition = opcodeList[i + 2];
                    int outputPosition = opcodeList[i + 3];
                    int firstInteger = opcodeList[firstPosition];
                    int secondInteger = opcodeList[secondPosition];
                    int output = firstInteger + secondInteger;
                    opcodeList[outputPosition] = output;
                }
                else if (opcodeList[i] == 2)
                {
                    int firstPosition = opcodeList[i + 1];
                    int secondPosition = opcodeList[i + 2];
                    int outputPosition = opcodeList[i + 3];
                    int firstInteger = opcodeList[firstPosition];
                    int secondInteger = opcodeList[secondPosition];
                    int output = firstInteger * secondInteger;
                    opcodeList[outputPosition] = output;
                }
                else
                {
                    i = opcodeList.Count + 1;
                }
            }
            txtResult.Text = opcodeList[0].ToString();
        }
    }
}
