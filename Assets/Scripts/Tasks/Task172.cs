using TMPro;
using UnityEngine;

public class Task172 : MonoBehaviour
{
    public GameObject Chislo1;
    public GameObject Chislo2;
    public GameObject Znam;

    private int Order;

    private string[] VarChislo1 = new string[20] { "3", "6", "5", "7", "10", "8", "9", "12", "13", "14", "4", "15", "2", "11", "16", "17", "19", "18", "1", "2" };
    private string[] VarChislo2 = new string[20] { "4", "8", "6", "9", "12", "10", "11", "15", "16", "17", "8", "18", "3", "14", "19", "18", "20", "17", "2", "3" };
    private string[] VarZnam = new string[20] { "1", "2", "1", "3", "5", "4", "3", "6", "7", "7", "2", "5", "1", "5", "8", "9", "10", "9", "1", "1" };





    private string[] VarAnswer = new string[20] { "5", "5", "4", "4", "4", "3", "3", "3", "3", "2", "4", "4", "5", "3", "2", "2", "2", "2", "5", "5" };

    void Task()
    {
        Order = Random.Range(0, 20);
        Chislo1.transform.GetComponent<TMP_Text>().text = VarChislo1[Order];
        Chislo2.transform.GetComponent<TMP_Text>().text = VarChislo2[Order];
        Znam.transform.GetComponent<TMP_Text>().text = VarZnam[Order];
    }

    void Close()
    {
        Chislo1.transform.GetComponent<TMP_Text>().text = "";
        Chislo2.transform.GetComponent<TMP_Text>().text = "";
        Znam.transform.GetComponent<TMP_Text>().text = "";
    }
}
