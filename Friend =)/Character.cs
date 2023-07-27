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
    public personalities personality { get; set; }

    [JsonPropertyName("mood")]
    public Moods mood { get; set; }

    [JsonPropertyName("place")]
    public string place { get; set; }

    [JsonPropertyName("activity")]
    public string activity { get; set; }

    [JsonPropertyName("age")]
    public int age { get; set; }


    public Character(String firstName, String lastName, personalities personality, Moods mood, string place, string activity, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.personality = personality;
        this.mood = mood;
        this.place = place;
        this.activity = activity;
        this.age = age;
    }
    public String getRandomName(string filePath)
    {
        String[] lines;
        lines = System.IO.File.ReadAllLines(filePath);
        int rand = random.Next(80);
        return lines[rand];
    }
}
public enum personalities
{
    Extroverted,
    Introverted,
    Ambiverted,
    Optimistic,
    Pessimistic,
    Realistic,
    Assertive,
    Reserved,
    Friendly,
    Shy,
    Outgoing,
    Conscientious,
    Easygoing,
    Perfectionist,
    Empathetic,
    Logical,
    Creative,
    Analytical,
    Adventurous,
    Humble,
    NULL
}

public enum Moods
{
    Happy,
    Sad,
    Angry,
    Calm,
    Excited,
    Anxious,
    Content,
    Bored,
    Confident,
    Insecure,
    Grateful,
    Frustrated,
    Relaxed,
    Stressed,
    Hopeful,
    Disappointed,
    Surprised,
    Irritated,
    Lonely,
    Energetic,
    NULL
}
