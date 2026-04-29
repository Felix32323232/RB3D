using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;
public class Movement : MonoBehaviour
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
        Vector2 input = playerInput.actions["Move"].ReadValue<Vector2>();
        rb.AddForce(new Vector3(input.x, 0, input.y) * 10f);
    }
}
