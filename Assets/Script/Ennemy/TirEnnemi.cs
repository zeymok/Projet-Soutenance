using UnityEngine;

public class TirEnnemi : MonoBehaviour
{
    public float intervalleTir = 1f;
    public float vitesseProjectile = 10f;
    public GameObject prefabProjectile;
    public Transform pointDeTir;

    private void Start()
    {
        InvokeRepeating("Tirer", Random.Range(0f, intervalleTir), intervalleTir);
    }

    void Tirer()
    {
        GameObject projectile = Instantiate(prefabProjectile, pointDeTir.position, Quaternion.identity);
        projectile.transform.up = Vector3.down;

        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = projectile.transform.up * vitesseProjectile;
        }

        Destroy(projectile, 5f);
    }

    void OnTriggerEnter2D(Collider2D autre)
    {
        if (autre.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
