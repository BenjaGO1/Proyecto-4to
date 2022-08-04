using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageCalc : MonoBehaviour
{

    private string daño;
    public InputField Res;


    public void GuardarRes()
    {
        daño = Res.text;
        Debug.Log(daño);
    }
}