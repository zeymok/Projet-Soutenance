using UnityEngine;
using UnityEngine.SceneManagement;

public class SantéJoueur : MonoBehaviour
{
    public float santéMax = 100f;
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
