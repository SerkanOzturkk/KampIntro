﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class IhtiyacKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı oluşturuldu");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
