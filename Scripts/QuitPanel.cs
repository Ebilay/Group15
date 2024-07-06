using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuitPanel : MonoBehaviour
{
    // UI ��elerini referanslamak i�in de�i�kenler
    public Text QuitText; // "Are You Sure?" metni i�in
    public Button yesButton; // "Evet" d��mesi i�in
    public Button noButton; // "Hay�r" d��mesi i�in

    // ��k�� ekran�n� a�mak i�in fonksiyon
    public void ShowQuitPanel()
    {
        // UI ��elerini etkinle�tir
        QuitText.gameObject.SetActive(true);
        yesButton.gameObject.SetActive(true);
        noButton.gameObject.SetActive(true);
    }

    // "Evet" d��mesine t�kland���nda tetiklenir
    public void QuitGame()
    {
        // Uygulamadan ��k
        Application.Quit();
    }

    // "Hay�r" d��mesine t�kland���nda tetiklenir
    public void CancelExit()
    {
        // ��k�� ekran�n� kapat
        QuitText.gameObject.SetActive(false);
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
    }

    // "Quit" d��mesine t�kland���nda tetiklenir
    public void OnClickQuitButton()
    {
        ShowQuitPanel();
    }
}




