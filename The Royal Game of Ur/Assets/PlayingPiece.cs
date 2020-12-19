using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingPiece : MonoBehaviour
{

    Vector3 moveTo;
    Vector3 velocity;
    float moveTime = 0.05f;

    private char str;

    private TileScript[] moveQueue;
    private TileScript moveHere;
    private int moveIndex;

    private bool destroy = false;
    bool animating;
    // Start is called before the first frame update
    void Start()
    {
        str = this.name[6];
        moveTo=this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        if(!animating)
        return;
        if(this.transform.position!=moveTo){
            this.transform.position=Vector3.SmoothDamp(this.transform.position, moveTo, ref velocity, moveTime);
        }

        else{
            if(moveQueue != null && moveIndex<moveQueue.Length){
                moveTo=moveQueue[moveIndex].transform.position;
                //Debug.Log(moveTo);
                moveIndex++;
            }
            else if (moveQueue != null && moveIndex==moveQueue.Length && destroy && this.transform.position!=Score1.transform.position)
            {
                Destroy(gameObject);
                Score1.raise=true;
                destroy=false;
                moveIndex=moveQueue.Length;
            }
        }
        if (moveQueue==null&&this.transform.position==moveTo){
            Debug.Log("Done Animating");
            cf.animated=true;
            this.animating=false;
        }
        if(moveIndex==moveQueue.Length){
            moveQueue=null;
        }
    }

    public manager cf;
    public TileScript startTile;
    private TileScript currentTile=null;
    public Raising Score1;

    void OnMouseUp(){
        if (!cf.flipped){
            return;
        }
        if(cf.clicked){
            return;
        }

        int move = cf.totMove;

        if(move==0)
        return;

        moveQueue=new TileScript[move];
        moveIndex=0;

        for (int i = 0; i<move; i++){
            if (currentTile==null){
                currentTile=startTile;
            }
            else{
                if (currentTile.nextTiles.Length==0){
                    destroy=true;
                }

                else if (currentTile.nextTiles.Length>1){
                    currentTile=currentTile.nextTiles[0];
                }
                else
                currentTile=currentTile.nextTiles[0];
            }
            moveQueue[i]=currentTile;
        }

        moveIndex=0;

        cf.clicked=true;
        animating=true;
    }
}
