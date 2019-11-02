using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public  float SpeedForce;
    public float jumpForce;
    private Rigidbody2D _player;
    public LayerMask groundLayer;
    public bool ground;
    public Transform ReferencePoint;


    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ground = Physics2D.OverlapCircle(ReferencePoint.position, 1, groundLayer);
        _player.velocity = new Vector2 (SpeedForce, _player.velocity.y);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (ground)
                _player.velocity = new Vector2  (_player.velocity.x, jumpForce);
        }
    }
}
