using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    public bool juegoActivo = true;
    UIManager uiManager;

    void Awake()
    {
        Time.timeScale = 1;
        uiManager = FindObjectOfType<UIManager>();
    }

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        if (uiManager == null) return;

        if (timer > 0 && juegoActivo)
        {
            timer -= Time.deltaTime;
            uiManager.UpdateTimer(timer);
        }
        else if (timer <= 0 && juegoActivo)
        {
            timer = 0;
            juegoActivo = false;
            uiManager.UpdateTimer(0);
            uiManager.MostrarPantallaGameOver();
            Time.timeScale = 0;
        }

        if (!juegoActivo && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}