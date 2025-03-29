using TMPro;
using UnityEngine;

public class Task153 : MonoBehaviour
{
    public GameObject Chislo;


    private int Order;

    private string[] VarChislo = new string[20] { "4", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36", "38", "40", "42" };


    private int[] VarAnswer = new int[20] {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21};

    void Task()
    {
        Order = Random.Range(0, 20);
        Chislo.transform.GetComponent<TMP_Text>().text = VarChislo[Order];

        TaskController.TaskAnswer = VarAnswer[Order];
    }

    void Close()
    {
        Chislo.transform.GetComponent<TMP_Text>().text = "";
    }
}