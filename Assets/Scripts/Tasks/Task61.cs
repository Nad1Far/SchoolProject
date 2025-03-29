using TMPro;
using UnityEngine;

public class Task61 : MonoBehaviour
{
    public GameObject Chisl1;
    public GameObject Chisl2;
    public GameObject Znam1;
    public GameObject Znam2;

    private int Order;

    private string[] VarChisl1 = new string[20] { "12", "18", "20", "24", "15", "30", "36", "40", "28", "32", "54", "42", "36", "60", "45" ,"70", "16", "20", "28", "50" };
    private string[] VarZnam1 = new string[20]  { "3", "2", "4", "6", "3", "5", "6", "5", "7", "4", "9", "7", "6", "12", "9", "10", "4", "2", "4", "5" };


    private string[] VarChisl2 = new string[20] { "18", "6", "10", "8", "6", "30", "12", "20", "42", "30", "36", "24", "48", "40", "30", "64", "12", "20", "24", "40" };
    private string[] VarZnam2 = new string[20]  { "6", "3", "2", "4", "2", "6", "3", "4", "7", "5", "6", "4", "3", "5", "6", "4", "3", "2", "2", "5" };


    private int[] VarAnswer = new int[20] { 7, 11, 10, 6, 8, 11, 10, 13, 10, 14, 12, 12, 22, 13, 10, 23, 8, 20, 19, 18 };

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
