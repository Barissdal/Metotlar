using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // eğerki birisi bu interface i kullanırsa o Hesapla metodunu içermelidir.
    // interface ler I harfi ile başlar.
    // interface = şablon
    // ***birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    // tüm kredilerde hesaplama metodu vardır ama hesaplamaları farklıdır faiz oranı vb. sebeplerden
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
