using UnityEngine;

public class ProjectileJoueur : MonoBehaviour
{
    public float dégâts = 10f;

    void OnTriggerEnter2D(Collider2D autre)
    {
        if (autre.CompareTag("Enemy"))
        {
            SantéEnnemi santéEnnemi = autre.GetComponent<SantéEnnemi>();
            if (santéEnnemi != null)
            {
                santéEnnemi.PrendreDesDégâts(dégâts);
            }
            Destroy(gameObject);
        }
        else if (!autre.CompareTag("Player") && !autre.CompareTag("Projectile"))
        {
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
