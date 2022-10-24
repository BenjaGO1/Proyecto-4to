using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager1 : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;
    public Movement movimiento;
    public CursorLookAt lookAt;
    public GameObject fondo;

    public Queue<string> sentences;
    


    void Start()
    {
        sentences = new Queue<string>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        
        nameText.text = dialogue.name; 

        sentences.Clear();

        movimiento.WalkSpeed = 0;
        movimiento.RunSpeed = 0;
        lookAt.Sensitivity = 0;
        Cursor.visible = true;

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);    
        }
        
        
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            Debug.Log("fin dialogo");
            return;
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentences.Count);
        dialogueText.text = sentence;
    }
    void EndDialogue()
    {
        movimiento.WalkSpeed = 0.3f;
        movimiento.RunSpeed = 0.6f;
        lookAt.Sensitivity = 8;
        Cursor.visible = false;
        fondo.SetActive(false);
    }

}
