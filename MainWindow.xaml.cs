/* Dylan Broad
 * 2/19/2020
 * Computer Parts Assignment
 */
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

namespace computerparts
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




        private void LblComputer_Unchecked(object sender, RoutedEventArgs e)
        {
            lblCPU.Visibility = Visibility.Collapsed;
            lblmotherboard.Visibility = Visibility.Collapsed;
            lblram.Visibility = Visibility.Collapsed;
            lblSSD.Visibility = Visibility.Collapsed;
            lblHardDrive.Visibility = Visibility.Collapsed;
            lblCase.Visibility = Visibility.Collapsed;
            lblpowersupply.Visibility = Visibility.Collapsed;
            lblGPU.Visibility = Visibility.Collapsed;
            lblopticaldrive.Visibility = Visibility.Collapsed;
            lblfinalprice.Visibility = Visibility.Collapsed;
            lblCFPinfo.Visibility = Visibility.Collapsed;
            lblFinalPriceinfo.Visibility = Visibility.Collapsed;
        }

        private void lblCPU_Unchecked(object sender, RoutedEventArgs e)
        {
            lblInfoCPU.Visibility = Visibility.Collapsed;
        }

        private void lblmotherboard_Checked(object sender, RoutedEventArgs e)
        {
            lblmotherboardinfo.Visibility = Visibility.Visible;
        }

        private void lblmotherboard_Unchecked(object sender, RoutedEventArgs e)
        {
            lblmotherboardinfo.Visibility = Visibility.Collapsed;
        }

        private void lblram_Unchecked(object sender, RoutedEventArgs e)
        {
            lblraminfo.Visibility = Visibility.Collapsed;
        }

        private void lblram_Checked(object sender, RoutedEventArgs e)
        {
            lblraminfo.Visibility = Visibility.Visible;
        }

        private void lblSSD_Unchecked(object sender, RoutedEventArgs e)
        {
            lblSSDinfo.Visibility = Visibility.Collapsed;
        }

        private void lblSSD_Checked(object sender, RoutedEventArgs e)
        {
            lblSSDinfo.Visibility = Visibility.Visible;
        }

        private void lblHardDrive_Unchecked(object sender, RoutedEventArgs e)
        {
            lblHardDriveInfo.Visibility = Visibility.Collapsed;
        }

        private void lblHardDrive_Checked(object sender, RoutedEventArgs e)
        {
            lblHardDriveInfo.Visibility = Visibility.Visible;
        }

        private void lblCase_Unchecked(object sender, RoutedEventArgs e)
        {
            lblCaseInfo.Visibility = Visibility.Collapsed;
        }

        private void lblCase_Checked(object sender, RoutedEventArgs e)
        {
            lblCaseInfo.Visibility = Visibility.Visible;
        }

        private void lblComputer_Checked_1(object sender, RoutedEventArgs e)
        {
            lblCPU.Visibility = Visibility.Visible;
            lblmotherboard.Visibility = Visibility.Visible;
            lblram.Visibility = Visibility.Visible;
            lblSSD.Visibility = Visibility.Visible;
            lblHardDrive.Visibility = Visibility.Visible;
            lblCase.Visibility = Visibility.Visible;
            lblpowersupply.Visibility = Visibility.Visible;
            lblGPU.Visibility = Visibility.Visible;
            lblopticaldrive.Visibility = Visibility.Visible;
            lblfinalprice.Visibility = Visibility.Visible;
        }

        private void lblCPU_Checked_1(object sender, RoutedEventArgs e)
        {
            lblInfoCPU.Visibility = Visibility.Visible;
        }

        private void lblpowersupply_Unchecked(object sender, RoutedEventArgs e)
        {
            lblpowersupplyinfo.Visibility = Visibility.Collapsed;
        }

        private void lblpowersupply_Checked(object sender, RoutedEventArgs e)
        {
            lblpowersupplyinfo.Visibility = Visibility.Visible;
        }

        private void lblGPU_Unchecked(object sender, RoutedEventArgs e)
        {
            lblGPUinfo.Visibility = Visibility.Collapsed;
        }

        private void lblGPU_Checked(object sender, RoutedEventArgs e)
        {
            lblGPUinfo.Visibility = Visibility.Visible;
        }

        private void lblopticaldrive_Checked(object sender, RoutedEventArgs e)
        {
            lblopticaldriveinfo.Visibility = Visibility.Visible;
        }

        private void lblopticaldrive_Unchecked(object sender, RoutedEventArgs e)
        {
            lblopticaldriveinfo.Visibility = Visibility.Collapsed;
        }

        private void lblfinalprice_Checked(object sender, RoutedEventArgs e)
        {
            lblFinalPriceinfo.Visibility = Visibility.Visible;
            lblCalculateFinalPrice.Visibility = Visibility.Visible;
            lblCFPinfo.Visibility = Visibility.Visible;
        }

        private void lblfinalprice_Unchecked(object sender, RoutedEventArgs e)
        {
            lblFinalPriceinfo.Visibility = Visibility.Collapsed;
            lblCalculateFinalPrice.Visibility = Visibility.Collapsed;
            lblCFPinfo.Content = null;
     

        }

        private void lblCalculateFinalPrice_Click(object sender, RoutedEventArgs e)
        {
            double sub;
            double total;
            sub = 931.73;
            total = sub * 1.13;
            lblCFPinfo.Content = "Total: " + total.ToString("#.00");
            


        }
    }
}
