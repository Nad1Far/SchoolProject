using TMPro;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private string MyText;
    [SerializeField] private TMP_InputField InputAnswer;


    public void ButtonClicked()
    {
        InputAnswer.text = "";
    }
    public void SaveText()
    {
        TaskController.InputText = InputAnswer.text;
    }
}
