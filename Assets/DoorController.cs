using UnityEngine;

public class DoorController : MonoBehaviour
{
    private bool isOpen = false; // État de la porte
    private Quaternion initialRotation; // Rotation initiale
    private Quaternion openRotation; // Rotation ouverte
    public float openAngle = 90f; // Angle d'ouverture
    public float speed = 2f; // Vitesse d'ouverture

    void Start()
    {
        // Initialiser les rotations
        initialRotation = transform.rotation;
        openRotation = Quaternion.Euler(transform.eulerAngles + new Vector3(0, openAngle, 0));
    }

    void OnTriggerEnter(Collider other)
    {
        // Vérifie si le player touche la porte
        if (other.CompareTag("Player"))
        {
            isOpen = true;
        }
    }

    void Update()
    {
        // Faire pivoter la porte si elle doit s'ouvrir
        if (isOpen)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, openRotation, Time.deltaTime * speed);
        }
    }
}
