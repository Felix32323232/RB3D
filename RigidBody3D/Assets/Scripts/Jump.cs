using UnityEngine;
using UnityEngine.InputSystem;
public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {


    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }
}