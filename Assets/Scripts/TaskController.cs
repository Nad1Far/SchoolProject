using TMPro;
using Unity.Multiplayer.Center.Common;
using UnityEngine;
using UnityEngine.UI;


public class TaskController : MonoBehaviour
{
    public GameObject Tasks;
    public GameObject InputText;
    public Image ColorBox;

    private string MyText;

    private int randomChild;
    private int randomRandomChild;
    private int CountChild;

    private int InputAnswer;
    public static int TaskAnswer;

    private int[] lastTask = new int[2];

    private void Start()
    {
        CountChild = Tasks.transform.childCount;
        GetTask();
        TaskActive();
        lastTaskSave();
    }

    public void ButtonClicked()
    {
        Sravn();
        Tasks.transform.GetChild(randomChild).transform.GetChild(randomRandomChild).SendMessage("Close");
        Tasks.transform.GetChild(randomChild).transform.GetChild(randomRandomChild).gameObject.SetActive(false);
        GetTask();


        while (randomChild == lastTask[0] & randomRandomChild == lastTask[1])
        {
            GetTask();
        }
        TaskActive();
        lastTaskSave();
    }
    



    void GetTask()
    {
        randomChild = Random.Range(0, CountChild);
        int CountChildOfChild = Tasks.transform.GetChild(randomChild).transform.childCount;
        randomRandomChild = Random.Range(0, CountChildOfChild);
    }

    void TaskActive()
    {
        Tasks.transform.GetChild(randomChild).transform.GetChild(randomRandomChild).gameObject.SetActive(true);
        Tasks.transform.GetChild(randomChild).transform.GetChild(randomRandomChild).SendMessage("Task");
        //Debug.Log(TaskAnswer);
    }

    void lastTaskSave()
    {
        lastTask[0] = randomChild;
        lastTask[1] = randomRandomChild;
    }

    public void SaveText()
    {
        MyText = InputText.transform.GetComponent<TMP_Text>().text;
        Debug.Log(MyText);
    }

    void Sravn()
    {
        //Debug.Log(MyText);

        bool result = int.TryParse(MyText, out InputAnswer);
        Debug.Log(result);
        


        int.TryParse(MyText, out InputAnswer);

        if (TaskAnswer == InputAnswer)
        {
            ColorBox.color = Color.green;
        }
        else
        {
            ColorBox.color = Color.red;
        }
    }
}
