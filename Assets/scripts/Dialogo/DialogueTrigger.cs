using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogobox;
    public Movement movimiento;
    public CursorLookAt miralo;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            dialogobox.SetActive(true);
            movimiento.WalkSpeed = 0;
            movimiento.RunSpeed = 0;
            movimiento.jumpForce = 0;
            miralo.Sensitivity = 0;
        }

    }
}
