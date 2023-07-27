using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class CharacterManager
{
    private string filePath; 
    public CharacterManager(string filePath)
    {
        this.filePath = filePath;
    }

    public void SaveCharacter(Character character)
    {
        List<Character> characters = LoadCharacters();
        characters.Add(character);

        string json = JsonSerializer.Serialize(characters, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public List<Character> LoadCharacters()
    {
        List<Character> characters;
        if (!File.Exists(filePath))
        {
            characters = new List<Character>();
        }
        else
        {
            string json = File.ReadAllText(filePath);
            characters = JsonSerializer.Deserialize<List<Character>>(json);
        }
        return characters;
    }
}
