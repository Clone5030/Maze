using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float y = 0.0f;
    public static float speed = 10.0f;
    private void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = ((transform.right * horizontal + transform.forward * vertical) * speed * Time.deltaTime + transform.position);
        transform.position = new Vector3 (movement.x, y, movement.z);
    }
}
