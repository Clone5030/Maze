using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    void OnTriggerEnter()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("WinScene");
    }
}
