using TMPro;
using Unity.Multiplayer.Center.Common;
using UnityEngine;
using UnityEngine.UI;


public class TaskController : MonoBehaviour
{
    public GameObject Tasks;
    public Image ColorBox;

    //public int Test;
    private int randomChild, randomRandomChild, CountChild;

    [SerializeField]private string MyText;
    [SerializeField] private TMP_InputField InputAnswer;

    public static string TaskAnswer;

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
        InputAnswer.text = "";
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
        randomChild = Random.Range(0, CountChild); //randomChild = (Test);
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
       MyText = InputAnswer.text;
    }

    void Sravn()
    {
        if(MyText == TaskAnswer)
        {
            ColorBox.color = Color.green;
            Application.Quit();
        }
        else
        {
            ColorBox.color = Color.red;
        }
    }
}
