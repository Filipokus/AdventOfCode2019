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

namespace Day1_Puzzle02
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
            return fuelNeeded;
        }
        public void AddFuelToFuelHistory(int rawFuelToAdd)
        {
            int fuelToAdd = CalculateFuelNeeded(rawFuelToAdd);
            fuelHistory.Add(fuelToAdd);
        }
        public int CalculateTotalFuelNeeded()
        {
            int totalFuelNeeded = 0;
            foreach (int i in fuelHistory)
            {
                totalFuelNeeded += i;
                int fuelForFuel = i;
                for (int test = 0; test < ((fuelForFuel / 3) - 2); CalculateFuelNeeded(fuelForFuel))
                {
                    fuelForFuel = (fuelForFuel / 3) - 2;
                    totalFuelNeeded += fuelForFuel;
                }
            }
            return totalFuelNeeded;
        }
        public void StartCalculation()
        {
            AddFuelToFuelHistory(54755);
            AddFuelToFuelHistory(96495);
            AddFuelToFuelHistory(111504);
            AddFuelToFuelHistory(53923);
            AddFuelToFuelHistory(118158);
            AddFuelToFuelHistory(118082);
            AddFuelToFuelHistory(137413);
            AddFuelToFuelHistory(135315);
            AddFuelToFuelHistory(87248);
            AddFuelToFuelHistory(127646);
            AddFuelToFuelHistory(79201);
            AddFuelToFuelHistory(52399);
            AddFuelToFuelHistory(77966);
            AddFuelToFuelHistory(129568);
            AddFuelToFuelHistory(63880);
            AddFuelToFuelHistory(128973);
            AddFuelToFuelHistory(55491);
            AddFuelToFuelHistory(111226);
            AddFuelToFuelHistory(126447);
            AddFuelToFuelHistory(87017);
            AddFuelToFuelHistory(112469);
            AddFuelToFuelHistory(83975);
            AddFuelToFuelHistory(51280);
            AddFuelToFuelHistory(60239);
            AddFuelToFuelHistory(120524);
            AddFuelToFuelHistory(57122);
            AddFuelToFuelHistory(136517);
            AddFuelToFuelHistory(117378);
            AddFuelToFuelHistory(93629);
            AddFuelToFuelHistory(55125);
            AddFuelToFuelHistory(68990);
            AddFuelToFuelHistory(70336);
            AddFuelToFuelHistory(115119);
            AddFuelToFuelHistory(68264);
            AddFuelToFuelHistory(148122);
            AddFuelToFuelHistory(70075);
            AddFuelToFuelHistory(106770);
            AddFuelToFuelHistory(54976);
            AddFuelToFuelHistory(123852);
            AddFuelToFuelHistory(61813);
            AddFuelToFuelHistory(113373);
            AddFuelToFuelHistory(53924);
            AddFuelToFuelHistory(59660);
            AddFuelToFuelHistory(67111);
            AddFuelToFuelHistory(52825);
            AddFuelToFuelHistory(81568);
            AddFuelToFuelHistory(110842);
            AddFuelToFuelHistory(134870);
            AddFuelToFuelHistory(135529);
            AddFuelToFuelHistory(78689);
            AddFuelToFuelHistory(129451);
            AddFuelToFuelHistory(96041);
            AddFuelToFuelHistory(91627);
            AddFuelToFuelHistory(70863);
            AddFuelToFuelHistory(100098);
            AddFuelToFuelHistory(121908);
            AddFuelToFuelHistory(96623);
            AddFuelToFuelHistory(143752);
            AddFuelToFuelHistory(149936);
            AddFuelToFuelHistory(116283);
            AddFuelToFuelHistory(149488);
            AddFuelToFuelHistory(126158);
            AddFuelToFuelHistory(106499);
            AddFuelToFuelHistory(124927);
            AddFuelToFuelHistory(109574);
            AddFuelToFuelHistory(70711);
            AddFuelToFuelHistory(139078);
            AddFuelToFuelHistory(67212);
            AddFuelToFuelHistory(124251);
            AddFuelToFuelHistory(123803);
            AddFuelToFuelHistory(73569);
            AddFuelToFuelHistory(145668);
            AddFuelToFuelHistory(96045);
            AddFuelToFuelHistory(59748);
            AddFuelToFuelHistory(123238);
            AddFuelToFuelHistory(68005);
            AddFuelToFuelHistory(121412);
            AddFuelToFuelHistory(97236);
            AddFuelToFuelHistory(104800);
            AddFuelToFuelHistory(86786);
            AddFuelToFuelHistory(141680);
            AddFuelToFuelHistory(123807);
            AddFuelToFuelHistory(82310);
            AddFuelToFuelHistory(76593);
            AddFuelToFuelHistory(146092);
            AddFuelToFuelHistory(82637);
            AddFuelToFuelHistory(92339);
            AddFuelToFuelHistory(93821);
            AddFuelToFuelHistory(56247);
            AddFuelToFuelHistory(58328);
            AddFuelToFuelHistory(90159);
            AddFuelToFuelHistory(105700);
            AddFuelToFuelHistory(57317);
            AddFuelToFuelHistory(69011);
            AddFuelToFuelHistory(125544);
            AddFuelToFuelHistory(102372);
            AddFuelToFuelHistory(63797);
            AddFuelToFuelHistory(92127);
            AddFuelToFuelHistory(111207);
            AddFuelToFuelHistory(77596);
        }
        private void btnCalculateFuel_Click(object sender, RoutedEventArgs e)
        {
            string rawMass = txtMass.Text;
            if (rawMass.Length != 0)
            {
                if (int.TryParse(rawMass, out int mass))
                {
                    int fuelNeeded = CalculateFuelNeeded(mass);
                    fuelHistory.Add(fuelNeeded);
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
            txtFuelNeeded.Text ="";
            txtTotalFuelNeeded.Clear();
            lbxFuelNeeded.ItemsSource = null;
        }

        private void btnCalculatePreCodedInput_Click(object sender, RoutedEventArgs e)
        {
            StartCalculation();
            lbxFuelNeeded.ItemsSource = null;
            lbxFuelNeeded.ItemsSource = fuelHistory;
            txtTotalFuelNeeded.Text = CalculateTotalFuelNeeded().ToString();
        }
    }
}
