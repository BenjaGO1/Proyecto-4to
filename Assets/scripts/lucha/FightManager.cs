using System.Collections;
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
    public EnemyLife enemylife;
    void Start()
    {
        
        if (PlayerPrefs.GetInt("valor") == 1)
        {
            Instantiate(Duende, new Vector3(12, 2, 13), Quaternion.identity);
            enemylife.datosenemigos = duende;
            enemylife.enemyPrefab = Duende;
        }
        if (PlayerPrefs.GetInt("valor") == 2)
        {
            Instantiate(Elfo, new Vector3(12, 2, 13), Quaternion.identity);
            enemylife.datosenemigos = elfo;
            enemylife.enemyPrefab = Elfo;
        }
        if (PlayerPrefs.GetInt("valor") == 3)
        {
            Instantiate(Ogro, new Vector3(12, 2, 13), Quaternion.identity);
            enemylife.datosenemigos = ogro;
            enemylife.enemyPrefab = Ogro;
        }
    }

    
    void Update()
    {
        
    }
}
