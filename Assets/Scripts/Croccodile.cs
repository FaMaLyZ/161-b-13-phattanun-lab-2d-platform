using UnityEngine;

public class Croccodile : Enemy
{

    [SerializeField] float atkRange;

    public Player player;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(80);
        DamageHit = 30;

        atkRange = 6.0f;
        player = GameObject.FindFirstObjectByType<Player>();
    }
    public override void Behavior()
    {
        Vector2 distance = transform.position - player.transform.position;

        if (distance.magnitude <= atkRange)
        {
            Debug.Log($"{player.name} is in the {this.name}'s akt range!");
            shoot();
        }
    }
    public void shoot()
    {
        Debug.Log($"{this.name} is shooting {player.name}!");
    }
    
    
    // Update is called once per frame
    void Update()
    {
        Behavior();
    }
}
