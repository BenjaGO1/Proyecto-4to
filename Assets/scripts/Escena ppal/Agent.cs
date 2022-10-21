using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    public Transform destinationTransform;
    public NavMeshAgent agente;
    
    // Start is called before the first frame update
    void Start()
    {
        agente.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = destinationTransform.position;
    }
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            agente.speed = 3.5f;
        }
    }
}
