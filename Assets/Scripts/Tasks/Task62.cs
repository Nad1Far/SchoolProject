using TMPro;
using UnityEngine;

public class Task62 : MonoBehaviour
{
    public GameObject Chisl1;
    public GameObject Chisl2;
    public GameObject Znam1;
    public GameObject Znam2;

    private int Order;

    private string[] VarChisl1 = new string[20] { "3", "6", "5", "18", "10", "8", "9", "18", "21", "14", "4", "15", "25", "45", "16", "81", "70", "18", "18", "2" };
    private string[] VarZnam1 = new string[20]  { "1", "2", "1", "3", "5", "4", "3", "6", "7", "7", "2", "5", "10", "5", "8", "9", "10", "9", "3", "1" };


    private string[] VarChisl2 = new string[20] { "4", "8", "6", "12", "16", "10", "14", "15", "16", "26", "8", "18", "3", "14", "20", "18", "20", "16", "2", "84" };
    private string[] VarZnam2 = new string[20]  { "2", "4", "3", "6", "8", "5", "7", "5", "8", "13", "4", "9", "2", "7", "10", "6", "4", "8", "1", "42" };


    private string[] VarAnswer = new string[20] { "1", "1", "3", "4", "0", "0", "1", "0", "1", "0", "0", "1", "1", "7", "0", "6", "2", "0", "4", "0"};

    void Task()
    {
        Order = Random.Range(0, 20);
        Chisl1.transform.GetComponent<TMP_Text>().text = VarChisl1[Order];
        Znam1.transform.GetComponent<TMP_Text>().text = VarZnam1[Order];
        Chisl2.transform.GetComponent<TMP_Text>().text = VarChisl2[Order];
        Znam2.transform.GetComponent<TMP_Text>().text = VarZnam2[Order];

        TaskController.TaskAnswer = VarAnswer[Order];
    }

    void Close()
    {
        Chisl1.transform.GetComponent<TMP_Text>().text = "";
        Znam1.transform.GetComponent<TMP_Text>().text = "";
        Chisl2.transform.GetComponent<TMP_Text>().text = "";
        Znam2.transform.GetComponent<TMP_Text>().text = "";
    }
}