using TMPro;
using UnityEngine;

public class Task61 : MonoBehaviour
{
    public GameObject Chisl1;
    public GameObject Chisl2;
    public GameObject Znam1;
    public GameObject Znam2;

    void Task()
    {
        Chisl1.transform.GetComponent<TMP_Text>().text = "4";
    }
}
