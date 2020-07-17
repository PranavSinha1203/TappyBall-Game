using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject DiePlayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector2 colpos = collision.gameObject.transform.position;
            Destroy(collision.gameObject);
            Instantiate(DiePlayer, colpos, Quaternion.identity);
            PlayerMovement.instance.start = false;

        }
    }
}
