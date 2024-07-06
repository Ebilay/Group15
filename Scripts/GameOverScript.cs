using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    // UI ��elerini referanslamak i�in de�i�kenler
    public Text gameOverText;
    public Button RestartButton;
    public Button MainMenuButton;
    public Button QuitButton;
    // QuitPanelScript'e referans
    public QuitPanel QuitPanel;

    // Oyun bitti�inde �al��t�r�lacak fonksiyon
    public void GameOver()
    {
        // Oyun bitti�ini g�steren metni etkinle�tir
        gameOverText.gameObject.SetActive(true);

        // D��meleri etkinle�tir
        RestartButton.gameObject.SetActive(true);
        MainMenuButton.gameObject.SetActive(true);
        QuitButton.gameObject.SetActive(true);

        // Oyunu durdur
        Time.timeScale = 0f;


        // QuitPanel'i g�ster
        QuitPanel.ShowQuitPanel();
    }

    // Restart d��mesine t�kland���nda �al��t�r�lacak fonksiyon
    public void RestartGame()
    {
        // Oyun sahnesini yeniden y�kle
        SceneManager.LoadScene(1);

        // Oyunu yeniden ba�lat
        Time.timeScale = 1f;
    }

    // Ana Men� d��mesine t�kland���nda �al��t�r�lacak fonksiyon
    public void GoToMainMenu()
    {
        // Ana Men� sahnesini y�kle
        SceneManager.LoadScene(0);

        // Oyunu yeniden ba�lat
        Time.timeScale = 1f;
    }

    // ��k�� d��mesine t�kland���nda �al��t�r�lacak fonksiyon
    public void QuitGame()
    {
        // Uygulamadan ��k
        Application.Quit();
    }
}
