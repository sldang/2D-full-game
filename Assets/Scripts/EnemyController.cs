using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : PhysicsBase
{
    // Start is called before the first frame update
    void Start()
    {
        desiredx = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void CollideHorizonal(Collider2D other)
    {
        desiredx = -desiredx;
    }
}
