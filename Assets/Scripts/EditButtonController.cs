using UnityEngine;

public class EditButtonController : MonoBehaviour
{
    public bool Active = false;
    public GameObject Menu;
    public GameObject EditPage;

    public void ButtonClicked()
    {
        if (Active == false)
        {
            Menu.SetActive(false);
            EditPage.SetActive(true);
            Active = true;
        }
        else
        {
            Menu.SetActive(true);
            EditPage.SetActive(false);
            Active = false;
        }
    }

}
