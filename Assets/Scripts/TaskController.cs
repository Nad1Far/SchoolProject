using Unity.Multiplayer.Center.Common;
using UnityEngine;
using UnityEngine.UI;

public class TaskController : MonoBehaviour
{
    public GameObject Tasks;

    private int randomChild;
    private int randomRandomChild;
    private int CountChild;

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
    }
    void lastTaskSave()
    {
        lastTask[0] = randomChild;
        lastTask[1] = randomRandomChild;
    }
}
