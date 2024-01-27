using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using Cinemachine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public Slider slider;
    public CinemachineImpulseSource cinemachineImpulseSource;
    void Start()
    {
        slider = GameObject.Find("Canvas").transform.GetChild(0).GetComponent<Slider>();
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -5f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            slider.value += 30;
            cinemachineImpulseSource.GenerateImpulse();
            Destroy(this.gameObject);
            GameObject.Find("Character").GetComponent<CharacterMovement>().speed = 500;
        }
    }
}
