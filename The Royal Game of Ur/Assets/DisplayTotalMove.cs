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

    public CoinFlip cf;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = ""+cf.totMove;
    }
}
