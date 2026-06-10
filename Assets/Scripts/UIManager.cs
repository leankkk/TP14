using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public GameObject panelWin;
    public GameObject panelGameOver;
    public GameObject[] lapicesIconos;

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
        for (int i = 0; i < lapicesIconos.Length; i++)
{
    lapicesIconos[i].SetActive(i < score);
}
    }

    public void UpdateTimer(float timer)
    {
        int segundos = Mathf.FloorToInt(timer);
        int milisegundos = Mathf.FloorToInt((timer - segundos) * 100);
        timerText.text = string.Format("{0:D2}:{1:D2}", segundos, milisegundos);
    }

    public void MostrarPantallaWin()
    {
        panelWin.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        panelGameOver.SetActive(true);
    }
    
}