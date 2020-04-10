using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matchup : MonoBehaviour
{
    public Character character1;
    public Character character2;
    public int rounds = 1;


    public Matchup(Character c1, Character c2)
    {
        character1 = c1;
        character2 = c2;
    }

    /// <summary>
    /// Gets the character that is fighting the given character
    /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    public Character GetCharacterByEnemyFighting(Character c)
    {
        if(c.name != character1.name)
        {
            return character1;
        }
        else
        {
            return character2;
        }
    }
}
