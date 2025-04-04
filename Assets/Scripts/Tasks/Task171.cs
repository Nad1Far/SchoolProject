using TMPro;
using UnityEngine;

public class Task171 : MonoBehaviour
{
    public GameObject Chislo;

    private int Order;

    private string[] VarChislo = new string[15] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"},
    VarAnswer = new string[15] { "1", "4", "9", "16", "25", "36", "49", "64", "81", "100", "121", "144", "169", "196", "225" };


    void Task()
    {
        Order = Random.Range(0, 15);
        Chislo.transform.GetComponent<TMP_Text>().text = VarChislo[Order];

        TaskController.TaskAnswer = VarAnswer[Order];
    }

    void Close()
    {
        Chislo.transform.GetComponent<TMP_Text>().text = "";
    }
}