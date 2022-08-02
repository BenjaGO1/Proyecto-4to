using UnityEngine;
using UnityEngine.UI;

public class Randomizar : MonoBehaviour
{
    public Text largeText;
    public int maxInt = 9;

    public void BtnAction()
    {
        //largeText.text = ;
    }

    public void CuentaRandom ()
    {
        int randomnum = Random.Range(1, maxInt + 1);
        Debug.Log(randomnum);
    }
    public void CuentaRandom2()
    {
        int randomnum2 = Random.Range(1, maxInt + 1);
        Debug.Log(randomnum2);
    }
}
