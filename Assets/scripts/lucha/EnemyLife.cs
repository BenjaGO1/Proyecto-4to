using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EnemyLife : MonoBehaviour
{
    public int health = 100;
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
    public bool isPressed;

    public GameObject Elfo;
    public GameObject Ogro;
    public GameObject Duende;
    public EnemyData ogro;
    public EnemyData duende;
    public EnemyData elfo;


    public void Start()
    {
        if (PlayerPrefs.GetInt("valor") == 1)
        {
            datosenemigos = duende;
            enemyPrefab = Duende;

        }
        if (PlayerPrefs.GetInt("valor") == 2)
        {
            datosenemigos = elfo;
            enemyPrefab = Elfo;
        }
        if (PlayerPrefs.GetInt("valor") == 3)
        {
            datosenemigos = ogro;
            enemyPrefab = Ogro;
        }
    }


    public void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Return) && isPressed == false)
        {
            esCorrecta();
            isPressed = true;

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

    public void damage()
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
        Res.GetComponent<InputField>().interactable = false;

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
    public void reseteoBool()
    {
        isPressed = false;
    }

}