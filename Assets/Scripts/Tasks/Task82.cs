using TMPro;
using UnityEngine;

public class Task82 : MonoBehaviour
{
    public GameObject Chislo1;
    public GameObject Chislo2;


    private int Order;

    private string[] VarChislo1 = new string[17] { "2", "3", "4", "2", "7", "5", "6", "8", "7", "4", "4", "5", "3", "3", "3", "3", "2"};
    private string[] VarChislo2 = new string[17] { "25", "4", "6", "4", "2", "4", "3", "2", "1", "6", "3", "3", "5", "8", "7", "9", "13"};



    private string[] VarAnswer = new string[17] { "100", "36", "96", "16", "98", "100", "108", "128", "49", "96", "48", "75", "45", "72", "63", "81", "52" };

    void Task()
    {
        Order = Random.Range(0, 17);
        Chislo1.transform.GetComponent<TMP_Text>().text = VarChislo1[Order];
        Chislo2.transform.GetComponent<TMP_Text>().text = VarChislo2[Order];

        TaskController.TaskAnswer = VarAnswer[Order];
    }

    void Close()
    {
        Chislo1.transform.GetComponent<TMP_Text>().text = "";
        Chislo2.transform.GetComponent<TMP_Text>().text = "";
    }
}