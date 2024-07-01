using UnityEngine;

public class MouvementJoueur : MonoBehaviour
{
    public float vitesseDéplacement = 5f;
    public float vitesseRotation = 180f;

    public KeyCode toucheRotationGauche = KeyCode.Q;
    public KeyCode toucheRotationDroite = KeyCode.E;

    void Update()
    {
        
        float déplacementX = Input.GetAxis("Horizontal");
        float déplacementY = Input.GetAxis("Vertical");
        Vector2 mouvement = new Vector2(déplacementX, déplacementY).normalized;
        transform.Translate(mouvement * vitesseDéplacement * Time.deltaTime);

        if (Input.GetKey(toucheRotationGauche))
        {
            transform.Rotate(Vector3.forward * vitesseRotation * Time.deltaTime);
        }
        else if (Input.GetKey(toucheRotationDroite))
        {
            transform.Rotate(Vector3.back * vitesseRotation * Time.deltaTime);
        }
    }
}
