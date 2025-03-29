using TMPro;
using UnityEngine;

public class Task92 : MonoBehaviour
{
    public GameObject Chislo1;
    public GameObject Chislo2;


    private int Order;

    private string[] VarChislo1 = new string[20] { "6", "12", "18", "4", "8", "6", "16", "64", "36", "50", "99", "52", "14", "14", "18", "36", "34", "13", "20", "14" };
    private string[] VarChislo2 = new string[20] { "3", "4", "10", "3", "5", "7", "5", "9", "5", "11", "12", "14", "15", "15", "9", "13", "18", "14", "11", "2" };



    private string[] VarAnswer = new string[20] { "3", "4", "2", "2", "2", "1", "4", "8", "9", "5", "1", "4", "1", "1", "2", "3", "2", "1", "2", "14" };

    void Task()
    {
        Order = Random.Range(0, 20);
        Chislo1.transform.GetComponent<TMP_Text>().text = VarChislo1[Order];
        Chislo2.transform.GetComponent<TMP_Text>().text = VarChislo2[Order];
    }

    void Close()
    {
        Chislo1.transform.GetComponent<TMP_Text>().text = "";
        Chislo2.transform.GetComponent<TMP_Text>().text = "";
    }
}