﻿using System;
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

namespace Day1
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
        public int CalculateFuelNeeded(int mass)
        {
            int fuelNeeded = (mass / 3) - 2;
            return fuelNeeded;
        }

        private void btnCalculateFuel_Click(object sender, RoutedEventArgs e)
        {
            string rawMass = txtMass.Text;
            if (rawMass.Length != 0)
            {
                if (int.TryParse(rawMass, out int mass))
                {
                    int fuelNeeded = CalculateFuelNeeded(mass);
                    string result = $"For this module - {fuelNeeded} fuel is required";
                    txtFuelNeeded.Text = result;
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
    }
}
