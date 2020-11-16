using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float UpForce = 200f;
    public Text ScoreText;
    public GameObject GameOverPanel;
    public GameObject WinnerPanel;

    private Rigidbody2D rBody;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.IsGameOver) return;

        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPos.x, cursorPos.y);


    }

    //für Collider ohne Trigger
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
        GameOverPanel.SetActive(true);

    }

    //für Collider mit Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //GameManager.Instance.Score += 1;
        //ScoreText.text = "Score: " + GameManager.Instance.Score;
        if (collision.CompareTag("Shadow"))
        {
            GameManager.Instance.GameOver();
        }

        if (collision.CompareTag("Stardust"))
        {
            Destroy(collision.gameObject);
            GameManager.Instance.Score += 1;
            ScoreText.text = "Score: " + GameManager.Instance.Score;
            if (GameManager.Instance.Score == 5)
            {
                WinnerPanel.SetActive(true);
            }

        }
    }
}
