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

        if (speed == 500)
            fixspeed();

  
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "Zemin")
            canJump = true;
        
        
    }
    async void fixspeed()
    {
        await Task.Delay(3000);
        speed = 900;
 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Clown")
            Debug.Log("b");
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
