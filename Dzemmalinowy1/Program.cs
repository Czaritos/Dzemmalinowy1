var age = 21;
var name = "Ewa";
var gender = "Kobieta";

if (age == 33 && name =="Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender == "Kobieta")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta ponizej 30tki");
    }
    else
    {
        Console.WriteLine("Kobieta w wieku 30lat lub wiecej");
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mezczyzna");
    }
    else
    {
        Console.WriteLine("Pełnoletni mezczyzna");
    }
}
