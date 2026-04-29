using UnityEngine;
using UnityEngine.InputSystem;
public class CarMovement : MonoBehaviour
{
    public Rigidbody rb1;
    public PlayerInput playerInput1;
    void Start()
    {
        rb1 = GetComponent<Rigidbody>();
        playerInput1 = GetComponent<PlayerInput>();
    }

    void Update()
    {
        Vector2 input = playerInput1.actions["Move"].ReadValue<Vector2>();
        if (input.y > 0)
        {
            rb1.AddForce(new Vector3(0, 0, input.y) * 1000f);
        }
        else if (input.y < 0)
        {
            rb1.AddForce(new Vector3(0, 0, input.y) * 500f);
        }

    }
}