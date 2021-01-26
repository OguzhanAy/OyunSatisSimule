using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisSimule
{
    class PasswordVerification : IVerificationService
    {
        public void Dogrula()
        {
            Console.WriteLine("Oyuncu şifresi ile doğrulama yaptı.");
        }
    }
}
