using TMPro;
using UnityEngine;

public class Task63 : MonoBehaviour
{
    public GameObject Chisl1;
    public GameObject Chisl2;
    public GameObject Znam1;

    private int Order;

    private string[] VarChisl1 = new string[20] { "5", "8", "9", "7", "10", "8", "11", "14", "13", "12", "16", "15", "19", "18", "14", "10", "17", "9", "24", "10" };
    private string[] VarZnam1 = new string[20] { "2", "2", "3", "1", "2", "2", "2", "2", "1", "2", "4", "3", "2", "3", "2", "2", "1", "1", "2", "2" };


    private string[] VarChisl2 = new string[20] { "1", "4", "3", "2", "4", "2", "5", "8", "7", "6", "8", "9", "15", "12", "4", "0", "12", "4", "8", "4" };


    private string[] VarAnswer = new string[20] { "2", "2", "2", "5", "3", "3", "3", "3", "4", "3", "2", "2", "2", "2", "5", "5", "5", "5", "8", "3" };

    void Task()
    {
        Order = Random.Range(0, 20);
        Chisl1.transform.GetComponent<TMP_Text>().text = VarChisl1[Order];
        Znam1.transform.GetComponent<TMP_Text>().text = VarZnam1[Order];
        Chisl2.transform.GetComponent<TMP_Text>().text = VarChisl2[Order];

        TaskController.TaskAnswer = VarAnswer[Order];
    }

    void Close()
    {
        Chisl1.transform.GetComponent<TMP_Text>().text = "";
        Znam1.transform.GetComponent<TMP_Text>().text = "";
        Chisl2.transform.GetComponent<TMP_Text>().text = "";
    }
}