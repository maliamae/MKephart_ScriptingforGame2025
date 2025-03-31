using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange;
    public float attackSpeed;
    private float attackTimer;

    protected Player player;

    void Start()
    {
        player = FindAnyObjectByType<Player>();
    }

    protected virtual void Attack()
    {
        player.TakeDamage(attackDamage);

        //call an animation
        //OR
        //Deal damage to player
    }

    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;
    }

    public void Die()
    {
        //call death animation 
        //OR
        //Destroy the object
    }
    protected virtual void Update()
    {
        if (Vector3.Distance(this.transform.position, player.transform.position) < attackRange)
        {
            attackTimer += Time.deltaTime;

            if(attackTimer > attackSpeed)
            {
                Attack();
                attackTimer = 0;
            }
            
        }
    }
}
