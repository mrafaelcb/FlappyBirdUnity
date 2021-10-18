using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    Transform gameOver;

    [SerializeField]
    Text scoreView;


    [SerializeField]
    float jump;

    [SerializeField]
    int score;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            rb.velocity = Vector2.up * jump;
            transform.eulerAngles = new Vector3(0, 0, 30);
        }
        else
        {
            if (rb.velocity.y < 0)
            {
                transform.eulerAngles = new Vector3(0, 0, -45);
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("AddScore"))
        {
            score++;
            scoreView.text = score.ToString();
        }

        if (collision.CompareTag("Pipe"))
        {
            enabled = false;
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
