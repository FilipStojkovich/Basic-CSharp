using Homework_08_Task3;

List<Animal> animals = new List<Animal>()
{
    new Animal("Golden Retrievers", "brown", 6, Animal.Gender.Male),
    new Animal("German Shepherd", "black", 4, Animal.Gender.Male),
    new Animal("Poodles", "white", 8, Animal.Gender.Female),
    new Animal("Bulldogs", "brown", 7, Animal.Gender.Male),
    new Animal("Rottweilers", "black", 5, Animal.Gender.Male),
    new Animal("Dachshunds", "brown", 4, Animal.Gender.Female),
    new Animal("Pitbulls", "grey", 6, Animal.Gender.Female)
};

List<string> agedFiveOrMore = animals.Where(n => n.Age >= 5)
    .Select(n => n.Name)
    .ToList();

foreach (var name in agedFiveOrMore)
{
    Console.WriteLine(name);
}


List<string> animalsThatStartWithA = animals.Where(n => n.Name.StartsWith("A"))
    .Select(n => n.Name)
    .ToList();


if(animalsThatStartWithA.Any())
{
    foreach (var name in animalsThatStartWithA)
    {
        Console.WriteLine(name);
    }
}
else
{
    Console.WriteLine("There is no animal that starts with A");
}

List<string> allMaleAndBrownAnimalsNames = animals
    .Where(x => x.GenderType == Animal.Gender.Male && x.Color == "brown")
    .Select(x => x.Name)
    .ToList();

foreach (var name in allMaleAndBrownAnimalsNames)
{
    Console.WriteLine(name);
}


var moreThanTenChars = animals.First(x => x.Name.Length > 10);
Console.WriteLine(moreThanTenChars.Name);

Console.ReadLine();