using UnityEngine;

public class ListenForEsc : MonoBehaviour
{
    static GameObject ui;
    void Start()
    {
        Canvas ui = GameObject.Find("Canvas").GetComponent<Canvas>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ui.SetActive(!ui.activeSelf);
        }
    }
}
