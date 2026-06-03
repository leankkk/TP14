using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    int score = 0;
    public int scoreMaximo = 1;
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

            if (score >= scoreMaximo)
            {
                uiManager.MostrarPantallaWin();
                FindObjectOfType<GameManager>().juegoActivo = false;
                Time.timeScale = 0;
            }
        }
    }
}