using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nroRoma : MonoBehaviour
{
    private int[] arrays;
    public string nroRomanoS;

    public GameObject pizarra;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    public int nroRomano;
    // Start is called before the first frame update
    void Start()
    {
        nroRomano = Random.Range(1, 20);

        Romanificar();
    }

    // Update is called once per frame
    void Update()
    {
        pizarra.textmesh = nroRomanoS;
    }

    void Romanificar()
    {
        if (nroRomano == 1)
        {
            nroRomanoS = "I";
        }
        else if (nroRomano == 2)
        {
            nroRomanoS = "II";
        }
        else if (nroRomano == 3)
        {
            nroRomanoS = "III";
        }
        else if (nroRomano == 4)
        {
            nroRomanoS = "IV";
        }
        else if (nroRomano == 5)
        {
            nroRomanoS = "V";
        }
        if (nroRomano == 6)
        {
            nroRomanoS = "VI";
        }
        else if (nroRomano == 7)
        {
            nroRomanoS = "VII";
        }
        else if (nroRomano == 8)
        {
            nroRomanoS = "VIII";
        }
        else if (nroRomano == 9)
        {
            nroRomanoS = "IX";
        }
        else if (nroRomano == 10)
        {
            nroRomanoS = "X";
        }
    }
}
