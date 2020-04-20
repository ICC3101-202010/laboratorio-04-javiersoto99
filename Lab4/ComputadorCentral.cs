using System;

namespace Lab4
{
    public class ComputadorCentral
    {
        public static void Reinicio(Maquina maquina)
        {
            maquina.Reinicio();
        }

        public static void ReinicioManual(string maquinaMala , Maquina re , Maquina al , Maquina ens , Maquina ver , Maquina emp)
        {
            Console.WriteLine("Memoria maxima alcanzada en Maquina de " + maquinaMala) ;
            Console.WriteLine("Que maquina desea reiniciar: ");
            Console.WriteLine("1.- Recepcion");
            Console.WriteLine("2.- Almacenamiento");
            Console.WriteLine("3.- Ensamblaje");
            Console.WriteLine("4.- Verificacion");
            Console.WriteLine("5.- Empaque");

            int maquinaReini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            if(maquinaReini == 1)
            {
                re.Reinicio();
            }
            else if(maquinaReini == 2)
            {
                al.Reinicio();
            }
             else if(maquinaReini == 3)
            {
                ens.Reinicio();
            }
             else if(maquinaReini == 4)
            {
                ver.Reinicio();
            }
             else if(maquinaReini == 5)
            {
                emp.Reinicio();
            }



        }

         

    }
}
