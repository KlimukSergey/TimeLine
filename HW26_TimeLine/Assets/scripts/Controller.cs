using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody _rb;
    private Vector3 direction;
    private ParticleSystem _particle;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _particle = GetComponentInChildren<ParticleSystem>();
        direction = new Vector3(-50f, 5f, 0f);
    }

    public void Shoot()
    {
        _rb.AddForce(direction, ForceMode.Impulse);
        _particle.Play();
    }
    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
