using System;

namespace Lab4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int hora = 8;
            int min = 0;
            Maquina maquinaRe = new Recepcion("Recepcion", 6, 1);
            Maquina maquinaAl = new Almacenamiento("Almacenamiento", 24, 4);
            Maquina maquinaEns = new Ensamblaje("Ensamblaje", 10, 2);
            Maquina maquinaVer = new Verificacion("Verificacion", 10, 1);
            Maquina maquinaEmp = new Empaque("Empaque", 7, 1);
            
            Console.WriteLine(hora + ":0" + min + ":00 - Abrimos!");
            Console.WriteLine("\n");
            Console.WriteLine("Desea Trabajar Manualmente las maquinas?");
            Console.WriteLine("1.- Si");
            Console.WriteLine("2.- No");
            int metodo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            
            maquinaRe.Encendido();
            maquinaAl.Encendido();
            maquinaEns.Encendido();
            maquinaVer.Encendido();
            maquinaEmp.Encendido();
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            if(metodo == 1 || metodo == 2)
            {
                if(metodo == 1)
                {
                    Console.WriteLine("Ha seleccionado el Metodo Manual");
                    Console.WriteLine("\n");
                    while (hora != 17)
                    {

                        if (min == 60)
                        {
                            min = 0;
                            hora++;
                            Console.WriteLine(hora + ":0" + min + ":00");
                            min += 10;
                        }
                        else
                        {
                            Console.WriteLine(hora + ":" + min + ":00");
                            min += 10;
                        }

                        //Maquina Recepcion
                        maquinaRe.UsoMemoria();
                        if (maquinaRe.MemoriaMaximaAlcanzada() == 1)
                        {

                            ComputadorCentral.ReinicioManual("Recepcion", maquinaRe, maquinaAl,maquinaEns,maquinaVer,maquinaEmp);
                        }

                        //Maquina Almacenamiento
                        maquinaAl.UsoMemoria();
                        if (maquinaAl.MemoriaMaximaAlcanzada() == 1)
                        {

                            ComputadorCentral.ReinicioManual("Almacenamiento", maquinaRe, maquinaAl, maquinaEns, maquinaVer, maquinaEmp);
                        }

                        //Maquina Ensamblaje
                        maquinaEns.UsoMemoria();
                        if (maquinaEns.MemoriaMaximaAlcanzada() == 1)
                        {
                            ComputadorCentral.ReinicioManual("Ensamblaje", maquinaRe, maquinaAl, maquinaEns, maquinaVer, maquinaEmp);
                        }

                        //Maquina Verificacion
                        maquinaVer.UsoMemoria();
                        if (maquinaVer.MemoriaMaximaAlcanzada() == 1)
                        {
                            ComputadorCentral.ReinicioManual("Verificacion", maquinaRe, maquinaAl, maquinaEns, maquinaVer, maquinaEmp);
                        }

                        //Maquina Empaque
                        maquinaEmp.UsoMemoria();
                        if (maquinaEmp.MemoriaMaximaAlcanzada() == 1)
                        {
                            ComputadorCentral.ReinicioManual("Empaque", maquinaRe, maquinaAl, maquinaEns, maquinaVer, maquinaEmp);
                        }




                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("Son las 17:00 ... Hora de apagar las Maquinas");
                    Console.WriteLine("\n");
                    maquinaRe.Apagado();
                    maquinaAl.Apagado();
                    maquinaEns.Apagado();
                    maquinaVer.Apagado();
                    maquinaEmp.Apagado();
                    Console.WriteLine("\n");
                    Console.WriteLine("Todas las maquinas apagadas ... Hasta mañana!");
                }
                else if(metodo == 2)
                {
                    Console.WriteLine("Ha seleccionado el Metodo Automatico");
                    Console.WriteLine("\n");
                    while (hora != 17)
                    {

                        if (min == 60)
                        {
                            min = 0;
                            hora++;
                            Console.WriteLine(hora + ":0" + min + ":00");
                            min += 10;
                        }
                        else
                        {
                            Console.WriteLine(hora + ":" + min + ":00");
                            min += 10;
                        }

                        //Maquina Recepcion
                        maquinaRe.UsoMemoria();
                        if (maquinaRe.MemoriaMaximaAlcanzada() == 1)
                        {
                            ComputadorCentral.Reinicio(maquinaRe);
                        }

                        //Maquina Almacenamiento
                        maquinaAl.UsoMemoria();
                        if (maquinaAl.MemoriaMaximaAlcanzada() == 1)
                        {
                            ComputadorCentral.Reinicio(maquinaAl);
                        }

                        //Maquina Ensamblaje
                        maquinaEns.UsoMemoria();
                        if (maquinaEns.MemoriaMaximaAlcanzada() == 1)
                        {
                            ComputadorCentral.Reinicio(maquinaEns);
                        }

                        //Maquina Verificacion
                        maquinaVer.UsoMemoria();
                        if (maquinaVer.MemoriaMaximaAlcanzada() == 1)
                        {
                            ComputadorCentral.Reinicio(maquinaVer);
                        }

                        //Maquina Empaque
                        maquinaEmp.UsoMemoria();
                        if (maquinaEmp.MemoriaMaximaAlcanzada() == 1)
                        {
                            ComputadorCentral.Reinicio(maquinaEmp);
                        }




                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("Son las 17:00 ... Hora de apagar las Maquinas");
                    Console.WriteLine("\n");
                    maquinaRe.Apagado();
                    maquinaAl.Apagado();
                    maquinaEns.Apagado();
                    maquinaVer.Apagado();
                    maquinaEmp.Apagado();
                    Console.WriteLine("\n");
                    Console.WriteLine("Todas las maquinas apagadas ... Hasta mañana!");
                }
            }
            else
            {
                Console.WriteLine("Metodo invalido.");
                maquinaRe.Apagado();
                maquinaAl.Apagado();
                maquinaEns.Apagado();
                maquinaVer.Apagado();
                maquinaEmp.Apagado();
            }
           
        }
    }
}
