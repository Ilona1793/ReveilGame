using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    // Start Game
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Quit game
    public void QuitGame()
    {
        Application.Quit();
    }

    // Adjust Volume
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

}
