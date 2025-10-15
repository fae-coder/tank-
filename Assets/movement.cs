using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float speed = 50.0f;

    void Update () 
{
float throttle = Input.GetAxis ("Vertical");
float movement = throttle * speed * Time.deltaTime;

Transform t = gameObject.transform;
t.Translate (0.0f, 0.0f, movement);
}
}
