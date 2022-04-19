using EggMaker.Models;

namespace EggMaker.Services;
public static class EggService
{
    static List<Egg> Eggs { get; }
    static int nextId = 3;
    static EggService()
    {
        Eggs = new List<Egg>
                {
                    new Egg { Id = 1, Name = "Cornish Cross", Price=3.99M, Size=EggSize.    Large, IsOrganic = false },
                    new Egg { Id = 2, Name = "Leghorn", Price=6.99M, Size=EggSize.Small,     IsOrganic = true }
                };
    }

    public static List<Egg> GetAll() => Eggs;

    public static Egg? Get(int id) => Eggs.FirstOrDefault(p => p.Id == id);

    public static void Add(Egg egg)
    {
        egg.Id = nextId++;
        Eggs.Add(egg);
    }

    public static void Delete(int id)
    {
        var egg = Get(id);
        if (egg is null)
            return;

        Eggs.Remove(egg);
    }

    public static void Update(Egg egg)
    {
        var index = Eggs.FindIndex(p => p.Id == egg.Id);
        if (index == -1)
            return;

        Eggs[index] = egg;
    }
                }