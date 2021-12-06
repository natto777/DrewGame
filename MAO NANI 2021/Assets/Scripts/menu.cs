using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
 
    // Start is called before the first frame update
   public void play()
    {
        var scene = SceneManager.LoadSceneAsync(1);

        Destroy(this);

    }
}
