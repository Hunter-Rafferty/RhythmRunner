using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACUnitMovement : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            player.position = new Vector2(player.position.x, player.position.y + 0.15f);
        }
    }
}
