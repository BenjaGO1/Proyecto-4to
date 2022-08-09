using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EligeCuenta : MonoBehaviour
{
    public Text N1Text;
    public Text N2Text;

    public int minInt = 1;
    public int maxInt = 10;

    int randomnum;
    int randomnum2;

    public InputField Respuesta;

    int insertRes;
    public int res;

    public Text correccionando;
    public GameObject correccionado;

    public void Start()
    {
        RandomizarEnTexto();

        correccionado.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Corrección();
            Correccionado();

            //si pasan 3 segundos o la animacion reiniciar
            //Hacer timer de respuesta
            Reset();
        }
    }

    public void RandomizarEnTexto()
    {
        randomnum = Random.Range(minInt, maxInt);
        

        randomnum2 = Random.Range(minInt, maxInt);
        



        string n1text = randomnum.ToString();
        string n2text = randomnum2.ToString();


        N1Text.text = n1text + " +";
        N2Text.text = n2text + " =";


    }

    public void Corrección()
    {

        insertRes = (int.Parse(Respuesta.text));

        int res = randomnum + randomnum2;


        if (insertRes == res)
        {
            Debug.Log("Respuesta correcta");

            string correcionando = ("Respuesta correcta");
            correccionando.text = correcionando;

        }
        else
        {
            Debug.Log("Respuesta incorrecta");
            string correcionando = ("Respuesta incorrecta");
            correccionando.text = correcionando;
        }


    }

    public void Correccionado()
    {
        correccionado.SetActive(true);
    }

    public GameObject Cuenta;
    public GameObject Heal;
    public GameObject Object;
    public GameObject Ataque;


    public void Reset()
    {
        Cuenta.SetActive(false);
        Heal.SetActive(true);
        Object.SetActive(true);
        Ataque.SetActive(true);

        RandomizarEnTexto();

        string textReset = ("");
        correccionando.text = textReset;

        string InputReset = "";
        Respuesta.text = InputReset;
    
    }





}
