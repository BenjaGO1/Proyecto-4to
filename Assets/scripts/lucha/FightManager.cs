using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    //public Transform SpawnerPoint;
    public GameObject Elfo;
    public GameObject Ogro;
    public GameObject Duende;
    void Start()
    {
        if(PlayerPrefs.GetInt("valor") == 1)
        {
            Instantiate(Duende, new Vector3(12, 2, 0), Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("valor") == 2)
        {
            Instantiate(Elfo, new Vector3(12, 2, 0), Quaternion.identity);
        }
        if (PlayerPrefs.GetInt("valor") == 3)
        {
            Instantiate(Ogro, new Vector3(12, 2, 0), Quaternion.identity);
        }
    }

    
    void Update()
    {
        
    }
}
