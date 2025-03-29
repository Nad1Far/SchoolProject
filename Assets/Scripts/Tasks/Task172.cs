using TMPro;
using UnityEngine;

public class Task172 : MonoBehaviour
{
    public GameObject Chislo1;
    public GameObject Chislo2;
    public GameObject Znam;

    private int Order;

    private string[] VarChislo1 = new string[20] { "3", "3", "2", "2", "4", "3", "4", "5", "2", "3", "5", "4", "6", "7", "6", "9", "10", "11", "12", "13" };
    private string[] VarChislo2 = new string[20] { "2", "5", "4", "3", "6", "4", "8", "8", "1", "6", "3", "2", "6", "12", "9", "8", "10", "15", "12", "12" };
    private string[] VarZnam = new string[20] { "2", "3", "4", "2", "3", "4", "4", "4", "2", "3", "3", "2", "3", "4", "3", "4", "5", "5", "2", "2" };





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
