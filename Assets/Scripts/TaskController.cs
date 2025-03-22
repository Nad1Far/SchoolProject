using Unity.Multiplayer.Center.Common;
using UnityEngine;
using UnityEngine.UI;

public class TaskController : MonoBehaviour
{
    public GameObject Tasks;
    private int randomChild1;
    private int randomRandomChild1;
    private int CountChild1;
    private void Start()
    {
        int CountChild = Tasks.transform.childCount;
        CountChild1 = CountChild;
        GetTask();
    }

    public void ButtonClicked()
    {
        Tasks.transform.GetChild(randomChild1).transform.GetChild(randomRandomChild1).gameObject.SetActive(false);
        GetTask();

    }

    void GetTask()
    {
        int randomChild = Random.Range(0, CountChild1);
        int CountChildOfChild = Tasks.transform.GetChild(randomChild).transform.childCount;
        int randomRandomChild = Random.Range(0, CountChildOfChild);

        Tasks.transform.GetChild(randomChild).transform.GetChild(randomRandomChild).gameObject.SetActive(true);

        randomChild1 = randomChild;
        randomRandomChild1 = randomRandomChild;
    }
}
