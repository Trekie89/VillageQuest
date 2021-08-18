using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //This is for the players rigidbody so we can actually move the player
    public new Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2D.velocity = new Vector2(-10, rigidbody2D.velocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody2D.velocity = new Vector2(10, rigidbody2D.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 7);
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            rigidbody2D.velocity = Vector2.zero;
        }
    }
}
