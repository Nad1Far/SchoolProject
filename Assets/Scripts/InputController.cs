using TMPro;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private string MyText;
    [SerializeField] private TMP_InputField InputAnswer;

    public GameObject Button;

    void Start()
    {
        InputAnswer.keyboardType = TouchScreenKeyboardType.NumberPad;
    }

    public void ButtonClicked()
    {
        InputAnswer.text = "";
    }

    public void Update()
    {
        if (InputAnswer.text == "")
        {
            Button.gameObject.SetActive(false);
        }
        else
        {
            Button.gameObject.SetActive(true);
        }
    }
    public void SaveText()
    {
        Check.InputText = InputAnswer.text;
    }
}
