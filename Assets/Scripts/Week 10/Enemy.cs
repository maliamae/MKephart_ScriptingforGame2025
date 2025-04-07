using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange;
    public float attackSpeed;
    private float attackTimer;

    protected Player player;

    protected NavMeshAgent navAgent;

    protected bool hasSeenPlayer = false;

    void Start()
    {
        player = FindAnyObjectByType<Player>();
        navAgent = GetComponent<NavMeshAgent>();

        //navAgent.SetDestination(player.transform.position);
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

    public virtual void SeePlayer()
    {
        RaycastHit hit;

        Vector3 dir = player.transform.position - this.transform.position;
        dir.Normalize();

        if (Physics.Raycast(this.transform.position, dir, out hit))
        {
            if (hit.collider.tag == "Player")
            {
                hasSeenPlayer = true;
            }
        }
        
    }

    protected virtual void Update()
    {
        if (hasSeenPlayer == true)
        {
            if (Vector3.Distance(this.transform.position, player.transform.position) > attackRange)
            {
                navAgent.SetDestination(player.transform.position);
                navAgent.isStopped = false;
            }
            else
            {
                RaycastHit hit;
                Vector3 dir = player.transform.position - this.transform.position;
                dir.Normalize();

                if (Physics.Raycast(this.transform.position, dir, out hit))
                {
                    if (hit.collider.tag == "Player")
                    {
                        navAgent.isStopped = true;
                        this.transform.LookAt(player.transform.position);

                        if (Vector3.Distance(this.transform.position, player.transform.position) < attackRange)
                        {
                            attackTimer += Time.deltaTime;

                            if (attackTimer > attackSpeed)
                            {
                                Attack();
                                attackTimer = 0;
                            }

                        }
                    }
                    else
                    {
                        navAgent.SetDestination(player.transform.position);
                        navAgent.isStopped = false;
                    }

                }


            }
        }
        



        
        
    }
}
