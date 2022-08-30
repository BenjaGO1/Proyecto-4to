using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyLife : MonoBehaviour
{
    public int health = 40;
    public InputField Res;
    public int daño;
    public string dañop;

    public GameObject enemy;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            dañop = Res.text;
            daño = int.Parse(dañop);
            health -= daño;
            Debug.Log(health);

            if (health <= 0)
            {
                Die();
            }
        }
     
    }

    void Die()
    {
        Destroy(gameObject);
       //SceneManager.LoadScene("Primera pantalla");
    }
}
