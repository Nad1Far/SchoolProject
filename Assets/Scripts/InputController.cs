using TMPro;
using UnityEngine;
using UnityEngine.Windows;

public class InputController : MonoBehaviour
{
    [SerializeField] private string MyText;
    [SerializeField] private TMP_InputField InputAnswer;

    void Start()
    {
        InputAnswer.keyboardType = TouchScreenKeyboardType.NumberPad;
    }

    public void ButtonClicked()
    {
        InputAnswer.text = "";
    }
    public void SaveText()
    {
        Check.InputText = InputAnswer.text;
    }
}
