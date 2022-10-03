using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NroRandom : MonoBehaviour
{

    public int NroFinal;
    public string RomaFinal;
    bool esM10;
    public TextMesh NroRomaFinal;
    public TextMesh txtopcion1;
    public TextMesh txtopcion2;
    public TextMesh txtopcion3;

    int option1;
    int option2;
    int option3;
    int mezcla;

    bool esCorrecta;
    

    void Start()
    {

        NroFinal = Random.Range(1, 20);

        MezclarOpciones();

        Romanificar();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MezclarOpciones()
    {
        mezcla = Random.Range(1, 3);
        option1 = Random.Range(1, 20);
        option2 = Random.Range(1, 20);
        option3 = Random.Range(1, 20);

        if (NroFinal == option1 || option1 == option2)
        {
            option1 = Random.Range(1, 20);

            if (NroFinal == option1 || option1 == option2)
            {
                option1 = Random.Range(1, 20);
            }
        }

        if (NroFinal == option2 || option3 == option2)
        {
            option1 = Random.Range(1, 20);

            if (NroFinal == option2 || option3 == option2)
            {
                option1 = Random.Range(1, 20);
            }
        }

        if (NroFinal == option3 || option1 == option3)
        {
            option1 = Random.Range(1, 20);

            if (NroFinal == option3 || option1 == option3)
            {
                option1 = Random.Range(1, 20);
            }
        }

        if (mezcla == 1)
        {
            option1 = NroFinal;
        }
        else if (mezcla == 2)
        {
            option2 = NroFinal;
        }
        else if (mezcla == 3)
        {
            option3 = NroFinal;
        }

        txtopcion1.text = option1.ToString();
        txtopcion2.text = option2.ToString();
        txtopcion3.text = option3.ToString();
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

    void OnTriggerEnter(Collider other)
    {
        if (other.name == mezcla.ToString())
        {
            esCorrecta = true;
        }
        else if (other.name != mezcla.ToString())
        {
            esCorrecta = false;
        }

    }

    void Desplomar()
    {
        if (esCorrecta == true)
        {
                
        }
    }
}
