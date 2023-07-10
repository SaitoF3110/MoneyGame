using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]

public abstract class ItemController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioClip _sound = default;//�l�����̉�
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
                // �����Ȃ����Ɉړ�����
                this.transform.position = Camera.main.transform.position;
                // �R���C�_�[�𖳌��ɂ���
                GetComponent<Collider2D>().enabled = false;
                // �v���C���[�ɃA�C�e����n��
                //collision.gameObject.GetComponent<PlatformerPlayerController2D>().GetItem(this);
            }
        }
    }
    enum ActivateTiming
    {
        /// <summary>��������ɂ����g��</summary>
        Get,
        /// <summary>�u�g���v�R�}���h�Ŏg��</summary>
        Use,
    }
}
