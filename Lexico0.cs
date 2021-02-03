using System;
using System.IO;  

namespace Archivos
{
    internal class Lexico0
    {
        private StreamReader archivo;
       private StreamWriter bitacora;

       public Lexico0()
       {    
           if(File.Exists("C:\\Archivos\\prueba.txt")){
               archivo = new StreamReader("C:\\Archivos\\prueba.txt");
               bitacora = new StreamWriter("C:\\Archivos\\prueba.log");
               bitacora.AutoFlush = true;

               bitacora.WriteLine("Archivo: Prueba.txt");
               bitacora.WriteLine("Directorio: C:\\Archivos");   
           }
           else  Console.WriteLine("El archivo prueba.txt no existe"); 
       }

        ~Lexico0()
        {
            Console.WriteLine("Compiladon prueba.txt ");
            CerrarArchivos();
            Console.ReadKey();
        }

        private void CerrarArchivos(){
            archivo.Close();
            bitacora.Close();
        }

        public void Display(){
            while(!archivo.EndOfStream){
                Console.Write((char)archivo.Read());
            }
        }

    }
} 

