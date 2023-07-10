using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customorController : ItemController
{
    // Start is called before the first frame update
    [SerializeField] int _nomalMoney = 10;
    public override void Activate()
    {
        FindObjectOfType<GameScreen>().AddMoney(_nomalMoney);
    }
}
