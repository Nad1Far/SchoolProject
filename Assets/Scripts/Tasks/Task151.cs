using TMPro;
using UnityEngine;

public class Task151 : MonoBehaviour
{
    public GameObject Chislo1;
    public GameObject Chislo2;


    private int Order;

    private string[] VarChislo1 = new string[20] { "65", "60", "70", "60", "70", "65", "70", "60", "65", "70", "70", "70", "60", "60", "60", "60", "70", "60", "65", "85" };
    private string[] VarChislo2 = new string[20] { "80", "80", "72", "88", "73", "73", "74", "74", "82", "60", "80", "70", "60", "74", "62", "50", "75", "40", "50", "60" };



    private int[] VarAnswer = new int[20] { 35, 40, 38, 32, 37, 52, 36, 14, 21, 27, 30, 40, 60, 46, 58, 70, 35, 80, 65, 35 };

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