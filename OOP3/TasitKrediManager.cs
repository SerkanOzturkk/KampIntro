﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class TasitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Tasit kredisi ödeme planı oluşturuldu");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
