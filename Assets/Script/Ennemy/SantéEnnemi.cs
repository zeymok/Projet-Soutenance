using UnityEngine;

public class SantéEnnemi : MonoBehaviour
{
    public float santéMax = 3f;
    private float santéActuelle;

    void Start()
    {
        santéActuelle = santéMax;
    }

    public void PrendreDesDégâts(float dégâts)
    {
        santéActuelle -= dégâts;

        if (santéActuelle <= 0)
        {
            Mourir();
        }
    }

    void Mourir()
    {
        Destroy(gameObject);
    }
}
