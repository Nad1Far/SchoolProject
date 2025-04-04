using TMPro;
using UnityEngine;

public class Task10 : MonoBehaviour
{
    public GameObject Chislo;

    private int Order;

    private string[] VarChislo = new string[25] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" },
        VarAnswer = new string[25] { "96", "92", "88", "84", "80", "76", "72", "68", "64", "60", "56", "52", "48", "44", "40", "36", "32", "28", "24", "20", "16", "12", "8", "4", "0"};


    void Task()
    {
        Order = Random.Range(0, 25);
        Chislo.transform.GetComponent<TMP_Text>().text = VarChislo[Order];
        
        TaskController.TaskAnswer = VarAnswer[Order];
    }

    void Close()
    {
        Chislo.transform.GetComponent<TMP_Text>().text = "";
    }
}