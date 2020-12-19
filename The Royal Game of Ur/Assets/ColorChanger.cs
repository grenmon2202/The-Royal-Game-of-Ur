using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public manager cf;

    public Sprite gold, brown;

    // Update is called once per frame
    void Update()
    {
        if(cf.currPlayer==0){
            GetComponent<Image>().sprite=gold;
        }
        else
        GetComponent<Image>().sprite=brown;
    }
}
