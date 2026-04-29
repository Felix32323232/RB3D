using UnityEngine;
using UnityEngine.InputSystem;

public class Explosion : MonoBehaviour
{
    public float explosionForce = 500f;
    public float explosionRadius = 5f;
    public float upwardsModifier = 2f;
    public PlayerInput playerInput;

    void Start()
    {
       playerInput = GetComponent<PlayerInput>();
    }

    public void AddExlosionForce()
    {
        Vector3 explosionPos = transform.position;

        Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius);

        foreach (Collider col in colliders)
        {
            Rigidbody rb = col.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce
                (
                    explosionForce,
                    explosionPos,
                    explosionRadius,
                    upwardsModifier,
                    ForceMode.Impulse
                );
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }


}