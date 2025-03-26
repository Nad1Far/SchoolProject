using TMPro;
using UnityEngine;

public class Task10 : MonoBehaviour
{
    public GameObject Chislo;


    private int Order;

    private string[] VarChislo = new string[25] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"};


    private string[] VarAnswer = new string[20] { "5", "5", "4", "4", "4", "3", "3", "3", "3", "2", "4", "4", "5", "3", "2", "2", "2", "2", "5", "5" };

    void Task()
    {
        Order = Random.Range(0, 20);
        Chislo.transform.GetComponent<TMP_Text>().text = VarChislo[Order];
    }

    void Close()
    {
        Chislo.transform.GetComponent<TMP_Text>().text = "";
    }
}