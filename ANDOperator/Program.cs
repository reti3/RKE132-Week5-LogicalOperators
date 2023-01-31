// eksami tulemused peavad olema: Math >= 90; Biology >= 90; Chemisrty >= 90;
// kasutaja saab sisestada oma tulemused

int math, biology, chemisrty; // muutujad

Console.WriteLine("Enter your math results:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology results:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result:");
chemisrty = Int32.Parse(Console.ReadLine());

if(math >= 90 && biology >= 90 && chemisrty >= 90) // kõik tingimused pead olema täidetud
{
    Console.WriteLine("Congratulations! You got accepted.");
}
else
{
    Console.WriteLine("Your application was denied.");
}