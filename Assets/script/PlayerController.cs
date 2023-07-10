using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float _moveSpeed = 1f;
    public float _jumpPower = 1f;
    Rigidbody2D _rb = default;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 velocity = _rb.velocity;   // Ç±ÇÃïœêî velocity Ç…ë¨ìxÇåvéZÇµÇƒÅAç≈å„Ç… Rigidbody2D.velocity Ç…ñﬂÇ∑

        if (h != 0)
        {
            velocity.x = h * _moveSpeed;
        }

        if (Input.GetButtonDown("Jump"))
        {
            
            velocity.y = _jumpPower;
        }
        

        _rb.velocity = velocity;
    }
}
