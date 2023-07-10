using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float _moveSpeed = 1f;
    public float _jumpPower = 1f;
    Rigidbody2D _rb = default;
    List<ItemController> _itemList = new List<ItemController>();
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (_itemList.Count > 0)
            {
                // ���X�g�̐擪�ɂ���A�C�e�����g���āA�j������
                ItemController item = _itemList[0];
                _itemList.RemoveAt(0);
                item.Activate();
                Destroy(item.gameObject);
            }
        }
        GameScreen script = GameObject.Find("Canvas").GetComponent<GameScreen>();
        script._cm = _itemList.Count;

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
    public void GetItem(ItemController obj)
    {
        _itemList.Add(obj);
    }
}
