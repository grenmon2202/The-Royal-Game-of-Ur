﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raising : MonoBehaviour
{

    public bool raise = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    private string str;

    public Material[] scored1;
    public Material[] scored2;

    // Update is called once per frame
    void Update()
    {
        if (raise){
            str=this.name;
            if(str[6]=='1'){
                GetComponentInChildren<Renderer>().materials = scored1;
                
            }
            else{
                GetComponentInChildren<Renderer>().materials = scored2;
            }
            raise=false;
        }
    }
}
