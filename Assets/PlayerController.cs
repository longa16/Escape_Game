using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI  scoreText; // Associez le UI Text dans l'inspecteur
    private int score = 0;

    // Fonction appel�e en cas de collision
    void OnTriggerEnter(Collider other)
    {
        // V�rifie si le player entre en collision avec une boule
        if (other.gameObject.CompareTag("coin"))
        {
            // Incr�menter le score
            score++;
            scoreText.text = "Coin : " + score;

            // D�truire la boule
            Destroy(other.gameObject);
        }
    }
}
