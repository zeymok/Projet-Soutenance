using UnityEngine;

public class LimitesJoueur : MonoBehaviour
{
    private Camera caméraPrincipale;
    private float largeurJoueur;
    private float hauteurJoueur;

    void Start()
    {
        caméraPrincipale = Camera.main;
        largeurJoueur = GetComponent<Renderer>().bounds.size.x;
        hauteurJoueur = GetComponent<Renderer>().bounds.size.y;
    }

    void Update()
    {
        float demiLargeurCaméra = caméraPrincipale.orthographicSize * Screen.width / Screen.height;
        float demiHauteurCaméra = caméraPrincipale.orthographicSize;

        float minX = caméraPrincipale.transform.position.x - demiLargeurCaméra + largeurJoueur / 2;
        float maxX = caméraPrincipale.transform.position.x + demiLargeurCaméra - largeurJoueur / 2;
        float minY = caméraPrincipale.transform.position.y - demiHauteurCaméra + hauteurJoueur / 2;
        float maxY = caméraPrincipale.transform.position.y + demiHauteurCaméra - hauteurJoueur / 2;

        Vector3 positionJoueur = transform.position;

        float xLimité = Mathf.Clamp(positionJoueur.x, minX, maxX);
        float yLimité = Mathf.Clamp(positionJoueur.y, minY, maxY);

        if (positionJoueur.x != xLimité || positionJoueur.y != yLimité)
        {
            transform.position = new Vector3(xLimité, yLimité, positionJoueur.z);
        }
    }
}
