using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{   

    public int currPlayer = 0;
    public bool flipped = false;
    public bool clicked = false;

    public bool animated = false;
    public int totMove;

    public int score1, score2;

    public Animator trans;

    public void newTurn(){
        flipped = false;
        clicked = false;
        animated = false;

        if (currPlayer == 0)
        currPlayer = 1;
        else 
        currPlayer = 0;
    }

    IEnumerator oneWon(){

        trans.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("CongoPlayer1");
    }

    IEnumerator twoWon(){
        trans.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("CongoPlayer2");
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
            StartCoroutine(oneWon());
        }

        if(score2==6){
            StartCoroutine(twoWon());
        }
    }
}
