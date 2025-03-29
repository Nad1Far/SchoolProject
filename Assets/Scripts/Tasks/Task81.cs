using TMPro;
using UnityEngine;

public class Task81 : MonoBehaviour
{
    public GameObject Chislo1;
    public GameObject Chislo2;
    public GameObject Chislo3;


    private int Order;

    private string[] VarChislo1 = new string[20] {"4", "16", "36", "25", "49", "64", "9", "4", "2", "2", "9", "16", "16", "16", "3", "36", "4", "49", "25", "4"};
    private string[] VarChislo2 = new string[20] {"9", "9", "4", "16", "9", "9", "36", "25", "18", "4", "4", "64", "36", "6", "25", "4", "8", "25", "25", "16"};
    private string[] VarChislo3 = new string[20] {"25", "4", "9", "9", "4", "4", "16", "36", "25", "50", "25", "49", "9", "6", "3", "9", "2", "4", "100", "49"};


    private string[] VarAnswer = new string[20] { "30", "24", "72", "60", "84", "96", "72", "60", "20", "30", "48", "80", "30", "21", "30", "24", "16", "70", "80", "70" };

    void Task()
    {
        Order = Random.Range(0, 20);
        Chislo1.transform.GetComponent<TMP_Text>().text = VarChislo1[Order];
        Chislo2.transform.GetComponent<TMP_Text>().text = VarChislo2[Order];
        Chislo3.transform.GetComponent<TMP_Text>().text = VarChislo3[Order];

        TaskController.TaskAnswer = VarAnswer[Order];
    }

    void Close()
    {
        Chislo1.transform.GetComponent<TMP_Text>().text = "";
        Chislo2.transform.GetComponent<TMP_Text>().text = "";
        Chislo3.transform.GetComponent<TMP_Text>().text = "";
    }
}