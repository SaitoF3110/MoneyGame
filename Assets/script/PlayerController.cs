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
        Vector2 velocity = _rb.velocity;   // ���̕ϐ� velocity �ɑ��x���v�Z���āA�Ō�� Rigidbody2D.velocity �ɖ߂�

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
