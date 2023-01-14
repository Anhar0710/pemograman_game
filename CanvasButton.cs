using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasButton : MonoBehaviour
{
    public GameObject aboutPanel;
    public Dropdown difficultyDropdown;

    public void OnPlayButtonClicked()
    {
        // Aktivasi scene permainan
        // atau proses lain yang dibutuhkan saat tombol "Play" diklik
    }

    public void OnAboutButtonClicked()
    {
        aboutPanel.SetActive(!aboutPanel.activeSelf);
    }

    public void OnDifficultyChanged()
    {
        // Proses yang dibutuhkan saat pemilihan tingkat kesulitan berubah
    }

    public void OnExitButtonClicked()
    {
        // Keluar dari aplikasi
        Application.Quit();
    }
}