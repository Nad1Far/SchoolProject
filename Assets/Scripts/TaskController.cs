using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class TaskController : MonoBehaviour
{
    public GameObject Tasks;
    public Image ColorBox;

    private Transform Task;
    //public int Test;
    private int NumTask, NumSubTask, CountTask, CountSubTask, Taskid, SubTaskid;

    public static string TaskAnswer, InputText;


    private void Start()
    {
        CountTask = Tasks.transform.childCount;
        GetTask();
        TaskOpen();
    }

    public void ButtonClicked()
    {
        Sravn();
        Close();
        GetTask();
        ChangeTask();
    }
    

    void GetTask()
    {
        NumTask = Random.Range(0, CountTask); //randomChild = (Test);
        CountSubTask = Tasks.transform.GetChild(NumTask).transform.childCount;
        NumSubTask = Random.Range(0, CountSubTask);
    }

    void TaskActive()
    {
        Task = Tasks.transform.GetChild(NumTask).transform.GetChild(NumSubTask);
        Task.gameObject.SetActive(true);
        Task.SendMessage("Task");
        Debug.Log(TaskAnswer);
    }

    void Close()
    {
        Task.SendMessage("Close");
        Task.gameObject.SetActive(false);
    }

    void lastTaskSave()
    {
        Taskid = NumTask;
        SubTaskid = NumSubTask;
    }

    void Sravn()
    {
        if(InputText == TaskAnswer)
        {
            ColorBox.color = Color.green;
        }
        else
        {
            ColorBox.color = Color.red;
        }
    }

    void ChangeTask()
    {
        while (NumTask == Taskid & NumSubTask == SubTaskid)
        {
            GetTask();
        }
        TaskOpen();
    }
    
    void TaskOpen()
    {
        TaskActive();
        lastTaskSave();
    }
}
