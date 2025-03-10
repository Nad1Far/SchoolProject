using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject Menu;

    public void ButtonClicked()
    {
        Debug.Log("Button clickd");
        Menu.SetActive(false);
    }
}
