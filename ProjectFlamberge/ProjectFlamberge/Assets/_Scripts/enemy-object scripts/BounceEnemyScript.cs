using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceEnemyScript : BasicEnemy
{
    public bool upTrue;
    public float bounceBound = 2.75f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        if (upTrue)
        {
            Movement(-0.3f, 0.7f, .1f);
        }
        else
        {
            Movement(-0.3f, -0.7f, .1f);
        }
        if (Mathf.Abs(this.transform.localPosition.y)>=bounceBound)
        {
            upTrue = !upTrue;
        }
        base.Update();
    }
}
