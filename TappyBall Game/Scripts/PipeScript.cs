using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float pipeSpeed;
    public float updownspeed;
    Rigidbody2D rb;
    public GameObject DiePlayer;
    

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
        
            rb.velocity = new Vector2(pipeSpeed, updownspeed);
            updownspeed = -updownspeed;
            rb.velocity = new Vector2(pipeSpeed, updownspeed);
        if(PlayerMovement.instance.start == false)
        {
            rb.velocity = new Vector2(0, 0);
        }
 
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Destroyer")
        {
            
            Destroy(gameObject);

        }
    }

   void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Vector2 playerpos = col.gameObject.transform.position;
            Destroy(col.gameObject);
            Instantiate(DiePlayer, playerpos, Quaternion.identity);
            PlayerMovement.instance.start = false;

        }

    }

   
}
