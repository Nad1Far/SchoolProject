using TMPro;
using UnityEngine;

public class Task175 : MonoBehaviour
{
    public GameObject Chislo1, Chislo2;

    private int Order;

    private string[] VarChislo1 = new string[19] { "2", "2", "2", "2", "3", "3", "3", "4", "4", "4", "5", "5", "5", "6", "6", "7", "8", "9", "10" },
        VarChislo2 = new string[19] { "3", "4", "5", "6", "5", "6", "7", "5", "6", "7", "6", "7", "8", "8", "9", "10", "12", "8", "12" },
        VarAnswer = new string[19] { "6", "8", "10", "12", "15", "18", "21", "20", "24", "28", "30", "35", "40", "48", "54", "70", "96", "72", "120" };


    void Task()
    {
        Order = Random.Range(0, 19);
        Chislo1.transform.GetComponent<TMP_Text>().text = VarChislo1[Order];
        Chislo2.transform.GetComponent<TMP_Text>().text = VarChislo2[Order];

        TaskController.TaskAnswer = VarAnswer[Order];
    }

    void Close()
    {
        Chislo1.transform.GetComponent<TMP_Text>().text = "";
        Chislo2.transform.GetComponent<TMP_Text>().text = "";
    }
}