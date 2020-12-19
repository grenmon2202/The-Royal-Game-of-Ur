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

    public int score1, score2;

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
        score1=0;
        score2=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(flipped&&clicked&&animated){
            Debug.Log("Turn Over for "+currPlayer);
            newTurn();
        }

        if(score1==6){

        }

        if(score2==6){
            
        }
    }
}
