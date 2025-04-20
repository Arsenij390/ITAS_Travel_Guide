using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UseNPC : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Sign;
    [SerializeField] GameObject interSign;

    [SerializeField] GameObject playerMouseControl;
    [SerializeField] GameObject interUi;
    [SerializeField] Image cursorVisible;

    public bool isEnd;
    
    void Start()
    {
        Sign.gameObject.SetActive(false);
        interSign.gameObject.SetActive(false);
    }

    public  void GetSign()
    {
        //playerMouseControl.GetComponent<PlayerInteraction>().enabled = false;
        playerMouseControl.GetComponent<mouseControll>().enabled = false;
        cursorVisible.gameObject.SetActive(false);
        InstructionsUI.sign = true;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        interSign.gameObject.SetActive(true);
        Sign.gameObject.SetActive(true);

        if (isEnd == true)
        {
            //playerMouseControl.GetComponent<PlayerInteraction>().enabled = true;
            playerMouseControl.GetComponent<mouseControll>().enabled = true;
            cursorVisible.gameObject.SetActive(true);
            InstructionsUI.sign = false;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            interSign.gameObject.SetActive(false);
            Sign.gameObject.SetActive(false);
            isEnd = false;
        }
        
    }
}
