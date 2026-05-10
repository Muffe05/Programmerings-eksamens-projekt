using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public Animator animator;

    private bool isKnockedBack;

    public Player_Combat player_Combat;



    Vector2 movement;

    void Update()
    {
        
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(Input.GetButtonDown("Slash"))
        {
            player_Combat.Attack();
        }
    }

    void FixedUpdate()
    {
        if(isKnockedBack == false)
        {
            // Movement
            rb.MovePosition(rb.position + movement * StatsManager.Instance.speed * Time.fixedDeltaTime);
        }
    }

    public void Knockback(Transform enemy, float force, float stunTime)
    {
        isKnockedBack = true;
        Vector2 direction = (transform.position - enemy.position).normalized;
        rb.linearVelocity = direction * force;
        StartCoroutine(KnockbackCounter(stunTime));
    }

    IEnumerator KnockbackCounter(float stunTime)
    {
        yield return new WaitForSeconds(stunTime);
        rb.linearVelocity = Vector2.zero;
        isKnockedBack = false;
    }
}
