using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public float attackRange;
    public float attackSpeed;
    private float attackTimer;

    [SerializeField]
    protected float aggroRange = 15f;

    protected Player player;

    protected NavMeshAgent navAgent;

    protected bool hasSeenPlayer = false;

    [SerializeField]
    protected List<Transform> patrolPoints = new List<Transform>();

    [SerializeField]
    protected int patrolPointIndex = 0;

    void Start()
    {
        player = FindAnyObjectByType<Player>();
        navAgent = GetComponent<NavMeshAgent>();

        navAgent.SetDestination(patrolPoints[patrolPointIndex].position);
        navAgent.isStopped = false;
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

    protected bool IsPlayerInLOS()
    {
        RaycastHit hit;
        Vector3 dir = player.transform.position - this.transform.position;
        dir.Normalize();

        if (Physics.Raycast(this.transform.position, dir, out hit))
        {
            if (hit.collider.tag == "Player")
            {
                return true;
            }

        }

        return false;
    }

    protected virtual void Update()
    {
        if (hasSeenPlayer == true)
        {
            if(navAgent.remainingDistance < 0.5f) //enemy reaches last known location of player
            {
                if(Vector3.Distance(this.transform.position, player.transform.position) > aggroRange)
                {
                    //Debug.LogWarning("1");
                    hasSeenPlayer = false;
                }
                else //they are not out of aggro range
                {
                    if(IsPlayerInLOS() == true) //but they are in the line of sight
                    {
                        navAgent.SetDestination(player.transform.position); //enemy continues chasing
                        //Debug.LogWarning("3");
                        navAgent.isStopped = false;
                    }
                    else
                    {
                        //Debug.LogWarning("2");
                        hasSeenPlayer = false;
                    }
                }
            }

            if (Vector3.Distance(this.transform.position, player.transform.position) > attackRange) //if player is out of attack range
            {
                if(IsPlayerInLOS() == true) //player is within LOS
                {
                    navAgent.SetDestination(player.transform.position); //enecmy chases
                    //Debug.LogWarning("4");
                    navAgent.isStopped = false;
                }
                
                    
            }
            else //player is witihin attack range of enemy
            {
                if(IsPlayerInLOS() == true) //the player is in LOS
                {
                    navAgent.SetDestination(player.transform.position);
                    navAgent.isStopped = true; //stops the enemy from continuing to chase
                    this.transform.LookAt(player.transform.position); //face player

                    attackTimer += Time.deltaTime; //starts attack timer

                    Debug.Log(attackTimer);

                    if (attackTimer > attackSpeed)
                    {
                        //Debug.LogWarning("ATTACKA AAAAAA");
                        Attack();
                        attackTimer = 0;
                    }
                }
                else
                {
                    navAgent.isStopped = false;
                }
                
                


            }
        }
        else //if the player has not been seen
        {
            
            if(navAgent.remainingDistance < 0.5f) //if the navagent reaches its destination it moves on to the next patrol point
            {
                //Debug.LogWarning("WHAT");
                patrolPointIndex++;

                if(patrolPointIndex >= patrolPoints.Count)
                {
                    patrolPointIndex = 0;
                }
                navAgent.SetDestination(patrolPoints[patrolPointIndex].position);
                navAgent.isStopped = false;
            }
            
        }
        



        
        
    }
}
