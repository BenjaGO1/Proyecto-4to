﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageCalc : MonoBehaviour
{

   
    public InputField Res;
    public string daño;
    public int dañoInt;



    public void GuardarRes()
    {
        daño = Res.text;
        dañoInt = int.Parse(daño);
        Debug.Log(dañoInt);
    }
}