using TMPro;
using UnityEngine;

public class Task173 : MonoBehaviour
{
    public GameObject Chislo1;
    public GameObject Chislo2;


    private int Order;

    private string[] VarChislo1 = new string[20] { "2", "3", "4", "5", "6", "10", "8", "12", "6", "4", "8", "10", "7", "12", "15", "14", "3", "4", "10", "11" };
    private string[] VarChislo2 = new string[20] { "6", "4", "5", "10", "10", "12", "2", "5", "7", "3", "8", "11", "8", "5", "14", "13", "10", "18", "16", "10" };



    private int[] VarAnswer = new int[20] { 6, 6, 10, 25, 30, 60, 8, 30, 21, 6, 32, 55, 28, 30, 105, 91, 15, 36, 80, 55 };

    void Task()
    {
        Order = Random.Range(0, 20);
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