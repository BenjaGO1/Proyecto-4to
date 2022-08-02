using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volver : MonoBehaviour
{
    public bool activate = true;
    public bool botones = false;
    public GameObject inventario;
    public GameObject Heal;
    public GameObject Object;
    public GameObject Ataque;
    public GameObject Escape;
    public GameObject Volver2;




    void Update()
    {
        if (activate == true)
        {
            inventario.SetActive(true);
        }

        if (activate == false)
        {
            inventario.SetActive(false);
        }
        if (botones == false)
        {
            Heal.SetActive(false);
            Object.SetActive(false);
            Ataque.SetActive(false);
            Escape.SetActive(false);
            Volver2.SetActive(true);
        }
        if (botones == true)
        {
            Heal.SetActive(true);
            Object.SetActive(true);
            Ataque.SetActive(true);
            Escape.SetActive(true);
            Volver2.SetActive(false);
        }
    }

    public void Activar()
    {
        activate = false;
        botones = true;
    }
}
