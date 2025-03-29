using TMPro;
using UnityEngine;

public class Task152 : MonoBehaviour
{
    public GameObject Chislo;


    private int Order;

    private string[] VarChislo = new string[20] { "98", "66", "72", "88", "84", "78", "92", "100", "110", "140", "120", "80", "70", "60", "90", "130", "138", "146", "144", "150" };


    private string[] VarAnswer = new string[20] { "131", "147", "144", "136", "138", "141", "134", "130", "125", "110", "120", "140", "145", "150", "135", "115", "111", "102", "108", "105" };

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