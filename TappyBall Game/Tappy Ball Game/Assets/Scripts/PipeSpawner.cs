using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Pipe;
    public float maxposy;
    void Start()
    {
        InvokeRepeating("PipeSpawn", 0.2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerScript.instance.GameOver)
        {
            CancelInvoke("PipeSpawn");
        }
    }

    void PipeSpawn()
    {
        if(PlayerScript.instance.start)
        {
            Instantiate(Pipe[Random.Range(0, 4)], new Vector2(transform.position.x, Random.Range(-maxposy, maxposy)), Quaternion.identity);
        }   
    }
}
