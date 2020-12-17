using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public int Score = 0;
    public bool IsGameOver = false;
    public bool HaveWonGame = false;
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

        //Mouse Sichtbarkeit
        //Cursor.visible = false;
    }

    void Update()
    {
        if(IsGameOver)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ResetGame();
                UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                ResetGame();
                SceneManager.LoadScene("MainMenu");
            }
        }
        if (HaveWonGame)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                ResetGame();
                SceneManager.LoadScene("MainMenu");
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

    public void WonGame()
    {
        HaveWonGame = true;
        // audioSource.clip = DeathMusic;
        // audioSource.loop = false;
        // audioSource.Play();
    }
}
