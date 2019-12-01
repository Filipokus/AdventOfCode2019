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

namespace Day1__Puzzle2
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
        List<int> fuelHistory = new List<int>();
        public int CalculateFuelNeeded(int mass)
        {
            int fuelNeeded = (mass / 3) - 2;
            fuelHistory.Add(fuelNeeded);
            return fuelNeeded;
        }
        public int CalculateTotalFuelNeeded()
        {
            int totalFuelNeeded = 0;
            foreach (int i in fuelHistory)
            {
                totalFuelNeeded += i;
            }
            return totalFuelNeeded;
        }
        public void StartCalculation() 
        {
            fuelHistory.Add(54755);
            fuelHistory.Add(96495);
            fuelHistory.Add(111504);
            fuelHistory.Add(53923);
            fuelHistory.Add(118158);
            fuelHistory.Add(118082);
            fuelHistory.Add(137413);
            fuelHistory.Add(135315);
            fuelHistory.Add(87248);
            fuelHistory.Add(127646);
            fuelHistory.Add(79201);
            fuelHistory.Add(52399);
            fuelHistory.Add(77966);
            fuelHistory.Add(129568);
            fuelHistory.Add(63880);
            fuelHistory.Add(128973);
            fuelHistory.Add(55491);
            fuelHistory.Add(111226);
            fuelHistory.Add(126447);
            fuelHistory.Add(87017);
            fuelHistory.Add(112469);
            fuelHistory.Add(83975);
            fuelHistory.Add(51280);
            fuelHistory.Add(60239);
            fuelHistory.Add(120524);
            fuelHistory.Add(57122);
            fuelHistory.Add(136517);
            fuelHistory.Add(117378);
            fuelHistory.Add(93629);
            fuelHistory.Add(55125);
            fuelHistory.Add(68990);
            fuelHistory.Add(70336);
            fuelHistory.Add(115119);
            fuelHistory.Add(68264);
            fuelHistory.Add(148122);
            fuelHistory.Add(70075);
            fuelHistory.Add(106770);
            fuelHistory.Add(54976);
            fuelHistory.Add(123852);
            fuelHistory.Add(61813);
            fuelHistory.Add(113373);
            fuelHistory.Add(53924);
            fuelHistory.Add(59660);
            fuelHistory.Add(67111);
            fuelHistory.Add(52825);
            fuelHistory.Add(81568);
            fuelHistory.Add(110842);
            fuelHistory.Add(134870);
            fuelHistory.Add(135529);
            fuelHistory.Add(78689);
            fuelHistory.Add(129451);
            fuelHistory.Add(96041);
            fuelHistory.Add(91627);
            fuelHistory.Add(70863);
            fuelHistory.Add(100098);
            fuelHistory.Add(121908);
            fuelHistory.Add(96623);
            fuelHistory.Add(143752);
            fuelHistory.Add(149936);
            fuelHistory.Add(116283);
            fuelHistory.Add(149488);
            fuelHistory.Add(126158);
            fuelHistory.Add(106499);
            fuelHistory.Add(124927);
            fuelHistory.Add(109574);
            fuelHistory.Add(70711);
            fuelHistory.Add(139078);
            fuelHistory.Add(67212);
            fuelHistory.Add(124251);
            fuelHistory.Add(123803);
            fuelHistory.Add(73569);
            fuelHistory.Add(145668);
            fuelHistory.Add(96045);
            fuelHistory.Add(59748);
            fuelHistory.Add(123238);
            fuelHistory.Add(68005);
            fuelHistory.Add(121412);
            fuelHistory.Add(97236);
            fuelHistory.Add(104800);
            fuelHistory.Add(86786);
            fuelHistory.Add(141680);
            fuelHistory.Add(123807);
            fuelHistory.Add(82310);
            fuelHistory.Add(76593);
            fuelHistory.Add(146092);
            fuelHistory.Add(82637);
            fuelHistory.Add(92339);
            fuelHistory.Add(93821);
            fuelHistory.Add(56247);
            fuelHistory.Add(58328);
            fuelHistory.Add(90159);
            fuelHistory.Add(105700);
            fuelHistory.Add(57317);
            fuelHistory.Add(69011);
            fuelHistory.Add(125544);
            fuelHistory.Add(102372);
            fuelHistory.Add(63797);
            fuelHistory.Add(92127);
            fuelHistory.Add(111207);
            fuelHistory.Add(77596);
        }
        private void btnCalculateFuel_Click(object sender, RoutedEventArgs e)
        {
            string rawMass = txtMass.Text;
            if (rawMass.Length != 0)
            {
                if (int.TryParse(rawMass, out int mass))
                {
                    int fuelNeeded = CalculateFuelNeeded(mass);
                    string result = $"For this module - {fuelNeeded} fuel is required. Calculated from {mass} mass";
                    txtFuelNeeded.Text = result;
                    lbxFuelNeeded.ItemsSource = null;
                    lbxFuelNeeded.ItemsSource = fuelHistory;
                    txtTotalFuelNeeded.Text = CalculateTotalFuelNeeded().ToString();
                    txtMass.Clear();
                }
                else
                {
                    MessageBox.Show("The mass needs to be specified as an integer, please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please specify the mass of the module first");
            }
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            fuelHistory.Clear();
            txtMass.Clear();
            txtFuelNeeded.Text = "";
            txtTotalFuelNeeded.Clear();
            lbxFuelNeeded.ItemsSource = null;
        }

        private void btnCalculatePreCodedInput_Click(object sender, RoutedEventArgs e)
        {
            StartCalculation();
        }
    }
}
