using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public GameObject Pause;
    public bool ayuda = false;
    public bool ShowCursor;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            ayuda = true;
        }
        if (ayuda == true)
        {
            Pause.SetActive(true);
            Cursor.visible = true;
        }
    }
}
