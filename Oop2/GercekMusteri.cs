using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{   
    // Individual
    // miras - inheratence yani gerçek müşteri müşteri dir diye belirtiyoruz.
    class GercekMusteri:Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
