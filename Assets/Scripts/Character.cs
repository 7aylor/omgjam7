using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Element { Earth, Water, Fire, Acid, DarkEnergy, Mana}

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class Character : MonoBehaviour
{
    [Header("Stats")]
    [Range(5, 25)]
    [Tooltip("Counter to Will")]
    public int Intelligence;

    [Range(5, 25)]
    [Tooltip("Counter to Intelligence")]
    public int Will;

    [Range(5, 25)]
    [Tooltip("Counter to Defense")]
    public int Strength;

    [Range(5, 25)]
    [Tooltip("Counter to Strength")]
    public int Defense;

    [Range(5, 25)]
    [Tooltip("Counter to Shield")]
    public int Range;

    [Range(5, 25)]
    [Tooltip("Counter to Range")]
    public int Armor;

    public Element BuffElement;
    public Element NerfElement;

    Character versusEnemy;
    public int gridSpace { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void Attack()
    {

    }
}
