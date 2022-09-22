using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public EnemyData enemydata;

    private void Start()
    {
        if(enemydata.derrotado == true)
        {
            Destroy(gameObject);
        }
    }
}
