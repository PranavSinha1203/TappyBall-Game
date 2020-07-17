using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour
{
    public static PlayerScript instance;
    private Rigidbody2D PlayerRb;
    public float Force;
    public bool start;
    public int score;
    private Vector2 PlayerPos;
    public GameObject PlayerDead;
    public bool GameOver;
    public Text Score;
    


    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }


    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
        start = false;
        score = 0;
        GameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameStart();

        if (Input.GetMouseButtonDown(0))
        {
            PlayerMove();
        }

    }

    void PlayerMove()
    {
        if (start)
        {
            PlayerRb.AddForce(Vector2.up * Force);
        }

    }

    void GameStart()
    {
        if (!start)
        {
            if (Input.GetMouseButtonDown(0))
            {
                PlayerRb.isKinematic = false;
                start = true;
            }
        }
    }

    void PlayerDie()
    {
        PlayerPos = transform.position;
        Destroy(gameObject);
        Instantiate(PlayerDead, PlayerPos, Quaternion.identity);
        GameOver = true;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.layer == 11 || col.gameObject.layer == 8)
        {
            PlayerDie();
        }  
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.layer == 12 && GameOver == false)
        {
            score = score + 10;
            Score.text = score.ToString();
        }
    }


}
