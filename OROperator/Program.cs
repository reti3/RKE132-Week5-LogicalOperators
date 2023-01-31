// tingimused: math >= 90 OR chemestry >= 90

// math && chemisrty -|| math && biology || chemistry && biology - tegu paaridega, millest 1 paar peab oleam tõene.

int math, biology, chemisrty; // muutujad

Console.WriteLine("Enter your math results:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology results:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result:");
chemisrty = Int32.Parse(Console.ReadLine());

if (((math >= 90 && chemisrty >=90) || (math >= 90 && biology >=90 ) || (biology >=90 && chemisrty >=90))) // üks tingimuste paar peab olema täidetud
{
    Console.WriteLine("Congratulations! You got accepted.");
}
else
{
    Console.WriteLine("Your application was denied.");
}
