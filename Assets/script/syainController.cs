using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class syainController : ItemController
{
    // Start is called before the first frame update
    public override void Activate()
    {
        FindObjectOfType<GameScreen>().AddSyain(1);
    }
}
