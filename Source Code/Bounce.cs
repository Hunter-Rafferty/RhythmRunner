using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float speed = 0.2f;
    public float delta = 0.3f;  //delta is the difference between min y to max y.
    float initialpos;

    void Start()
    {
        initialpos = transform.position.y;
    }
    void Update()
    {
        float y = initialpos + Mathf.PingPong(speed * Time.time, delta);
        Vector3 pos = new Vector3(transform.position.x, y, transform.position.z);
        transform.position = pos;
    }
}
