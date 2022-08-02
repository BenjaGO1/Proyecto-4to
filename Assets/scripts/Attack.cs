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
    public GameObject Enter;


    private void Start()
    {
        Cuenta.SetActive(false);
        Heal.SetActive(true);
        Object.SetActive(true);
        Ataque.SetActive(true);
        Enter.SetActive(false);
    }
    
   
    public void Activar()
    {
        Cuenta.SetActive(true);
        Heal.SetActive(false);
        Object.SetActive(false);
        Ataque.SetActive(false);
        Enter.SetActive(true);
    }

    public void Desactivar()
    {
        Cuenta.SetActive(false);
        Heal.SetActive(true);
        Object.SetActive(true);
        Ataque.SetActive(true);
        Enter.SetActive(false);
    }
}
