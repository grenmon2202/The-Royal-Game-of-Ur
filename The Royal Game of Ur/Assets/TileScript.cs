using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{

    public TileScript[] nextTiles;
    public PlayingPiece heldPiece;
    public bool isRestTile;

    // Start is called before the first frame update
    void Start()
    {
        heldPiece=null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
