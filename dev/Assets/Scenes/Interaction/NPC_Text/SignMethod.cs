using System.Collections;
using TMPro;
using UnityEngine;

public class SignMethod : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI signText;
    [SerializeField] private GameObject signObject;
    [SerializeField] private ScriptableObject signMassive;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public IEnumerator CurrentDialogue(MassiveOwn dialogueObject)
    {
        for(int i = 0; i < dialogueObject.signGet.Length; i++)
        {
            signText.text = dialogueObject.signGet[i].dialogue;
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Mouse0));

            yield return null;
        }

        signObject.SetActive(false);
    }
}
