using UnityEngine;
using UnityEngine.UI;

public class Check : MonoBehaviour
{
    public Image ColorBox;
    public static string TaskAnswer, InputText;

    public void Sravn()
    {
        if (InputText == TaskAnswer)
        {
            ColorBox.color = Color.green;
        }
        else
        {
            ColorBox.color = Color.red;
        }
    }

    public void Reset()
    {
        ColorBox.color = Color.gray;
    }
}
