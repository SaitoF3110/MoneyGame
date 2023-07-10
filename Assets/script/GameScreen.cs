using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


public class GameScreen : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text _moneyText = default;
    [SerializeField] Text _amountText = default;
    [SerializeField] Text _cmText = default;
    [SerializeField] Text _levelText = default;
    public int _money = 0;
    public int _amount = 0;
    public int _cm = 0;
    public int _level = 1;

    float _timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moneyText.text = _money.ToString();
        _amountText.text = _amount.ToString();
        _cmText.text = _cm.ToString();
        _levelText.text = _level.ToString();
        Level();
        Timer();
    }
    void Level()
    {
        if ( _money >= 100 * _level * _level)
        {
            _level += 1;
        }
    }
    private void Timer()
    {
        _timer += Time.deltaTime;
        if ( _timer >= 1 )
        {
            _money += _amount * _level;
            _timer = 0;
        }
    }
    public void AddMoney(int money)
    {
        _money += money * _level;
    }
    public void AddSyain(int syain)
    {
        _amount += syain;
    }
    public void Complainer(int comp)
    {
        _amount -= comp * _level;
    }
    public void Fire()
    {
        _money -= _money / 2;
    }

}
