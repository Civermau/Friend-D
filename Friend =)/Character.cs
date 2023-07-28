using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public class Character
{
    Random random = new Random();

    [JsonPropertyName("firstName")]
    public String firstName { get; set; }
    [JsonPropertyName("lastName")]
    public String lastName { get; set; }

    [JsonPropertyName("personality")]
    public String personality { get; set; }

    [JsonPropertyName("mood")]
    public String mood { get; set; }

    [JsonPropertyName("place")]
    public String place { get; set; }

    [JsonPropertyName("activity")]
    public String activity { get; set; }

    [JsonPropertyName("age")]
    public int age { get; set; }


    public Character(String place, String activity, int age)
    {
        this.firstName = getRandomFileString("Fnames.csv");
        this.lastName = getRandomFileString("Lnames.csv");
        this.personality = getRandomFileString("Personalities.csv");
        this.mood = getRandomFileString("Moods.csv");
        this.place = place;
        this.activity = activity;
        this.age = age;
    }

    [JsonConstructor]
    public Character(String firstName, String lastName, String personality, String mood, String place, String activity, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.personality = personality;
        this.mood = mood;
        this.place = place;
        this.activity = activity;
        this.age = age;
    }
    public String getRandomFileString(string filePath)
    {
        int lenght;
        String[] lines;
        lines = System.IO.File.ReadAllLines(filePath);
        lenght = Array.FindIndex(lines, element => element == "NULL");
        lenght--;
        if (lenght < 0)
        {
            lenght = 0;
        }
        int rand = random.Next(lenght) + 1;
        return lines[rand];
    }
}