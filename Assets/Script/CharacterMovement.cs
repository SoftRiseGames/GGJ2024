using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;       
public class CharacterMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Horizontal;
    public float speed;
    [SerializeField] bool canJump;
    [SerializeField] float jump;
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        if (rb.velocity.y < 0)
            rb.gravityScale = 10;
        else
            rb.gravityScale = 8;
  
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "Zemin")
            canJump = true; 
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zemin")
            canJump = false;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Horizontal * speed * Time.deltaTime, rb.velocity.y);
        if (Input.GetKey(KeyCode.Space) && canJump)
            rb.velocity = new Vector2(rb.velocity.x, jump * Time.deltaTime);
    }
}
