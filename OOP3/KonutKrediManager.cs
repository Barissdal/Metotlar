﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {   // artık burada konut kredisi için özel hesaplama metodu yapabilirsin.
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı");
        }
    }
}