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
           Console.WriteLine("Compilando prueba.txt");

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
        public void Dispose() //Desctructor 
        {
            Console.WriteLine("\nFinalizando complilacion prueba.txt ");
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

          public void Display2(){
            while(!archivo.EndOfStream){
                Console.Write((char)archivo.Peek());
                archivo.Read();
            }
        }

        public void Load(){
            while(!archivo.EndOfStream){
                bitacora.Write((char)archivo.Read());
            }
        }

        public void Encrypt(){

            while(!archivo.EndOfStream){
                char c;                
                if(char.IsLetter(c = (char)(archivo.Read()))){
                    bitacora.Write((char)(c+1));
                }
                else{
                    bitacora.Write(c);
                }
                
            }
        }

        public void Encrypt2(){

            while(!archivo.EndOfStream){
                char c;                
                if(char.IsLetter(c = (char)(archivo.Peek()))){
                    bitacora.Write((char)(c+1));
                }
                else{
                    bitacora.Write(c);
                }
                archivo.Read();
            }
        }

        public bool checkVocal(char v){
         bool indicador;
        if(v == 'a' || v == 'A' || v == 'Á' || v == 'á'|| v == 'e' || v == 'E' || v == 'é' || v == 'É'||v == 'I' || v == 'i'||v == 'Í' 
        || v =='í' || v == 'ó' || v == 'o' || v == 'O' || v == 'Ó'|| v == 'u' || v == 'U' || v == 'Ú' || v == 'ú' ) indicador = true;
        else indicador=false;
        
        return indicador;
       }

        public void Mosca(char letra){

            while(!archivo.EndOfStream){
                char c;                
                if(Char.IsLetter(c = (char)(archivo.Read()))){
                    if(checkVocal(c)) c = letra;
                }
                bitacora.Write(c);
            }
        }

        public void Token(){

            char c;
            string palabra = "";

            while(char.IsWhiteSpace(c = (char)archivo.Read()))
            {
                //Busca el primer caracter válido
            }

            palabra += c;                
            if(char.IsLetter(c))
            {
                //Encontro una lentra
                palabra+=c;

                 while(char.IsLetter(c = (char)archivo.Peek()))
                 {
                     //Concatenar más letras para formar la palabra
                     palabra+=c;
                     archivo.Read();
                 }
            }
            else if(char.IsDigit(c))
            {
                //Si no es letra es otro caracter
                while(char.IsDigit(c = (char)archivo.Peek()))
                 {
                     //Concatenar más letras para formar la palabra
                     palabra += c;
                     archivo.Read();
                 }
            }
           
            bitacora.WriteLine("Token = "+palabra);
                
        }

        public bool FinDeArchivo(){
            return archivo.EndOfStream;
        }

    }
} 

