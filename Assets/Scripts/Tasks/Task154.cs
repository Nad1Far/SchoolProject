using TMPro;
using UnityEngine;

public class Task154 : MonoBehaviour
{
    public GameObject Chislo;


    private int Order;

    private string[] VarChislo = new string[20] { "32", "34", "36", "38", "40", "42", "44", "46", "48", "50", "52", "54", "56", "58", "60", "40", "36", "38", "60", "44" };


    private string[] VarAnswer = new string[20] { "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "20", "18", "19", "30", "22" };

    void Task()
    {
        Order = Random.Range(0, 20);
        Chislo.transform.GetComponent<TMP_Text>().text = VarChislo[Order];
    }

    void Close()
    {
        Chislo.transform.GetComponent<TMP_Text>().text = "";
    }
}