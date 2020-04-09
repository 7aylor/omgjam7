using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    Tilemap tileMap;

    // Start is called before the first frame update
    void Start()
    {
        tileMap = GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnMouseOver()
    //{
    //    Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    tileMap.SetColor(new Vector3Int((int)mousePos.x, (int)mousePos.y, 0), Color.gray);
    //    TileBase tile = tileMap.GetTile(new Vector3Int((int)mousePos.x, (int)mousePos.y, 0));
    //    Debug.Log(tile);
    //    Debug.Log("Mouse Pos: " + (int)mousePos.x + ", " + (int)mousePos.y);
    //}
}
