using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;
public class Accel : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerInput playerInput;
    public float acceleration = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        Vector2 input = playerInput.actions["Move"].ReadValue<Vector2>();

        Vector3 direction = new Vector3(input.x, 0f, input.y);

        rb.AddForce(direction * acceleration, ForceMode.Acceleration);
    }
}