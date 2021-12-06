using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
     private GameObject player;
    private ScoreManager manager;
    private LoopingBackground LB;
    private SpawnObstacles spawn;
    public GameObject explosion;


    void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
        LB = GameObject.FindGameObjectWithTag("BG").GetComponent<LoopingBackground>();
        spawn = GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnObstacles>();
       


    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Borders")
        {
            manager.increaseScore();
            Destroy(gameObject, 0.2f);
        }

        else if(collision.tag == "Player")
        {
            
            
            LB.flag = false;
            spawn.flag = false;
            GameObject explode = Instantiate(explosion,transform.position, Quaternion.identity);
            Destroy(explode, 0.3f);
            Destroy(gameObject, 0.2f);
            Destroy(player.gameObject, 0.2f);
        }
        
    }
}
