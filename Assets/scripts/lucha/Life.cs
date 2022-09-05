using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public int health = 40;
    public InputField Res;

    public bool correcta;
    public GameObject player;


    public Text Cuenta1;
    public Text Cuenta2;
    public Text operacion;

    int autodamage;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            esCorrecta();

            if (correcta == false)
            {
                damage();
            }

            if (health <= 0)
            {
                Die();
            }
        }
    }

    void Die()
    {
        Destroy(gameObject);
        // Invoke("CambioEscena",2);
    }

    void CambioEscena()
    {
        SceneManager.LoadScene("Primera pantalla");
    }
    int resul;

    void esCorrecta()
    {

        string N1 = Cuenta1.text;
        string N2 = Cuenta2.text;

        if (operacion.text == "x")
        {
            resul = int.Parse(N1) * int.Parse(N2);
        }
        else if (operacion.text == "+")
        {
            resul = int.Parse(N1) + int.Parse(N2);
        }
        else if (operacion.text == "-")
        {
            resul = int.Parse(N1) - int.Parse(N2);
        }
        else if (operacion.text == "/")
        {
            resul = int.Parse(N1) / int.Parse(N2);
        }

        string Resint = Res.text;

        if (resul == int.Parse(Resint))
        {
            correcta = true;
        }

    }
    void damage()
    {
        health -= resul;
        Debug.Log(health);
    }
}
