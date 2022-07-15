using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renaudar : MonoBehaviour
{
    public GameObject Pause;
    public bool despausa = false;

    public void Volver()
    {
        despausa = true;
    }


    private void Update()
    {
        if(despausa == true)
        {
            Pause.SetActive(true);
        }
    }

    
}
