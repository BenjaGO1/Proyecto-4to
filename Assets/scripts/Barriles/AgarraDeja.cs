using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarraDeja : MonoBehaviour
{
    public GameObject quien;
    public GameObject agarrado;
    public Transform agarrador;

    bool sedeja;

    void Update()
    {
        if (quien != null && quien.GetComponent<SePuedeAgarrar>().seAgarra == true && agarrado == null)
        {
            if (Input.GetKey(KeyCode.E))
            {
                agarrado = quien;
                agarrado.GetComponent<SePuedeAgarrar>().seAgarra = false;
                agarrado.transform.SetParent(agarrador);
                agarrado.transform.localPosition = agarrador.transform.localPosition;
                agarrado.GetComponent<Rigidbody>().useGravity = false;
                agarrado.GetComponent<Rigidbody>().isKinematic = true;
                sedeja = true;
            }
        }

        else if (agarrado != null && sedeja == true)
        {
            if (Input.GetKey(KeyCode.F))
            {
                agarrado.GetComponent<SePuedeAgarrar>().seAgarra = true;
                agarrado.transform.SetParent(null);
                agarrado.GetComponent<Rigidbody>().useGravity = true;
                agarrado.GetComponent<Rigidbody>().isKinematic = false;
                agarrado = null;
                sedeja = false;
            }
        }
    }
}
