public class AuthorSign
{
    public string _prenom;
    public string _nom;

    public string _quote;

    public AuthorSign()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_prenom} {_nom}, {_quote}");
    }
}