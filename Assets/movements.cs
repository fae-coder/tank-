using UnityEngine;

public class TankMovement : MonoBehaviour
public float turnSpeed = 75.0f;
{
    public float speed = 50.0f;

    void Update () 
{
float throttle = Input.GetAxis ("Vertical");
float movement = throttle * speed * Time.deltaTime;
float rotation = 0.0f;
{
    rotation = -turnSpeed * Time.deltaTime;
}
    else if (Input.GetKey (Keycode.E))
{
    rotation = turnSpeed * Time.deltaTime;
}

Transform t = gameObject.transform;

Transform t = gameObject.transform;
t.Translate (0.0f, 0.0f, movement);
}
}




