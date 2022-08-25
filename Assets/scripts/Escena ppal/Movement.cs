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
            if (Input.GetKey(KeyCode.LeftShift) && hasJump > 0)
            {
                transform.Translate(0, 0, RunSpeed);

            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -WalkSpeed);
            if (Input.GetKey(KeyCode.LeftShift) && hasJump > 0)
            {
                transform.Translate(0, 0, -RunSpeed);

            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(WalkSpeed, 0, 0);
            if (Input.GetKey(KeyCode.LeftShift) && hasJump > 0)
            {
                transform.Translate(RunSpeed, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-WalkSpeed, 0, 0);
            if (Input.GetKey(KeyCode.LeftShift) && hasJump > 0)
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

    public GameObject DialogoTuto;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ground")
        {
            hasJump = maxJumps;
        }
        if (col.gameObject.name == "enemigo")
        {
            SceneManager.LoadScene("Lucha");
        }
    }
    

}
