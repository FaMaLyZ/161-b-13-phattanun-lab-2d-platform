using UnityEngine;
using System.Collections.Generic;

public class Ant : Enemy
{
    [SerializeField]private Vector2 Velocity;
    public Transform[] MovePoint;
    public override void Behavior()
    {
        rb.MovePosition(rb.position + Velocity * Time.fixedDeltaTime);

        
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
