using TMPro;
using UnityEngine;

public class SignNPC2 : MonoBehaviour
{
    public int chatId;
    [SerializeField] TextMeshProUGUI Sign;
    [SerializeField] GameObject useNPC;

    public string[] name;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chatId = 0;
         
    }

    // Update is called once per frame
    public void signNPC2()
    {
        chatId++;

        switch (chatId)
        {
            case 1:
                Sign.text = "�� ������, �������!";
                break;

            case 2:
                Sign.text = "2 ����� 2 ����� ";
                break;

            case 3:
                Sign.text = "2 ����� 3 �����";
                break;

            case 4:
                Sign.text = "2 ����� �����!";
                break;

            default:
                chatId = 0;
                useNPC.gameObject.GetComponent<UseNPC>().isEnd = true;
                useNPC.gameObject.GetComponent<UseNPC>().GetSign();
                InstructionsUI.sign = false;
                return;
        }
    }
}
