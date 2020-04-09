using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TournamentManager : MonoBehaviour
{
    List<Character> characters;

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

    // Start is called before the first frame update
    void Start()
    {
        characters = FindObjectsOfType<Character>().ToList();
        Debug.Log(characters.Count);
        bracket = new Bracket(characters);
        bracket.PrintBracket();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
