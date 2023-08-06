using UnityEngine;

public class HeliController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    public float rotation = 10.0f;
    public float rotY;
    Rigidbody rb;
    Vector3 EulerAngleVelocity;
    public Joystick joystick;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        EulerAngleVelocity = new Vector3(0, rotation, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = joystick.Horizontal; // d key changes value to 1, a key changes value to -1
        float zMove = joystick.Vertical; // w key changes value to 1, s key changes value to -1
        rb.velocity = new Vector3(xMove, rb.velocity.y, zMove) * speed; // Creates velocity in direction of value equal to keypress (WASD). rb.velocity.y deals with falling + jumping by setting velocity to y. 
    }
}
