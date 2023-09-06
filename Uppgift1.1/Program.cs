using System; //Använder system repository

namespace Uppgift1_1 //Vi gör en namespace och döper den till Uppgift1_1, namespaces håller isär olika klasser så du kan ha klasser i olika namespaces med samma namn
{
    class Program //Nu gör vi ett program. Klasser används för att skapa objekt
    {
        static void Main(string[] args) //vi skapar en static void. static betyder att det är en del av programmet och inte ett objekt. Void gör så att koden inte kan skicka till någonting utanför.
        {
            Console.WriteLine("Du är nästan klar med kapitel 1."); //här gör vi so att consolen skriver en rad med text
            Console.WriteLine("Du har lärt dig skriva ut tecken som \" och \\."); //nu skriver vi också " och \ i texten
        }
    }
}