using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public bool activate = false;
    public bool botones = true;
    public GameObject Cuenta;
    public GameObject Heal;
    public GameObject Object;
    public GameObject Ataque;


    private void Update()
    {
        if (activate == false)
        {
            Cuenta.SetActive(false);
        }
        if(activate == true)
        {
            Cuenta.SetActive(true);
        }
        if (botones == false)
        {
            Heal.SetActive(false);
            Object.SetActive(false);
            Ataque.SetActive(false);
        }
        if (botones == true)
        {
            Heal.SetActive(true);
            Object.SetActive(true);
            Ataque.SetActive(true);
        }
    }
    
   
    public void Activar()
    {
        activate = true;
        botones = false;
    }

}
