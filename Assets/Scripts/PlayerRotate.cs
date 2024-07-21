using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    Vector2 rotation;
    public static float speed = 3;

    void Update()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        transform.eulerAngles = (Vector2)rotation * speed;
    }
}