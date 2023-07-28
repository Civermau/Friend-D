using System.Diagnostics;

class Program
{
    static void Main()
    {
        string filePath = "characters.json";
        CharacterManager characterManager = new CharacterManager(filePath);

        Character character1 = new Character("", "", "", "", "1,1", "Playing", 25);
        characterManager.SaveCharacter(character1);

        Character character2 = new Character("", "", "", "", "1,2", "Reading", 30);
        characterManager.SaveCharacter(character2);

        List<Character> loadedCharacters = characterManager.LoadCharacters();

        foreach (var character in loadedCharacters)
        {
            Console.WriteLine($"First Name: {character.firstName}, Last Name: {character.lastName}, Personality: {character.personality}, Mood: {character.mood}, Place: {character.place}, Activity: {character.activity}, Age: {character.age}");
        }
    }
}