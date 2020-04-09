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

    private void PickMatchup(List<Character> characters)
    {
        System.Random r = new System.Random();

        int firstPick = r.Next(0, characters.Count);
        int secondPick = -1;

        do
        {
            secondPick = r.Next(0, characters.Count);
        } while (secondPick == firstPick);

        matchups.Add(new Matchup(characters[firstPick], characters[secondPick]));

        characters.Remove(characters[firstPick]);
        characters.Remove(characters[secondPick]);
    }

    public void PrintBracket()
    {
        foreach (var match in matchups)
        {
            Debug.Log(match.character1.name + " vs " + match.character2.name);
        }
    }
}
