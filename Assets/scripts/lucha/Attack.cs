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
   // EligeCuenta eligecuenta;
    public GameObject Lugar;


    private void awake()
    {
      // eligecuenta = Lugar.GetComponent<EligeCuenta>();
    }

    private void Start()
    {
        Cuenta.SetActive(false);
        Heal.SetActive(true);
        Object.SetActive(true);
        Ataque.SetActive(true);
        //eligecuenta.timeResp();
        
    }


    public void Activar()
    {
        Cuenta.SetActive(true);
        Heal.SetActive(false);
        Object.SetActive(false);
        Ataque.SetActive(false);
       // eligecuenta.isCounting = true;
    }

    public void Desactivar()
    {
        Cuenta.SetActive(false);
        Heal.SetActive(true);
        Object.SetActive(true);
        Ataque.SetActive(true);
        //eligecuenta.isCounting = false;
    }
}
