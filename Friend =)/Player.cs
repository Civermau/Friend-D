using System;

public class Player : Character
{
    public Player(String firstName, String lastName, String personality, String mood, string place, string activity, int age) : base(firstName, lastName, personality, mood, place, activity, age)
    {
    }
    public Player(string place, string activity, int age) : base(place, activity, age) 
    { 
    }

    private void move()
    {

    }
}
