using UnityEngine;

public class ProjectileEnnemi : MonoBehaviour
{
    public int dégâts = 1;

    void OnTriggerEnter2D(Collider2D autre)
    {
        if (autre.CompareTag("Player"))
        {
            SantéJoueur santéJoueur = autre.GetComponent<SantéJoueur>();
            if (santéJoueur != null)
            {
                santéJoueur.PrendreDesDégâts(dégâts);
            }
            Destroy(gameObject);
        }
        else if (!autre.CompareTag("Enemy") && !autre.CompareTag("Projectile"))
        {
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
