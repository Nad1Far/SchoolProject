using TMPro;
using UnityEngine;

public class Task91 : MonoBehaviour
{
    public GameObject Chisl;
    public GameObject Znam1;
    public GameObject Znam2;
    public GameObject RightChislo;

    private int Order;

    private string[] VarChisl = new string[10] {"6", "8", "12", "10", "15", "20", "4", "3", "1", "5"};
    private string[] VarZnam1 = new string[10] { "2", "2", "3", "4", "5", "7", "2", "2", "2", "2" };
    private string[] VarZnam2 = new string[10] { "3", "4", "4", "5", "6", "8", "3", "4", "3", "3" };
    private string[] VarRightChislo = new string[10] { "3", "1", "2", "1", "2", "3", "1", "1", "0", "1" };



    private string[] VarAnswer = new string[10] { "36", "20", "72", "70", "150", "328", "18", "10", "3", "21" };

    void Task()
    {
        Order = Random.Range(0, 10);
        Chisl.transform.GetComponent<TMP_Text>().text = VarChisl[Order];
        Znam1.transform.GetComponent<TMP_Text>().text = VarZnam1[Order];
        Znam2.transform.GetComponent<TMP_Text>().text = VarZnam2[Order];
        RightChislo.transform.GetComponent<TMP_Text>().text = VarRightChislo[Order];

        Debug.Log(Order);
        TaskController.TaskAnswer = VarAnswer[Order];
    }

    void Close()
    {
        Chisl.transform.GetComponent<TMP_Text>().text = "";
        Znam1.transform.GetComponent<TMP_Text>().text = "";
        Znam2.transform.GetComponent<TMP_Text>().text = "";
        RightChislo.transform.GetComponent<TMP_Text>().text = "";

    }
}