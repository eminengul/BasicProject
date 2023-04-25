using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok.Model
{
    internal class MyModel
    {
    }
    public class Option
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class RasyonSatiri
    {
        public string YemAdi { get; set; }
    }

    public class SonucSatiri
    {
        public string Name { get; set; }    
        public double HamProtein { get; set; }
        public double HamKuruMadde { get; set; }
        public double NDF { get; set; }
    }
}
