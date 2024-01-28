using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Tramboline : MonoBehaviour
{
    [SerializeField] int bounce;
    [SerializeField] CinemachineImpulseSource cinemachineImpulseSource;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            cinemachineImpulseSource.GenerateImpulse();
            GetComponent<AudioSource>().Play();
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
            
    }
}
