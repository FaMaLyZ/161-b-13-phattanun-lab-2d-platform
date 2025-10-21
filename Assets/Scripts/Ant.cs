using UnityEngine;
using System.Collections.Generic;
using UnityEditor.Tilemaps;

public class Ant : Enemy
{
    [SerializeField]private Vector2 Velocity;
    public Transform[] MovePoint;
    public override void Behavior()
    {
        rb.MovePosition(rb.position + Velocity * Time.fixedDeltaTime);

        if ( Velocity.x < 0 && rb.position.x <= MovePoint[0].position.x)
        {
            Flip();
        }

        if ( Velocity.x > 0 && rb.position.x >= MovePoint[1].position.x)
        {
            Flip();
        }
        
    }
    public void Flip()
    {
        Velocity.x *= -1;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(20);
        DamageHit = 10;
        Velocity = new Vector2(-1.0f,0.0f);
    }
    private void FixedUpdate()
    {
        Behavior();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
