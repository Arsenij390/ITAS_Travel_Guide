using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] GameObject player;
    public Camera mainCam;
    public float intDistance = 10f;
    private RaycastHit hit;

    public GameObject instructionUI;
    public Image cursorImage;
    public TextMeshProUGUI interactionText;

    //flashlight

    public GameObject flashLight;

    public void Start()
    {
        cursorImage.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
         interactionRay();
    }

    void interactionRay()
    {
        // пуск "луча" из центра экрана 
        Ray ray = mainCam.ViewportPointToRay(Vector3.one / 2f);
        Vector3 mouse = Input.mousePosition;
        mouse.z = 10f;
        mouse = mainCam.ScreenToWorldPoint(mouse);

        bool hitSomething = false;

        if (Physics.Raycast(ray, out hit, intDistance)) // основная логика взаимодействия через "луч" с объектами на сцене.
        {
            INstruct inst1 = hit.collider.GetComponent<INstruct>();
            Debug.DrawRay(mainCam.transform.position, mouse - transform.position, Color.yellow);

            if (hit.collider.tag != "Untagged" && hit.collider.tag != null) // условие хита "луча" для взаимодействия.
            {
                hitSomething = true;

                if (hit.collider.tag == "NPC") // взаимодействие с NPC, у которого есть тег "NPC"
                {
                    interactionText.text = inst1.getSign();

                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        player.gameObject.GetComponent<UseNPC>().GetSign();

                        if (hit.collider.name == "Human1") //Также разделил по определению имени объекта, чтобы упростить работу кода
                        {
                            InstructionsUI.sign = true;
                            hit.transform.GetComponent<SignNPC>().signNPC();
                        }

                        if (hit.collider.name == "Human2")
                        {
                            InstructionsUI.sign = true;
                            hit.transform.GetComponent<SignNPC>().signNPC();
                        }
                    }
                }

                if (hit.collider.tag == "Button") // Аналогично, что и с NPC
                {
                    cursorImage.gameObject.SetActive(hitSomething);

                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        hit.collider.GetComponent<InteractiveButton>().Destroy();
                    }
                }

                if (hit.collider.tag == "Flashlight") // Будущая функция
                {
                    //interactionText.text = inst1.flashlight();

                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        Destroy(flashLight);
                        player.GetComponent<useLighting>().owned = true;
                    }

                }
            }

            //if (hit.collider.tag == "Button")
            //{
            //    inst1.Button();

            //    if (Input.GetKeyDown(KeyCode.Mouse0))
            //    {
            //        hit.collider.GetComponent<InteractiveButton>().Destroy();
            //    }
            //}
        }
        if (hit.collider.tag != "Button")
        {
            instructionUI.SetActive(hitSomething);
            cursorImage.gameObject.SetActive(false);
        }
    }
}

