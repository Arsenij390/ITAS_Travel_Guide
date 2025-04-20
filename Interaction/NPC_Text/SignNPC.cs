using Mono.Cecil.Cil;
using System.Collections;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class SignMassiveNPC
{
    [TextArea] public string dialogue;
}
    
[System.Serializable]
public class DialogueLogic : ScriptableObject
{
    public SignMassiveNPC[] dialogueLogic;
}

[System.Serializable]
public class SignNPC : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI signTextNpc;
    [SerializeField] private GameObject UseNPC;
    public static bool buttonNext;
    public string[] dialoguess;

    public void signNPC()
    {
        StartCor();
    }

    public IEnumerator NextText()
    {
        for (int i = 0; i < dialoguess.Length; i++)
        {
            signTextNpc.text = dialoguess[i];
            Debug.Log(i);
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Mouse0));
            Debug.Log("+");
            yield return null;
        }
        Debug.Log("-");
        UseNPC.GetComponent<UseNPC>().isEnd = true;
        UseNPC.GetComponent<UseNPC>().GetSign();
    }

    public void StartCor()
    {
        StartCoroutine(NextText());
    }
}
