using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float PipeSpeed;
    public float OscillateSpeed;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("PipeMovement", 0.2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void PipeMovement()
    {
        rb.velocity = new Vector2(PipeSpeed, OscillateSpeed);
        OscillateSpeed = -OscillateSpeed;
        rb.velocity = new Vector2(PipeSpeed, OscillateSpeed);

        if(PlayerScript.instance.GameOver)
        {
            rb.velocity = new Vector2(0, 0);
        }      
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 10)
        {
            Destroy(gameObject);
        }
    }
}
