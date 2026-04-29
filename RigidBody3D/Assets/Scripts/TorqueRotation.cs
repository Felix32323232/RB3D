using UnityEngine;
using UnityEngine.InputSystem;

public class TorqueRotation : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerInput playerInput;

    public float torqueForce = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
    }

    void FixedUpdate()
    {
 
        Vector2 input = playerInput.actions["Move"].ReadValue<Vector2>();

        rb.AddTorque(Vector3.up * input * torqueForce, ForceMode.Force);
    }
}