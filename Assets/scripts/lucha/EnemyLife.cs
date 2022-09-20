using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EnemyLife : MonoBehaviour
{
    public int health = 40;
    public EnemyData datosenemigos;
    public GameObject enemyPrefab;
    public InputField Res;
    int daño;
    string dañop;

    public bool correcta;
   
    public Text Cuenta1;
    public Text Cuenta2;
    public Text operacion;
    private string N1;
    private string N2;


    public void Start()
    {
        datosenemigos.derrotado = false;
    }


    public void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Return))
        {
            esCorrecta();

            if (correcta == true)
            {
                damage();
            }

            if (health <= 0)
            {
                Die();
            }
        }
    }

    void damage()
    {
        dañop = Res.text;
        daño = int.Parse(dañop);
        health -= daño;
       //Debug.Log(health);
    }

    void Die()
    {
        datosenemigos.derrotado = true;
        DestroyImmediate(enemyPrefab, true);
        StartCoroutine(CambiandoEscena());
    }
    IEnumerator CambiandoEscena()
    {
        yield return new WaitForSeconds(2);
        CambioEscena();
    }

    void CambioEscena()
    {
        SceneManager.LoadScene("Primera pantalla");
    }
    int resul;

    public void esCorrecta()
    {
        N1 = Cuenta1.text;
        N2 = Cuenta2.text;

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

}
