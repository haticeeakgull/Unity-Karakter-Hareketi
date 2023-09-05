using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D player;

    public float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove();
        verticalMove();
    }
    void horizontalMove()
    {
        player.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, player.velocity.y);
    }
    void verticalMove()
    {
        player.velocity = new Vector2(player.velocity.x, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
    }
}
