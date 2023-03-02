using Factory;

FactoryMethod factory = new FactoryMethod();

Console.WriteLine("Available characters: \nLiu Kang | SubZero | Scorpion\n");
Console.Write("Choose your character:");
string choice = Console.ReadLine();

ICharacter character = factory.ChooseCaracter(choice);

Console.Write("\nYou'll play with ");

character.Chosen();

Console.ReadKey();