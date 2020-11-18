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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
