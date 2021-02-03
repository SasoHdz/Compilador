using  System;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                using(Lexico0 l = new Lexico0()){//Ejecuta rl metodo dispose (destrcutor)
                    l.Encrypt();
                } 
            }
            catch(Exception e){
                    Console.WriteLine(e.Message);
            }
        }
    }

}
