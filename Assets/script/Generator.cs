using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject _kyaku;
    [SerializeField] GameObject _syainM;
    [SerializeField] GameObject _syainF;
    [SerializeField] GameObject _fire;
    [SerializeField] GameObject _kureem;
    [SerializeField] GameObject _cm;
    float _timer;
    float _interval = 2;
    float _timer2;
    bool _boostTime = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if(_boostTime )
        {
            _timer2 += Time.deltaTime;
            _interval = 0.2f;
            if( _timer2 > 5)
            {
                _boostTime = false;
                _timer2 = 0;
                _interval = 2;
            }
        }


        if (_timer >= _interval)
        {
            float x = Random.Range(-10, 10);
            float y = Random.Range(-5, 5);
            int random = Random.Range(1, 11);
            if (random >= 1 && random <= 5)
            {
                Instantiate(_kyaku, new Vector2(x, y), this.transform.rotation);
            }
            if (random == 6)
            {
                Instantiate(_syainM, new Vector2(x, y), this.transform.rotation);
            }
            if (random == 7)
            {
                Instantiate(_syainF, new Vector2(x, y), this.transform.rotation);
            }
            if (random == 8)
            {
                Instantiate(_fire, new Vector2(x, y), this.transform.rotation);
            }
            if (random == 9)
            {
                Instantiate(_kureem, new Vector2(x, y), this.transform.rotation);
            }
            if (random == 10)
            {
                Instantiate(_cm, new Vector2(x, y), this.transform.rotation);
            }
            _timer = 0;
        }
    }
    public void Boost()
    {
        _boostTime = true;
    }
}
