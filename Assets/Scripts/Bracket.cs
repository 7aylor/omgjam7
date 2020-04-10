using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Bracket
{
    public List<Matchup> matchups;

    public Bracket(List<Character> characters)
    {
        matchups = new List<Matchup>();
        for(int i = 0; i < characters.Count; i++)
        {
            PickMatchup(characters);
        }
    }

    /// <summary>
    /// Loops through characters that haven't been picked and pairs them
    /// up with another character to fight
    /// </summary>
    /// <param name="characters"></param>
    private void PickMatchup(List<Character> characters)
    {
        System.Random r = new System.Random();

        //pick first character and remove from characters
        Character firstPick = characters[r.Next(0, characters.Count)];
        characters.Remove(firstPick);

        //picke second character and remove from characters
        Character secondPick = characters[r.Next(0, characters.Count)];
        characters.Remove(secondPick);

        //add this combo to the matchups
        matchups.Add(new Matchup(firstPick, secondPick));
    }


    public void PrintBracket()
    {
        foreach (var match in matchups)
        {
            Debug.Log(match.character1.name + " vs " + match.character2.name);
        }
    }
}
