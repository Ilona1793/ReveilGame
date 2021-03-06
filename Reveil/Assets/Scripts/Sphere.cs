using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float speedUpDown;
    [SerializeField] private float maxY;
    [SerializeField] private float minY;
	[SerializeField] private float slowdown;
    Rigidbody2D rb;
    Vector3 mousePosition;
    // Update is called once per frame
    Vector3 targetPosition;
    public GameObject GameOverPanel;
    public GameObject WonPanel;

    public Nightmare nightmareScript;
    public LevelLoader levelLoaderScript;

    public AudioClip StardustClip;
    public AudioClip NextLevelClip;
    public AudioClip GameOverClip;

    private AudioSource audioSource;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        nightmareScript = FindObjectOfType<Nightmare>();
        levelLoaderScript = FindObjectOfType<LevelLoader>();

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (GameManager.Instance.IsGameOver) return;


        Vector3 myScreenPos = Camera.main.WorldToScreenPoint(transform.position);
        
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, myScreenPos.z));
        mousePosition.z = 0f;

        float currentYPosition = transform.position.y;
        float newYPosition = Mathf.Lerp(currentYPosition, mousePosition.y, Time.deltaTime);
        Vector3 deltaUpDown = Vector3.up * (newYPosition - currentYPosition) * speedUpDown;
        Vector3 deltaRight = Vector3.right * speed * Time.deltaTime;

        targetPosition = transform.position;
        targetPosition += deltaRight + deltaUpDown;


        targetPosition.y = Mathf.Clamp(targetPosition.y, minY, maxY);
        transform.position = targetPosition;

        mousePosition.x = transform.position.x + 30f;
        //transform.LookAt(mousePosition);
        
    }

    private void FixedUpdate(){
        //rb.MovePosition(targetPosition);
    }

     //für Collider mit Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //GameManager.Instance.Score += 1;
        //ScoreText.text = "Score: " + GameManager.Instance.Score;
        if(collision.CompareTag("Shadow"))
        {
            GameManager.Instance.GameOver();
            GameOverPanel.SetActive(true);

            audioSource.clip = GameOverClip;
            audioSource.Play();
        }

        if (collision.CompareTag("Stardust"))
        {
            Destroy(collision.gameObject);
           // GameManager.Instance.Score += 1;
           // ScoreText.text = "Score: " + GameManager.Instance.Score;
           // if(GameManager.Instance.Score == 5)
           // {
           //     WinnerPanel.SetActive(true);
           // }

            nightmareScript.curSpeed = nightmareScript.curSpeed * (slowdown * 0.1f);

            audioSource.clip = StardustClip;
            audioSource.Play();
        }

        if (collision.CompareTag("Goal"))
        {
            Destroy(collision.gameObject);
            levelLoaderScript.LoadNextLevel();

            audioSource.clip = NextLevelClip;
            audioSource.Play();
        }

        if (collision.CompareTag("FinalGoal"))
        {
            GameManager.Instance.WonGame();
            WonPanel.SetActive(true);
            Time.timeScale = 0f;
            PauseMenu.GameIsPaused = true;
        }
    }
}
