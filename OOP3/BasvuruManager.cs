using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {   // burada interface i parametre olarak gönderdiğimiz için başvuruyu kredi türünden bağımısz yaptık.
        // Buraya hangi kredi turunu gönderirsek o kredi turunun referans numarası çalışacaktır
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            //loggerService.Log();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
