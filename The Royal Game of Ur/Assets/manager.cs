using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{   

    public int currPlayer = 0;
    public bool flipped = false;
    public bool clicked = false;

    public bool animated = false;
    public int totMove;

    public void newTurn(){
        flipped = false;
        clicked = false;
        animated = false;

        if (currPlayer == 0)
        currPlayer = 1;
        else 
        currPlayer = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flipped&&clicked&&animated){
            Debug.Log("Turn Over for "+currPlayer);
            newTurn();
        }

        
    }
}
