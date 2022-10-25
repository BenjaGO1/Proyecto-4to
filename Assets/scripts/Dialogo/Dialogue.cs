using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject DialogueBox;
    public Movement movimiento;
    public CursorLookAt miralo;
    public bool PasaronCosas;

    private int index;
    
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
        PasaronCosas = false;
}

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }
    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
        
    }

    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if(index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }

        else
        {
            DialogueBox.SetActive(false);
            textComponent.enabled = false;
            movimiento.WalkSpeed = 0.3f;
            movimiento.RunSpeed = 0.6f;
            movimiento.jumpForce = 6;
            miralo.Sensitivity = 8;
            PasaronCosas = true;
        }
    }
}
