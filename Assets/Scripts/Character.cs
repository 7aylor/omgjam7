using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Element { Earth, Water, Fire, Acid, DarkEnergy, Mana}

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class Character : MonoBehaviour
{
    #region Character Stats
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

    [Range(100, 200)]
    public int Health;

    public Element BuffElement;
    public Element NerfElement;
    #endregion

    public bool hasPlayedTurn = false;
    public int actionPoints = 2;

    public int gridSpace;

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

    protected void TakeDamage(int amount)
    {
        Health -= amount;

    }

    public void EnableMovementBoxes()
    {
        var movementBoxes = GetComponentsInChildren<MovementBox>();

        EnableAllMovementBoxes(movementBoxes);
    }

    private static void EnableAllMovementBoxes(MovementBox[] movementBoxes)
    {
        foreach (MovementBox box in movementBoxes)
        {
            box.Enable();
        }
    }

    public IEnumerator MovePlayerCoroutine(Vector2 moveDirection, Vector2 targetLocation)
    {
        //moving so s
        actionPoints--;

        //trigger walk animation
        while (Vector2.Distance((Vector2)transform.position, targetLocation) > 0.05f)
        {

            transform.Translate(moveDirection * Time.deltaTime);
            yield return new WaitForSeconds(0.01f);
        }
        //trigger idle animation
        transform.position = targetLocation;

        if (actionPoints > 0)
        {
            EnableMovementBoxes();
        }
    }
}
