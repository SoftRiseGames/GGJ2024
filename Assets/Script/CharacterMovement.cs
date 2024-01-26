using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;       
public class CharacterMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Horizontal;
    [SerializeField] float speed;
    [SerializeField] bool canJump;
    void Start()
    {
        
    }
    public async void JumpCut()
    {
        if (!canJump)
        {
            await Task.Delay(1000);
            rb.velocity = new Vector2(0, -5f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        /*
        if (rb.velocity.y < 0)
            rb.gravityScale = 8;
        else
            rb.gravityScale = 5;
        */
        JumpCut();
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
            rb.velocity = new Vector2(rb.velocity.x, 1000 * Time.deltaTime);
    }
}
