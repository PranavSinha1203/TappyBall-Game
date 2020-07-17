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
        InvokeRepeating("PipeSpawning", 2f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PipeSpawning()
    {
        if(PlayerMovement.instance.start==true)
        {
            int i = Random.Range(0, Pipe.Length);
            Instantiate(Pipe[i], new Vector2(transform.position.x, Random.Range(-maxposy, maxposy)), Quaternion.identity);
        }
        
    }

    void StopSpawningPipes()
    {
        if(PlayerMovement.instance.start == false)
        {
            CancelInvoke("PipeSpawning");
        }
    }
        


}
