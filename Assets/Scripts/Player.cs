using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void EnableMovementBoxes()
    {
        var movementBoxes = GetComponentsInChildren<MovementBox>();
        
        foreach(MovementBox box in movementBoxes)
        {
            box.Enable();
        }
    }
}
