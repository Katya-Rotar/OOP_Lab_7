class Smartphone : ICallable, IBrowsable
{
    public string Browse(string site)
    {
        if (!site.Any(char.IsDigit))
        {
            return $"Browsing: {site}";
        }
        else {
            return "Invalid URL!";
        }
    }

    public string Call(string number)
    {
        if (number.All(char.IsDigit))
        {
            return $"Calling... {number}";
        }
        else
        {
            return "Invalid number!";
        }
    }
}
