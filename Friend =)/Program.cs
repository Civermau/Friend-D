using System.Diagnostics;

class Program
{
    static void Main()
    {
        string filePath = "characters.json";
        CharacterManager characterManager = new CharacterManager(filePath);

        Character character1 = new Character("", "", personalities.Extroverted, Moods.Happy, "Park", "Playing", 25);
        character1.firstName = character1.getRandomName("Fnames.csv");
        character1.lastName = character1.getRandomName("Lnames.csv");
        characterManager.SaveCharacter(character1);

        Character character2 = new Character("", "", personalities.Introverted, Moods.Sad, "Home", "Reading", 30);
        character2.firstName = character1.getRandomName("Fnames.csv");
        character2.lastName = character1.getRandomName("Lnames.csv");
        characterManager.SaveCharacter(character2);

        List<Character> loadedCharacters = characterManager.LoadCharacters();

        foreach (var character in loadedCharacters)
        {
            Console.WriteLine($"First Name: {character.firstName}, Last Name: {character.lastName}, Personality: {character.personality}, Mood: {character.mood}, Place: {character.place}, Activity: {character.activity}, Age: {character.age}");
        }
    }
}
