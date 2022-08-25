//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class timeAnswer : MonoBehaviour
//{
//    public Text txtTiempo;

//    public bool isCounting;
//    float time;
//    int ayuda;
//    public GameObject btnContinuar;

//    public void start()
//    {
//        time = 10;
//        isCounting = false;
//    }
//    public void update()
//    {
//        timeResp();
//    }

//    public void timeResp()
//    {

//        if (isCounting == true)
//        {
//            txtTiempo.text = Mathf.Floor(time).ToString();
            
//            time -= Time.deltaTime;
//            Debug.Log(time);
           
//            if (time <= 0)
//            {
//                txtTiempo.text = "Se te acabo el tiempo";
//                isCounting = false;
//                btnContinuar.GetComponent<Button>().interactable = true;
//                Debug.Log("Se acabo el tiempo");
//            }
//        }
//    }
//    public void tocaBoton()
//    {
//        isCounting = true;
//        btnContinuar.GetComponent<Button>().interactable = true;
//    }
//    public void Continua()
//    {
//        btnContinuar.GetComponent<Button>().interactable = false;
//        time = 10;
//    }

//    }
