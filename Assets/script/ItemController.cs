using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]

public abstract class ItemController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioClip _sound = default;//獲得時の音
    [SerializeField] ActivateTiming _whenActivated = ActivateTiming.Get;

    // Update is called once per frame
    public abstract void Activate();

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag.Equals("Player"))
        {
            if (_whenActivated == ActivateTiming.Get)
            {
                Activate();
                Destroy(this.gameObject);
            }
            else if (_whenActivated == ActivateTiming.Use)
            {
                // 見えない所に移動する
                this.transform.position = Camera.main.transform.position;
                // コライダーを無効にする
                GetComponent<Collider2D>().enabled = false;
                // プレイヤーにアイテムを渡す
                //collision.gameObject.GetComponent<PlatformerPlayerController2D>().GetItem(this);
            }
        }
    }
    enum ActivateTiming
    {
        /// <summary>取った時にすぐ使う</summary>
        Get,
        /// <summary>「使う」コマンドで使う</summary>
        Use,
    }
}
