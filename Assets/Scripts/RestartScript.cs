using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScript : MonoBehaviour
{
    void Start()
    {
       GetComponent<Button>().onClick.AddListener(Clicked);
    }

    void Clicked()
    {
        SceneManager.LoadScene("PlayScreen");
    }
}
