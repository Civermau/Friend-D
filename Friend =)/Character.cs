using System;
using System.Text.Json.Serialization;

public class Character
{
    [JsonPropertyName("Name")]
    public String name { get; set; }

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


    public Character(String name, personalities personality, Moods mood, string place, string activity, int age)
    {
        this.name = name;
        this.personality = personality;
        this.mood = mood;
        this.place = place;
        this.activity = activity;
        this.age = age;
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
