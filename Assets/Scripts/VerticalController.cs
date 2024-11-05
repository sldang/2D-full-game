using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalController : PhysicsBase
{
    // Start is called before the first frame update
    void Start()
    {
        velocity.y = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public override void CollideVertical(Collider2D other)
    {
        velocity.y = -velocity.y;
    }
}
