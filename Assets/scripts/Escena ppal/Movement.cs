using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    public float WalkSpeed;
    public float RunSpeed;
    public float jumpForce;
    public int maxJumps;
    public int counter = 2;

    int hasJump;
    Rigidbody rb;
    

    void Start()
    {
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, WalkSpeed);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(0, 0, RunSpeed);

            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -WalkSpeed);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(0, 0, -RunSpeed);

            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(WalkSpeed, 0, 0);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(RunSpeed, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-WalkSpeed, 0, 0);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(-RunSpeed, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.Space) && hasJump > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump--;
        }
        if (transform.position.y <= -1)
        {
            transform.position=new Vector3(0, 1, 0);
            transform.eulerAngles=new Vector3(0, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ground")
        {
            hasJump = maxJumps;
        }
        if (col.gameObject.tag == "Enemigo")
        {
            PlayerPrefs.SetInt("valor", col.gameObject.GetComponent<enemigo>().enemydata.orden);
            //SceneManager.LoadScene("Lucha");
        }
    }
    private void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Enemigo")
        {
            WalkSpeed = 0;
            RunSpeed = 0;
            PlayerPrefs.SetInt("valor", Other.gameObject.GetComponent<enemigo>().enemydata.orden);
            //SceneManager.LoadScene("Lucha");
        }

    }        
    
}
