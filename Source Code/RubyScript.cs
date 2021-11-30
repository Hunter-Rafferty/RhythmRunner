using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyScript : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        RubyTextScript.amount += 1;
        Destroy(gameObject);
    }
}
