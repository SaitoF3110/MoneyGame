using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplainerController : ItemController
{
    // Start is called before the first frame update
    [SerializeField] int complainer = 1;
    public override void Activate()
    {
        FindObjectOfType<GameScreen>().Complainer(complainer);
    }
}
