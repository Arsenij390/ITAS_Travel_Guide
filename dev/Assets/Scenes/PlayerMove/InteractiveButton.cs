using UnityEngine;

public class InteractiveButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Destroy()
    {
        gameObject.SetActive(false);

    }
}
