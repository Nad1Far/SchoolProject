using TMPro;
using UnityEngine;

public class Task91 : MonoBehaviour
{
    public GameObject Chisl1;
    public GameObject Znam1;
    public GameObject Znam2;
    public GameObject RightChislo;

    private int Order;

    private string[] VarChisl1 = new string[10] {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0"};
    private string[] VarZnam1 = new string[10] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };


    private string[] VarChisl2 = new string[10] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
    private string[] VarZnam2 = new string[10] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };


    private string[] VarAnswer = new string[10] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };

    void Task()
    {
        Order = Random.Range(0, 10);


        Debug.Log(VarChisl1[Order]);
        Debug.Log(VarZnam1[Order]);
        Debug.Log(VarChisl2[Order]);
        Debug.Log(VarZnam2[Order]);


        Chisl1.transform.GetComponent<TMP_Text>().text = VarChisl1[Order];
        Znam1.transform.GetComponent<TMP_Text>().text = VarZnam1[Order];
        RightChislo.transform.GetComponent<TMP_Text>().text = VarChisl2[Order];
        Znam2.transform.GetComponent<TMP_Text>().text = VarZnam2[Order];
    }

    void Close()
    {
        Chisl1.transform.GetComponent<TMP_Text>().text = "";
        Znam1.transform.GetComponent<TMP_Text>().text = "";
        RightChislo.transform.GetComponent<TMP_Text>().text = "";
        Znam2.transform.GetComponent<TMP_Text>().text = "";
    }
}