using stok.Model;
using stok.ViewModel;
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

namespace stok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<SonucSatiri> sonucSatiris = new List<SonucSatiri>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MyViewModel();
            sonucSatiris.Add(new SonucSatiri { Name = "Arpa", HamProtein = 11.5, HamKuruMadde = 2.5, NDF = 0.8 });
            sonucSatiris.Add(new SonucSatiri { Name = "Yonca", HamProtein = 17.0, HamKuruMadde = 16.0, NDF = 2.5 });
            sonucSatiris.Add(new SonucSatiri { Name = "Mısır", HamProtein = 9.0, HamKuruMadde = 3.5, NDF = 1.3 });
            sonucSatiris.Add(new SonucSatiri { Name = "Buğday", HamProtein = 12.0, HamKuruMadde = 2.0, NDF = 1.0 });
            sonucSatiris.Add(new SonucSatiri { Name = "Fiğ", HamProtein = 24.0, HamKuruMadde = 20.0, NDF = 2.0 });
            sonucSatiris.Add(new SonucSatiri { Name = "Soya Fasulyesi", HamProtein = 37.0, HamKuruMadde = 13.0, NDF = 2.5 });
            sonucSatiris.Add(new SonucSatiri { Name = "Pamuk Tohumu", HamProtein = 22.0, HamKuruMadde = 11.0, NDF = 1.0 });
            sonucSatiris.Add(new SonucSatiri { Name = "Saman", HamProtein = 4.0, HamKuruMadde = 90.0, NDF = 63.0 });
            sonucSatiris.Add(new SonucSatiri { Name = "Kaba Yem", HamProtein = 8.0, HamKuruMadde = 20.0, NDF = 50.0 });
            sonucSatiris.Add(new SonucSatiri { Name = "Kuru Ot", HamProtein = 10.0, HamKuruMadde = 90.0, NDF = 55.0 });
            sonucSatiris.Add(new SonucSatiri { Name = "Fişek Ot", HamProtein = 8.0, HamKuruMadde = 25.0, NDF = 60.0 });
            sonucSatiris.Add(new SonucSatiri { Name = "Yulaf", HamProtein = 13.0, HamKuruMadde = 3.5, NDF = 1.0 });
            sonucSatiris.Add(new SonucSatiri { Name = "Üzüm Posası", HamProtein = 4.0, HamKuruMadde = 25.0, NDF = 55.0 });
            sonucSatiris.Add(new SonucSatiri { Name = "Patates", HamProtein = 1.5, HamKuruMadde = 20.0, NDF = 12.0 });
            sonucSatiris.Add(new SonucSatiri { Name = "Pirinç Kabuğu", HamProtein = 5.0, HamKuruMadde = 15.0, NDF = 45.0 });
            sonucSatiris.Add(new SonucSatiri { Name = "Kepek", HamProtein = 13.0, HamKuruMadde = 15.0, NDF = 40.0 });
            sonucSatiris.Add(new SonucSatiri { Name = "Yonca Küspesi", HamProtein = 14.0, HamKuruMadde = 16.0, NDF = 30.0 });
            sonucSatiris.Add(new SonucSatiri { Name = "Borungu Ot", HamProtein = 3.0, HamKuruMadde = 15.0, NDF = 70.0 });
        }
        

        private void cmbOptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(cmbOptions.SelectedItem.ToString());  
        }

        List<RasyonSatiri> rasyonSatirlari = new List<RasyonSatiri>();
        private void ekle_Button_Click(object sender, RoutedEventArgs e)
        {
           
            rasyonSatirlari.Add(new RasyonSatiri { YemAdi = cmbOptions.Text});
            GuncelleGrid(); 
        }
        private void GuncelleGrid()
        {
            data_grid.ItemsSource = null;
            data_grid.ItemsSource = rasyonSatirlari;
        }
      
        private void hesapla_Button_Click(object sender, RoutedEventArgs e)
        {
            List<SonucSatiri> sonucSatirlari = new List<SonucSatiri>();
            foreach (var b in rasyonSatirlari)
            {

                foreach (var a in sonucSatiris)
                {
                    if(a.Name == b.YemAdi)
                    {
                        sonucSatirlari.Add(new SonucSatiri { Name= a.Name, HamProtein= a.HamProtein, HamKuruMadde=a.HamKuruMadde, NDF = a.NDF }); 
                    }
                }
            }
            data_grid_sonuc.ItemsSource= sonucSatirlari;
        }
       
    }
}
