using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTotalMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public manager cf;

    // Update is called once per frame
    void Update()
    {   
        if (cf.flipped)
        GetComponent<Text>().text = ""+cf.totMove;
        else
        {
            GetComponent<Text>().text = "?";
        }
    }
}
