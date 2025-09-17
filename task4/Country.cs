
public class Country
{
    private string name;
    private string capital;
    private int population;
    private string officialLanguage;

    public Country(string name, string capital, int population, string officialLanguage)
    {
        this.name = name;
        this.capital = capital;
        this.population = population;
        this.officialLanguage = officialLanguage;
    }

    public void SetCapital(string capital)
    {
        this.capital = capital;
    }

    public string GetCapital()
    {
        return capital;
    }

    public void SetPopulation(int population)
    {
        this.population = population;
    }

    public int GetPopulation()
    {
        return population;
    }

    public void SetOfficialLanguage(string language)
    {
        this.officialLanguage = language;
    }

    public string GetOfficialLanguage()
    {
        return officialLanguage;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Country Name: " + name);
        Console.WriteLine("Capital: " + capital);
        Console.WriteLine("Population: " + population.ToString("N0"));
        Console.WriteLine("Official Language: " + officialLanguage);
    }
}