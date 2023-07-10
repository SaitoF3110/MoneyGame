using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : ItemController
{
    // Start is called before the first frame update
    public override void Activate()
    {
        FindObjectOfType<GameScreen>().Fire();
    }
}
