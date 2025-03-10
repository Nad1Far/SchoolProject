using UnityEngine;
using UnityEngine.UI;

public class InfoButtonController : MonoBehaviour
{
    public bool Active = false;
    public GameObject Menu;
    public GameObject InfoPage;
    public void ButtonClicked()
    {
        if (Active == false)
        {
            Menu.SetActive(false);
            InfoPage.SetActive(true);
            Active = true;
        }
        else
        {
            InfoPage.SetActive(false);
            Menu.SetActive(true);
            Active = false;
        }
    }
}
