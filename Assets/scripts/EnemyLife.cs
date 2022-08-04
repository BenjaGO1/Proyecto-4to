using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLife : MonoBehaviour
{
    public float health = 50f;

    DamageCalc damageCalc;
    public GameObject res;

    public void awake()
    {
        damageCalc = res.GetComponent<DamageCalc>();

    }

    public void update()
    {
        damageCalc.GuardarRes();
        TakeDamage();
    }

    public void TakeDamage()
    {
            health -= damageCalc.dañoInt;
            //int barhealth = damageCalc.dañoInt * gameObject.transform.localScale * 100;
        if (health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Primera pantalla");
    }
}
