using UnityEngine;

public class TaskController : MonoBehaviour
{
    public GameObject Tasks;

    private Transform Task;
    //public int Test;
    private int NumTask, NumSubTask, CountTask, CountSubTask, Taskid, SubTaskid;


    private void Start()
    {
        CountTask = Tasks.transform.childCount;
        GetTask();
        TaskOpen();
    }

    public void ButtonClicked()
    {
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
        Debug.Log(Check.TaskAnswer);
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