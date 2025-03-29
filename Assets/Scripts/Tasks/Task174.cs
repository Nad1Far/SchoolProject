using TMPro;
using UnityEngine;

public class Task174 : MonoBehaviour
{
    public GameObject Chislo1;
    public GameObject Chislo2;


    private int Order;

    private string[] VarChislo1 = new string[9] { "2", "2", "3", "4", "5", "4", "6", "3", "3"};
    private string[] VarChislo2 = new string[9] { "4", "6", "5", "8", "9", "10", "10", "7", "11"};



    private string[] VarAnswer = new string[9] { "3", "8", "4", "12", "14", "21", "16", "10", "28"};

    void Task()
    {
        Order = Random.Range(0, 9);
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