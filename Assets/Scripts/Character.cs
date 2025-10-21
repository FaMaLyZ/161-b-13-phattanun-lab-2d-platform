using UnityEngine;

public abstract class Character : MonoBehaviour
{

    private int health;
    public int Health
    { get { return health; } 
      set { health = (value < 0) ? 0 : value; }
    
    }
    protected Animator anim;
    protected Rigidbody2D rb;


    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log($"{this.name} took damage: {damage}");
        IfDead();
    }

    public bool IfDead()
    {
        if (Health < 0)
        {
            Destroy(this.gameObject); 
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Initialize(int startHealth)
    {
        Health = startHealth;

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
        Debug.Log($"{this.name} has {startHealth} HP");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
