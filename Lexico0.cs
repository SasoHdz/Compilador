using System;
using System.IO;  

namespace Archivos
{
    internal class Lexico0 : IDisposable
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
           else {
               throw new Exception("El archivo prueba.txt no existe");
           }  
       }

       // ~Lexico0()
        public void Dispose()
        {
            Console.WriteLine("Compilandon prueba.txt ");
            CerrarArchivos();
            //Console.ReadKey();
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

        public void Load(){
            while(!archivo.EndOfStream){
                bitacora.Write((char)archivo.Read());
            }
        }

    }
} 

