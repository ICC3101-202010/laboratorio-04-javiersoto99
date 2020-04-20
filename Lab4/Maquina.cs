using System;

namespace Lab4
{
    public abstract class Maquina
    {
       

        public string nombreMaquina;
        public int memoriaUsada = 0;
        public int memoriaMax;
        public int peso;
        

        public abstract void Encendido();
        public virtual void Reinicio()
        {
            
            memoriaUsada = 0;
            
        }
        
        public abstract void Apagado();



        public void UsoMemoria()
        {
            memoriaUsada += peso;
        }

        public int MemoriaMaximaAlcanzada()
        {
            if (memoriaUsada == memoriaMax)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}



