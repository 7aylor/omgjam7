using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TournamentManager : MonoBehaviour
{
    List<Character> characters;

    public int rounds = 1;
    Bracket bracket;

    private void Awake()
    {
        //Singleton
        int numTournamentObjects = FindObjectsOfType<TournamentManager>().Length;
        Debug.Log(numTournamentObjects + " tournament managers found");

        if(numTournamentObjects > 1)
        {
            Debug.Log("Destroying " + gameObject.name);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        characters = FindObjectsOfType<Character>().ToList();
        bracket = new Bracket(characters);
        bracket.PrintBracket();
    }

    void Update()
    {
        
    }
}
