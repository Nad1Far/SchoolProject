using TMPro;
using UnityEngine;

public class Task161 : MonoBehaviour
{
    public GameObject Chislo;


    private int Order;

    private string[] VarChislo = new string[21] { "32", "34", "36", "38", "40", "42", "44", "46", "48", "50", "52", "54", "56", "58", "60", "62", "64", "66", "68", "70", "72" };


    private string[] VarAnswer = new string[21] { "32", "34", "36", "38", "40", "42", "44", "46", "48", "50", "52", "54", "56", "58", "60", "62", "64", "66", "68", "70", "72" };

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