using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCharacter : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speedPlayer = 5;
    public Transform visual;
    public Animator anim;
    [Header("Jump")]
    public float jumpStrength = 5;
    public float lowMultiplier = 2.5f;
    public float fallMultiplier = 2.0f;
    public float floorDistance = 0.2f;
    public LayerMask ground;
    public Transform floorDetector;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speedPlayer * x, rb.velocity.y);
        Vector2 vel = rb.velocity;
        vel.x = Mathf.Clamp(vel.x, -speedPlayer, speedPlayer);
        rb.velocity = vel;
        if(Input.GetButtonDown("Jump") && IsGround())
        {
            rb.velocity = Vector2.up * jumpStrength;
        }
        if(rb.velocity.y>0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y 
                * (lowMultiplier - 1) * Time.deltaTime;
        }
        else if(rb.velocity.y < 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y
                * (fallMultiplier - 1) * Time.deltaTime;
        }

        if(rb.velocity.x < 0)
        {
            visual.localScale = new Vector3(-1, 1, 1);
        }
        else if (rb.velocity.x > 0)
        {
            visual.localScale = new Vector3(1, 1, 1);
        }
        anim.SetFloat("xSpeed", Mathf.Abs(rb.velocity.x)/speedPlayer);
        Debug.DrawRay(floorDetector.position, 
            Vector2.down * floorDistance, Color.red);
        Debug.DrawRay(floorDetector.position + new Vector3(0.5f, 0),
            Vector2.down * floorDistance, Color.red);
        Debug.DrawRay(floorDetector.position + new Vector3(-0.5f, 0),
            Vector2.down * floorDistance, Color.red);        
    }
    public bool IsGround()
    {
        RaycastHit2D hit, hit2, hit3;
        hit = Physics2D.Raycast(floorDetector.position,
            Vector2.down, floorDistance, ground);
        hit2 = Physics2D.Raycast(floorDetector.position 
            + new Vector3(0.5f,0),
            Vector2.down, floorDistance, ground);
        hit3 = Physics2D.Raycast(floorDetector.position 
            + new Vector3(-0.5f, 0),
            Vector2.down, floorDistance, ground);
        return hit.collider != null 
            || hit2.collider != null 
            || hit3.collider != null;
    }
}
