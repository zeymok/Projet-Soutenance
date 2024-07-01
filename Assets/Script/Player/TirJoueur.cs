using UnityEngine;

public class TirJoueur : MonoBehaviour
{
    public GameObject prefabProjectile;
    public Transform pointDeTir;

    public float vitesseProjectile = 10f;
    public float cadenceTir = 0.5f;
    private float prochainTempsTir = 0f;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= prochainTempsTir)
        {
            Tirer();
            prochainTempsTir = Time.time + 1f / cadenceTir;
        }
    }

    void Tirer()
    {
        GameObject projectile = Instantiate(prefabProjectile, pointDeTir.position, pointDeTir.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = pointDeTir.up * vitesseProjectile;
        }
    }
}
