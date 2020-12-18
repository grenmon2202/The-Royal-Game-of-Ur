using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinFlip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        coinVal=new int[3];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[] coinVal;
    public int totMove;

    public void flipCoins(){
        //In a traditional game of The Royal Game of Ur, three pyramid shaped dice are thrown, giving
        //a binary result of 0 or 1 each, thus allowing a player to move upto 3 spaces at a time.
        //The same result can be acquired by flipping three coins and allowing the user to move one
        //space for every Heads rolled.
        
        totMove=0;
        for (int i = 0; i<coinVal.Length; i++){
            coinVal[i]=Random.Range(0,2);
            totMove+=coinVal[i];
        }
        
        Debug.Log("Flip Results: ");

        for(int i = 0; i<coinVal.Length;i++)
        Debug.Log(i+": "+coinVal[i]);
        Debug.Log("Total :"+totMove);
    }
}
