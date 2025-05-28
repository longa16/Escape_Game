using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coinsctipy : MonoBehaviour
{
    public int CoinCollected = 0;
    public TextMeshProUGUI textscore;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            CoinCollected++;
            textscore.text = "coin : "+ CoinCollected;

        }
        
    }
}
