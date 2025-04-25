using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class FlyText : MonoBehaviour
{
    [SerializeField] private bool distanceLog;
    [SerializeField] private bool rasnizaLog;
    [SerializeField] private bool procLog;
    [SerializeField] private bool colorLog;

    [Range(0f, 3f)] public float chanchingTheColor;
    Color colText;
    Color colBckImg;

    public float procBeg;
    public byte procEnd;

    public SpriteRenderer backImg;
    public TextMeshPro flyText;
    public GameObject colorDIs;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chanchingTheColor = 1;
        colText.a = 255;
        colBckImg.a = 255;
        colBckImg = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        colorDIs.transform.LookAt(player.transform);
        colorDIs.transform.Rotate(0, 180, 0);
        float distance = Vector3.Distance(colorDIs.transform.position, player.transform.position);
        Debug.Log($"distance: {distance}");

        if (distance < 4 && distance > 1)
        {
            try
            {
                procBeg = ((((float)chanchingTheColor - (distance - 1)) * 100) / 2) * (-1);
                Debug.Log(procBeg);
                procEnd = Convert.ToByte((255 * (100 - procBeg) / 100));
                Debug.Log(procEnd);

                colText = new Color32(255, 255, 255, procEnd);
                colBckImg = new Color32(30, 30, 50, procEnd);
                flyText.GetComponent<TextMeshPro>().faceColor = colText;
                backImg.GetComponent<SpriteRenderer>().color = colBckImg;
            }
            catch (Exception e)
            {
                colText = new Color32(255, 255, 255, 255);
                colBckImg = new Color32(30, 30, 50, 255);
                flyText.GetComponent<TextMeshPro>().faceColor = colText;
                backImg.GetComponent<SpriteRenderer>().color = colBckImg;
                //Debug.Log("Œÿ»¡ ¿");
            }
        }
        else
        {
            colText = new Color32(255, 255, 255, 0);
            flyText.GetComponent<TextMeshPro>().faceColor = colText;
            backImg.GetComponent<SpriteRenderer>().color = colText;
        }
    }
}
