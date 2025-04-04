using TMPro;
using UnityEngine;

public class Task162 : MonoBehaviour
{
    public GameObject Chislo1, Chislo2;

    private int Order;

    private string[] VarChislo1 = new string[3] { "3", "6", "5"},
        VarChislo2 = new string[3] { "4", "8", "12"},
        VarAnswer = new string[3] { "1", "2", "1"};


    void Task()
    {
        Order = Random.Range(0, 3);
        Chislo1.transform.GetComponent<TMP_Text>().text = VarChislo1[Order];
        Chislo2.transform.GetComponent<TMP_Text>().text = VarChislo2[Order];

        Check.TaskAnswer = VarAnswer[Order];
    }

    void Close()
    {
        Chislo1.transform.GetComponent<TMP_Text>().text = "";
        Chislo2.transform.GetComponent<TMP_Text>().text = "";
    }
}