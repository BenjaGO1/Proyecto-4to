using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyLife : MonoBehaviour
{
    public int health = 40;
    public InputField Res;
    int daño;
    string dañop;

    public bool correcta2;
    public GameObject enemy;
    public EligeCuenta eligeCuenta;
    public GameObject go;

    void Start()
    {
        go = GameObject.FindGameObjectWithTag("Finish");
        eligeCuenta = GameObject.FindGameObjectWithTag("Finish").GetComponent<EligeCuenta>();
    }

    public void Update()
    {

        if (eligeCuenta.correcta == true)
        {
            damage();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {

            Debug.Log(eligeCuenta.correcta);

            if (correcta2 == true)
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
