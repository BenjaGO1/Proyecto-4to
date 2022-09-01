using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyLife : MonoBehaviour
{
    public int health = 40;
    public InputField Res;
    public int daño;
    public string dañop;

    public bool correcta2;
    public GameObject enemy;

    public void awake()
    {
        
    }

    public void Update()
    {
        //EligeCuenta correctan = GetComponent<EligeCuenta>();
        //correcta2 = correctan.correcta;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            //if (correcta2 == true)
            //{
                damage();
            //}
            
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
        Debug.Log(health);
    }

    void Die()
    {
        Destroy(gameObject);
        Invoke("CambioEscena",2);
    }

    void CambioEscena()
    {
        SceneManager.LoadScene("Primera pantalla");
    }
}
