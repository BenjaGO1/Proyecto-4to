using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    public float movementSpeed;
    public float rotationSpeed;
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
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D) && hasJump > 0)
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A) && hasJump > 0)
        {
            transform.Rotate(0, -rotationSpeed, 0);
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
    }
}
