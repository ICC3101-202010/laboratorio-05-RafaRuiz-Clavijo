using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Solucion_Lab_21_abril
{
    //Parte2
    public class User
    {
        public delegate void EmailVerifyEventHandler(object source, EventArgs args);
        public event EmailVerifyEventHandler EmailVerified;

        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, new EventArgs());
            }
        }

        public void OnEmailSent(object source, EventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Quiere verificar su correo?");
            Console.WriteLine("1) Si");
            Console.WriteLine("2) No");
            Console.Write("Elija opcion con un numero: ");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Console.WriteLine();
                OnEmailVerified();
            }

        }
    }
}
