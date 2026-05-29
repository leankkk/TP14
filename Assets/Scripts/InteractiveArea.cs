using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    int score = 0;
    UIManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            score++;
            Debug.Log("Lápiz recolectado! Score: " + score);

            uiManager.UpdateScore(score);
            Destroy(other.gameObject);
        }
    }
}