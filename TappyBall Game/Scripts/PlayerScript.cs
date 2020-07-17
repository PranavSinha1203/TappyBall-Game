using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    // Start is called before the first frame update
    Rigidbody2D rb;
    public float speed;
    public bool start;
    public int score;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        start = false;
        score = 0;
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
            rb.AddForce(Vector2.up * speed);
        }

    }

    void GameStart()
    {
        if (!start)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.isKinematic = false;
                start = true;
            }
        }
    }



    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Score")
        {
            if (start)
            {
                score += 5;
                print(score);
            }

        }


    }
}
