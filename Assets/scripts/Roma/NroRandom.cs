using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NroRandom : MonoBehaviour
{
    public int NroFinal;
    public string RomaFinal;
    bool esM10;
    public Text NroRomaFinal;

    void Start()
    {
        NroFinal = Random.Range(1, 20);

        Romanificar();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Romanificar()
    {
        if (NroFinal > 10)
        {
            NroFinal = NroFinal - 10;
            esM10 = true;
        }

        if (NroFinal <= 5)
        {
            if (NroFinal == 1)
            {
                RomaFinal = "I";
            }
            else if (NroFinal == 2)
            {
                RomaFinal = "II";
            }
            else if (NroFinal == 3)
            {
                RomaFinal = "III";
            }
            else if (NroFinal == 4)
            {
                RomaFinal = "IV";
            }
            else if (NroFinal == 5)
            {
                RomaFinal = "V";
            }
        }
        else if (NroFinal <= 10)
        {
            if (NroFinal == 6)
            {
                RomaFinal = "VI";
            }
            else if (NroFinal == 7)
            {
                RomaFinal = "VII";
            }
            else if (NroFinal == 8)
            {
                RomaFinal = "VIII";
            }
            else if (NroFinal == 9)
            {
                RomaFinal = "IX";
            }
            else if (NroFinal == 10)
            {
                RomaFinal = "X";
            }
        }
        if (esM10 == true)
        {
            NroRomaFinal.text = "X" + RomaFinal;
        }
        else
        {
            NroRomaFinal.text = RomaFinal;
        }

        Debug.Log(NroFinal);
        Debug.Log(NroRomaFinal.text);
    }
}
