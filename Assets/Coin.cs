using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        if (collision.GetComponent<Player3D>() != null)
        {
            Debug.Log("Player3D detected!");
            // Adaugăm scorul
            ScoreManager.instance.AddScore(1);
            // Distrugem moneda
            Destroy(gameObject);
        }
    }
}
