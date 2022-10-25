using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogeManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueUI;
    public Text textoDelDialogo;
    public GameObject fondo;
    
    
    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            
            dialogueUI.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                textoDelDialogo.text = "Hola viajero";
            }
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            dialogueUI.SetActive(false);
        }
    }
}
