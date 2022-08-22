using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EligeCuenta : MonoBehaviour
{
    public GameObject btnContinuar;

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

    public Text txtTiempo;

    //public float counter = 10;
    //public float timeRes = 0;
    //public float ayuda;

    //private int InttiempoMuestra;

    public void Start()
    {
        //RandomizarDivi();
        //RandomizarResta();
        //RandomizarEnTexto();
        RandomizarMulti();


        btnContinuar.GetComponent<Button>().interactable = false;
        correccionado.SetActive(false);
    }

    //public string tiempoMuestra;

    void Update()
    {
        
        timeResp();
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //CorrecciónDivi();
            CorrecciónMulti();
            //CorrecciónResta();
            //CorrecciónSuma();
            Correccionado();

            btnContinuar.GetComponent<Button>().interactable = true;
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

    public void CorrecciónSuma()
    {

        insertRes = (int.Parse(Respuesta.text));

        int res = randomnum + randomnum2;

    if (insertRes == res)
        {
            //Debug.Log("Respuesta correcta");

            string correcionando = ("Respuesta correcta");
            correccionando.text = correcionando;

        }
     
        else
        {
            //Debug.Log("Respuesta incorrecta");
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

        btnContinuar.GetComponent<Button>().interactable = false;

        //RandomizarDivi();
        //RandomizarEnTexto();
        // RandomizarResta();
        RandomizarMulti();
        

        string textReset = ("");
        correccionando.text = textReset;

        string InputReset = "";
        Respuesta.text = InputReset;

        //InttiempoMuestra = int.Parse(tiempoMuestra);
        //InttiempoMuestra = 0;


    }

    //private bool ActCorrec = false;
    public int counter = 10;
    public float timeToChange = 30;
    public float waitTime = 2;

    public void timeResp()
    {

        if (timeToChange < Time.time)
        {
            counter--;
            if (counter > 0)
            {
                txtTiempo.text = counter.ToString();
                timeToChange += waitTime;
            }
            else
            {
                txtTiempo.text = "Se acabo el tiempo";
            }
        }
        Debug.Log(counter);

    }
    public void RandomizarResta()
    {

        randomnum = Random.Range(maxInt, minInt);
        randomnum2 = Random.Range(randomnum, minInt);

        string n1text = randomnum.ToString();
        string n2text = randomnum2.ToString();

        N1Text.text = n1text + " -";
        N2Text.text = n2text + " =";
    }
    public void CorrecciónResta()
    {
        insertRes = (int.Parse(Respuesta.text));

        int res = randomnum - randomnum2;

        if (insertRes == res)
        {
            Debug.Log("Respuesta correcta");

            string correcionando = ("Respuesta correcta");
            correccionando.text = correcionando;

        }

        else
        {
            //Debug.Log("Respuesta incorrecta");
            string correcionando = ("Respuesta incorrecta");
            correccionando.text = correcionando;
        }

    }
    public void RandomizarMulti()
    {
        randomnum = Random.Range(minInt, maxInt);
        randomnum2 = Random.Range(minInt, maxInt);

        string n1text = randomnum.ToString();
        string n2text = randomnum2.ToString();

        N1Text.text = n1text + " x";
        N2Text.text = n2text + " =";
    }

    public void CorrecciónMulti()
    {
        insertRes = (int.Parse(Respuesta.text));

        int res = randomnum * randomnum2;

        if (insertRes == res)
        {
            Debug.Log("Respuesta correcta");

            string correcionando = ("Respuesta correcta");
            correccionando.text = correcionando;

        }

        else
        {
            //Debug.Log("Respuesta incorrecta");
            string correcionando = ("Respuesta incorrecta");
            correccionando.text = correcionando;
        }

    }

    public void RandomizarDivi()
    {

        
        
            maxInt = 50;
        minInt = 10;
            randomnum = Random.Range(maxInt, minInt);

            bool esPrimo = true;

            for (int i = 2; i < randomnum; i++)
            {

                if (randomnum % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo == true)
            {
                RandomizarDivi();
            }
        
       
            randomnum2 = Random.Range(randomnum/2, 2);


            bool esDivisor = true;

            for (int i = 1; i < randomnum2; i++)
            {

                if (randomnum % randomnum2 == 0)
                {
                    esDivisor = false;
                    break;
                }
            }

            if (esDivisor == true)
            {
                RandomizarDivi();
            }
        
        
        string n1text = randomnum.ToString();
        string n2text = randomnum2.ToString();

        N1Text.text = n1text + " /";
        N2Text.text = n2text + " =";
        
    }

    public void CorrecciónDivi()
    {

        insertRes = (int.Parse(Respuesta.text));

        int res = randomnum / randomnum2;

        if (insertRes == res)
        {
            Debug.Log("Respuesta correcta");

            string correcionando = ("Respuesta correcta");
            correccionando.text = correcionando;

        }

        else
        {
            //Debug.Log("Respuesta incorrecta");
            string correcionando = ("Respuesta incorrecta");
            correccionando.text = correcionando;
        }

    }


}
