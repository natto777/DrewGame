using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;
    public bool flag;
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
        }
        
        
    }
}
