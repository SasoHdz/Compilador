
namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Lexico0 l = new Lexico0();
                l.Display();
                
            }
            catch(Exception e){
                    Console.WriteLine(e.Message);
            }
        }
    }

}
