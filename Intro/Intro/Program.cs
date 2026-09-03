namespace Intro //See on projekti nimetus
{  
    internal class Program //See on klassi nimetus
    {
        //Meetotit ei saa panna namespace'i, kuna see on klassi sees
        static void Main(string[] args) //See on peamine meetod, mis käivitatakse programmi käivitamisel
        {
            Console.WriteLine("Hello, World!"); //See on konsooli väljund, mis prindib "Hello, World!" ekraanile
            //Kui tahad topelt rida teha, siis vajuta Ctrl + D
            //Kui tahad kustutada rida, siis vajuta Ctrl + X
        }

        //Breakpointi saab panna koodirea vasakule poolele,
        //kus on hall ruut. Kui programm jõuab
        //selle koodirea juurde, siis peatub see ja võimaldab teil
        //uurida muutujate väärtusi ja programmi olekut.
    }
}
