using UnityEngine;
using UnityEngine.InputSystem;
public class LinearMovement : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerInput playerInput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        Vector3 input = playerInput.actions["Move"].ReadValue<Vector2>();
        input = new Vector3(input.x, 0, input.y) * 5f;
        rb.linearVelocity = input;
    }
}