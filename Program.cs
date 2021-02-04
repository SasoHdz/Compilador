using  System;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                using(Lexico0 l = new Lexico0()){//Ejecuta rl metodo dispose (destrcutor)
                    while(!l.FinDeArchivo())
                    {
                        l.Palabra();
                    }
                } 
            }
            catch(Exception e){
                    Console.WriteLine(e.Message);
            }
        }
    }

}
