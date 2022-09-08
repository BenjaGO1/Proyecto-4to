using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    public GameObject btn;
    public GameObject TxT;
    void Start()
    {
        InvokeRepeating("DesaparecerBoton", 5, 3);

        CancelInvoke();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DesaparecerBoton()
    {
        btn.SetActive(false);
        TxT.SetActive(true);
    }
}
