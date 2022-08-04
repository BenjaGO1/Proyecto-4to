using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{    
    public GameObject Cuenta;
    public GameObject Heal;
    public GameObject Object;
    public GameObject Ataque;


    private void Start()
    {
        Cuenta.SetActive(false);
        Heal.SetActive(true);
        Object.SetActive(true);
        Ataque.SetActive(true);
    }
    
   
    public void Activar()
    {
        Cuenta.SetActive(true);
        Heal.SetActive(false);
        Object.SetActive(false);
        Ataque.SetActive(false);
    }

    public void Desactivar()
    {
        Cuenta.SetActive(false);
        Heal.SetActive(true);
        Object.SetActive(true);
        Ataque.SetActive(true);
    }
}
