using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingPiece : MonoBehaviour
{

    Vector3 moveTo;
    Vector3 velocity;
    float moveTime = 0.05f;

    public int playerID;

    private char str;

    private TileScript[] moveQueue;
    private TileScript moveHere;
    private int moveIndex;
    public TileScript finalTile;
    bool animating;
    // Start is called before the first frame update
    void Start()
    {
        str = this.name[6];
        moveTo=this.transform.position;
        initPos=this.transform.position;
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
            
        }
        if (this.transform.position == finalTile.transform.position)
            {
                Destroy(gameObject);
                Score1.raise=true;
                Debug.Log("Done Animating");
            cf.animated=true;
            this.animating=false;
            return;
            }
        if (moveQueue==null&&this.transform.position==moveTo){
            Debug.Log("Done Animating");
            cf.animated=true;
            this.animating=false;
            return;
        }
        if(moveQueue!=null){
        if(moveIndex==moveQueue.Length){
            moveQueue=null;
        }}
    }

    public manager cf;
    public TileScript startTile;
    private TileScript currentTile;
    private TileScript temp=null;
    public Raising Score1;

    void OnMouseUp(){

        if(cf.currPlayer!=playerID){
            return;
        }

        if (!cf.flipped){
            return;
        }
        if(cf.clicked){
            return;
        }

        int move = cf.totMove;
        temp=currentTile;

        if(move==0)
        return;

        moveQueue=new TileScript[move];
        moveIndex=0;

        for (int i = 0; i<move; i++){
            if (currentTile==null){
                currentTile=startTile;
            }
            else{

                if (currentTile.nextTiles.Length>1){
                    if(str=='1')
                    currentTile=currentTile.nextTiles[0];
                    else
                    {
                        currentTile=currentTile.nextTiles[1];
                    }
                }
                else if (currentTile.nextTiles!=null)
                currentTile=currentTile.nextTiles[0];
            }
            moveQueue[i]=currentTile;
        }

        moveIndex=0;

        if (LegalMove(currentTile)){
            currentTile.heldPiece=this;
            if(temp!=null)
            temp.heldPiece=null;
            cf.clicked=true;
            animating=true;
        }

        else
        {
            currentTile=temp;
            return;
        }
    }


    private Vector3 initPos;

    bool LegalMove (TileScript dest){
        if (dest.heldPiece==null){
            return true;
        }
        if (dest.heldPiece.playerID==this.playerID){
            return false;
        }
        if (dest.isRestTile){
            return false;
        }

        dest.heldPiece.returnToStorage();
        dest.heldPiece=this;
        return true;
    }

    void returnToStorage(){
        this.currentTile=null;
        this.transform.position=initPos;
        moveQueue=null;
    }
}
