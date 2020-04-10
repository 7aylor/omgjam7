using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBox : MonoBehaviour
{
    BoxCollider2D collider;
    SpriteRenderer spriteRenderer;
    
    [SerializeField]
    bool canMoveHere = false;

    private void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false; 

        Debug.Log("Walls: " + LayerMask.GetMask("Walls"));
        Debug.Log("Obstacles: " + LayerMask.GetMask("Obstacles"));
        Debug.Log("Obstacles and Walls: " + LayerMask.GetMask("Walls", "Obstacles"));
    }

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
            if (collider.IsTouchingLayers(LayerMask.GetMask("Walls", "Obstacles")))
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
    }
}
