using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopOnMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= 12f)
        {
            Vector3 pos = new Vector3(-12f, -3.5f, 0f);
            transform.position = pos;
        }
    }
}
