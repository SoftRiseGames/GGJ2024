using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramboline : MonoBehaviour
{
    [SerializeField] int bounce;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
            
    }
}
