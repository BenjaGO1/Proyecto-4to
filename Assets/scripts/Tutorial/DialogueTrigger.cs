using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialogo;
    public DialogueManager1 dialogueManager1;
    public Dialogue dialogue;
    public GameObject canvasDialogo;
    
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.E) && canvasDialogo.activeInHierarchy)
        {
            TriggerDialogue();
            dialogo.SetActive(true);
            Debug.Log("funca");
        }
    }

    public void TriggerDialogue()
    {
        //FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        dialogueManager1.StartDialogue(dialogue);
    }



    private void OnCollisionEnter(Collision col)
    {
        //if (col.gameObject.name == "tutor" && Input.GetKey(KeyCode.E))
        //{
        //    TriggerDialogue();
        //    dialogo.SetActive(true);
        //    Debug.Log("funca");
        //}
    }
}
