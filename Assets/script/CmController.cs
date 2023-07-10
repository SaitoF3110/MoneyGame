using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmController : ItemController
{
    public override void Activate()
    {
        FindObjectOfType<Generator>().Boost();
    }

}
