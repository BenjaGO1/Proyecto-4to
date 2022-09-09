﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SePuedeAgarrar : MonoBehaviour
{
    public bool seAgarra = true;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "agarrador")
        {
            other.GetComponentInParent<AgarraDeja>().quien = this.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "agarrador")
        {
            other.GetComponentInParent<AgarraDeja>().quien = null;
        }
    }
}
