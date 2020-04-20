using System;

namespace Lab4
{
    public class Empaque : Maquina
    {
        public Empaque(string nombre, int memoriaMax, int peso)
        {
            this.nombreMaquina = nombre;
            this.memoriaMax = memoriaMax;
            this.peso = peso;


        }

        public override void Apagado()
        {
            Console.WriteLine("Maquina de " + nombreMaquina + " : OFF");
        }

        public override void Encendido()
        {

            Console.WriteLine("Maquina de " + nombreMaquina + " : ON");
            Console.WriteLine("Memoria disponible:" + memoriaMax);

        }

        public override void Reinicio()
        {
            base.Reinicio();
            Console.WriteLine("Memoria maxima alcanzada en Maquina de " + nombreMaquina );
            Console.WriteLine("Maquina de " + nombreMaquina + " : REINICIADA");
        }

    }
}
