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

    [Range(0f, 2f)] public float chanchingTheColor;
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
        chanchingTheColor = 2;
        colText.a = 255;
        colBckImg.a = 255;
        colBckImg = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        colorDIs.transform.LookAt(player.transform);
        colorDIs.transform.Rotate(0, 180, 0);
        double PlayerZ = Math.Sqrt(player.transform.position.z * player.transform.position.z);
        float rasniza = (colorDIs.transform.localPosition.z - Convert.ToSingle(PlayerZ)) + 3.5f;
        float rasnizaClose = (colorDIs.transform.localPosition.z - player.transform.position.z);

        if (rasnizaLog)
        {
            Debug.Log($"ras: {rasniza}");
            Debug.Log($"rasC: {rasnizaClose}");
        }

        if (rasniza < 2 || rasniza == 2)
        {
            try
            {
                procBeg = (((float)chanchingTheColor - rasniza) * 100) / 2;
                procEnd = Convert.ToByte((255 * (100 - procBeg) / 100));

                if (procLog)
                {
                    Debug.Log($"Beg: {procBeg}");
                    Debug.Log($"End: {procEnd}");
                }

                if (procBeg > 90)
                {
                    colText = new Color32(255, 255, 255, 0);
                    flyText.GetComponent<TextMeshPro>().faceColor = colText;
                    backImg.GetComponent<SpriteRenderer>().color = colText;
                }
                else
                {
                    colText = new Color32(255, 255, 255, procEnd);
                    colBckImg = new Color32(30, 30, 50, procEnd);
                    flyText.GetComponent<TextMeshPro>().faceColor = colText;
                    backImg.GetComponent<SpriteRenderer>().color = colBckImg;
                }

                if (colorLog)
                {
                    Debug.Log(colText);
                }
            }
            catch (Exception e)
            {
                colText = new Color32(255, 255, 255, 0);
                //Debug.Log("Œÿ»¡ ¿");
            }
        }
    }
}
