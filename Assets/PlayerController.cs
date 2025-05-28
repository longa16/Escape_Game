using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI  scoreText; // Associez le UI Text dans l'inspecteur
    private int score = 0;

    // Fonction appelée en cas de collision
    void OnTriggerEnter(Collider other)
    {
        // Vérifie si le player entre en collision avec une boule
        if (other.gameObject.CompareTag("coin"))
        {
            // Incrémenter le score
            score++;
            scoreText.text = "Coin : " + score;

            // Détruire la boule
            Destroy(other.gameObject);
        }
    }
}
