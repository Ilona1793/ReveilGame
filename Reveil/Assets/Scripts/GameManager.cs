using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public int Score = 0;
    public bool IsGameOver = false;
    public AudioClip BackgroundMusic;
    public AudioClip DeathMusic;

    private AudioSource audioSource;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if(Instance != this)
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(IsGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                ResetGame();
                UnityEngine.SceneManagement.SceneManager.LoadScene(1);
            }
        }
        audioSource.clip = BackgroundMusic;
    }

    // Update is called once per frame
   
    public void GameOver()
    {
        IsGameOver = true;
        audioSource.clip = DeathMusic;
        audioSource.loop = false;
        audioSource.Play();
    }

    private void ResetGame()
    {
        Score = 0;
        IsGameOver = false;

        audioSource.clip = BackgroundMusic;
        audioSource.loop = true;
        audioSource.Play();
    }
}
