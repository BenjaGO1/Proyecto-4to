using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Agent : MonoBehaviour
{
    public Transform destinationTransform;
    public NavMeshAgent agente;
    public Animator anim;
    public float DistanceToPLayer;
    
    // Start is called before the first frame update
    void Start()
    {
        agente.speed = 0;
        anim.SetBool("Idle", true);
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = destinationTransform.position;
        DistanceToPLayer = Vector3.Distance(transform.position, destinationTransform.position);
    }
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            agente.speed = 10;
            anim.SetBool("Idle", false);

            if (Vector3.Distance(transform.position, destinationTransform.position) <= 5)
            {
                SceneManager.LoadScene("Lucha");
                Debug.Log("Esta cerca el enemigo");
                
            }
        }
    }


}
