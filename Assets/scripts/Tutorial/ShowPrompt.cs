﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPrompt : MonoBehaviour
{

    public Canvas EPromptCanvas;
    public GameObject Eprompt;
    private bool trigger = false;




    void Update()
    {
        if (Input.GetKey(KeyCode.E) && trigger == true)
        {
            Eprompt.SetActive(true);
        }
        
    }

    void OnTriggerEnter(Collider ElTrigger)
    {
        if(ElTrigger.tag == "Player")
        {
            Debug.Log("Estas cerca del NPC");
            EPromptCanvas.enabled = true;
            trigger = true;
            
        }
        
    }
    void OnTriggerExit(Collider SalirTrigger)
    {
        if (SalirTrigger.tag == "Player")
        {
            Debug.Log("Estas lejos del NPC" + SalirTrigger.gameObject);
            EPromptCanvas.enabled = false;
        }
            
    }
}
