using TMPro;
using UnityEngine;

public class Task62 : MonoBehaviour
{
    public GameObject Chisl1;
    public GameObject Chisl2;
    public GameObject Znam1;
    public GameObject Znam2;

    private int Order;

    private string[] VarChisl1 = new string[20] { "3", "6", "5", "7", "10", "8", "9", "12", "13", "14", "4", "15", "2", "11", "16", "17", "19", "18", "1", "2" };
    private string[] VarZnam1 = new string[20]  { "1", "2", "1", "3", "5", "4", "3", "6", "7", "7", "2", "5", "1", "5", "8", "9", "10", "9", "1", "1" };


    private string[] VarChisl2 = new string[20] { "4", "8", "6", "9", "16", "10", "11", "15", "16", "17", "8", "18", "3", "14", "19", "18", "20", "17", "2", "3" };
    private string[] VarZnam2 = new string[20]  { "2", "4", "3", "6", "8", "5", "7", "10", "12", "13", "4", "9", "2", "7", "10", "11", "12", "8", "1", "1" };


    private int[] VarAnswer = new int[20] { 5, 5, 4, 4, 4, 3, 3, 3, 3, 2, 4, 4, 5, 3, 2, 2, 2, 2, 5, 5};

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