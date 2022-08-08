using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EligeCuenta : MonoBehaviour
{
    public Text N1Text;
    public Text N2Text;

    public int minInt = 1;
    public int maxInt = 10;

    public int randomnum;
    public int randomnum2;


    public void Start()
    {
        randomnum = Random.Range(minInt, maxInt);
        //Debug.Log(randomnum + "+");

        string n1text = randomnum.ToString();
    
        randomnum2 = Random.Range(minInt, maxInt);
        //Debug.Log(randomnum2 + "=");

        string n2text = randomnum2.ToString();

        
        N1Text.text = n1text + " +";
        N2Text.text = n2text + " =";
    }

   

}
