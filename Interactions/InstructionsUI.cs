using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionsUI : MonoBehaviour, INstruct
{
    public static bool sign;
    public static bool buttonOn;

    void Update()
    {
        getSign();
        Button();
    }

    //<details>
    //<summary> Когда камера направлена на объект с тегом "NPC" - используется метод "getSign()" </summary>
    //<details>
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
}
