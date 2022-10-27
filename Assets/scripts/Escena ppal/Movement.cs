﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float velocidadMovimiento = 20.0f;
    public float velocidadRotacion = 200.0f;
    public Animator anim;
    public float x, y;
    public int velCorrer;


    public Rigidbody rb;
    public float fuerzaDeSalto = 8f;
    public bool puedoSaltar;

    void Start()
    {
        Cursor.visible = false;
        puedoSaltar = false;
    }


    void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && puedoSaltar)
        {
            velocidadMovimiento = velCorrer;
            if (y > 0)
            {
                anim.SetBool("correr", true);
            }
            else
            {
                anim.SetBool("correr", false);
            }
        }
        else
        {
            anim.SetBool("correr", false);
        }



        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (puedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Salte", true);
                rb.AddForce(new Vector3(0, fuerzaDeSalto, 0), ForceMode.Impulse);
            }
            anim.SetBool("tocoSuelo", true);
        }


        else
        {
            EstoyCayendo();
        }
    }

    public void EstoyCayendo()
    {
        anim.SetBool("tocoSuelo", false);
        anim.SetBool("Salte", false);
    }



    //if (Input.GetKey(KeyCode.LeftShift))
    //{
    //    transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento * 2);
    //}

    private void OnCollisionEnter(Collision col)
    {

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
            velocidadMovimiento = 0;
            velocidadRotacion = 0;
            velCorrer = 0;
            PlayerPrefs.SetInt("valor", Other.gameObject.GetComponent<enemigo>().enemydata.orden);
            
        }

        //}
    }

}







