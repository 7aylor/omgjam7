using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBox : MonoBehaviour
{
    BoxCollider2D collider;
    SpriteRenderer spriteRenderer;
    MovementBox[] boxes;
    
    [SerializeField]
    bool canMoveHere = false;
    Character character;
    bool parentIsPlayer;

    private void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
        character = GetComponentInParent<Character>();
        parentIsPlayer = GetComponentInParent<Player>() != null? true: false;
        boxes = FindObjectsOfType<MovementBox>();
    }

    /// <summary>
    /// 
    /// </summary>
    public void Enable()
    {
        if(spriteRenderer.enabled)
        {
            spriteRenderer.enabled = false;
            canMoveHere = false;
        }
        else
        {
            spriteRenderer.enabled = true;
            if (collider.IsTouchingLayers(LayerMask.GetMask("Walls", "Obstacles", "Players")))
            {
                Debug.Log(gameObject.name + " is touching an obstacle");
                spriteRenderer.color = new Color(0.7921569f, 0.2250103f, 0.2117647f, 0.5f);
                canMoveHere = false;
            }
            else
            {
                spriteRenderer.color = new Color(0.2130651f, 0.579029f, 0.7924528f, 0.5f);
                canMoveHere = true;
            }
        }

        if(!parentIsPlayer)
        {
            spriteRenderer.enabled = false;
        }

    }

    /// <summary>
    /// When mouse is clicked on the movement box, trigger player movement if the box is walkable
    /// </summary>
    private void OnMouseDown()
    {
        if(canMoveHere == true)
        {
            StartCoroutine(character.MovePlayerCoroutine(transform.position - character.transform.position, transform.position));
            foreach (var box in boxes)
            {
                box.Enable();
            }
        }
    }
}
