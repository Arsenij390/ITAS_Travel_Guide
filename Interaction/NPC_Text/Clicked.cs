using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Clicked : MonoBehaviour
{
    public Button Button;
    private bool clickOn;
    // Update is called once per frame
    public void ClickedOn()
    {
        if (Button)
        {
            SignNPC.buttonNext = true;
        }
        else
        {
            SignNPC.buttonNext = false;
        }
    }
}
