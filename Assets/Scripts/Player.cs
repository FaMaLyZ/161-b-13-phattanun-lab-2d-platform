using UnityEngine;

public class Player : Character
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(100);
    }

    public void OnHitWithEnemy(Enemy enemy)
    {
        TakeDamage(enemy.DamageHit);
    }
    private void OnCollisionEnter2D(Collision2D otherCollision)
    {
        Enemy enemy = otherCollision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            OnHitWithEnemy(enemy);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
