using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        if(instance == null)
        {
            instance = new LevelManager();
        }
        else
        {
            instance = this;   
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
