using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarraDeja : MonoBehaviour
{
    public GameObject barril;
    public GameObject player;

    float Yplayer;
    float Xplayer;
    float Zplayer;

    float Ybarril;
    float Xbarril;
    float Zbarril;

    // Start is called before the first frame update
    void Start()
    {
        Ybarril = barril.transform.localPosition.y;
        Xbarril = barril.transform.localPosition.x;
        Zbarril = barril.transform.localPosition.z;
    }
  
    // Update is called once per frame
    void Update()
    {
        Yplayer = player.transform.localPosition.y;
        Xplayer = player.transform.localPosition.x;
        Zplayer = player.transform.localPosition.z;

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Barril")
        {
            //Ybarril = Yplayer;
            //Xbarril = Xplayer;
            //Zbarril = Zplayer;        
        }

        
    }
}
