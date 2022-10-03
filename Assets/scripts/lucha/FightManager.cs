﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    //public Transform SpawnerPoint;
    public GameObject Elfo;
    public GameObject Ogro;
    public GameObject Duende;
    public EnemyData ogro;
    public EnemyData duende;
    public EnemyData elfo;
    public GameObject enemylife;
    void Start()
    {
        enemylife.GetComponent<EnemyLife>();
        if (PlayerPrefs.GetInt("valor") == 1)
        {
            Instantiate(Duende, new Vector3(14, 0, 14), Quaternion.identity);
            
            
        }
        if (PlayerPrefs.GetInt("valor") == 2)
        {
            Instantiate(Elfo, new Vector3(14, 0, 14), Quaternion.identity);
            
        }
        if (PlayerPrefs.GetInt("valor") == 3)
        {
            Instantiate(Ogro, new Vector3(14, 0, 14), Quaternion.identity);
            
        }
    }

    
    void Update()
    {
        
    }
}
