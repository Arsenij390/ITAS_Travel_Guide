using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionsUI : MonoBehaviour, INstruct
{
    public static bool sign;
    public static bool buttonOn;
    // Start is called before the first frame update

    void Update()
    {
        getSign();
        Button();
    }
    public string getSign()
    {
        if (sign == false)
        {
            return "Нажмите [F] чтобы <color=green>говорить</color>.";
        }
        else
        {
            return "";
        }
    }
    public bool Button()
    {
        if (buttonOn == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
