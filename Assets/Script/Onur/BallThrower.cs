using UnityEngine;

public class BallThrower : MonoBehaviour
{
    public float speed = 3f;
    public GameObject ballPrefab;
    public Transform TukurmeNoktasi;
    public float TukurmeAralik = 1f;

    void Start()
    {
        InvokeRepeating("ThrowBalls", TukurmeAralik, TukurmeAralik);
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        Destroy(this.gameObject, 7);
    }                     

    void ThrowBalls()
    {
        Instantiate(ballPrefab, TukurmeNoktasi.position, Quaternion.identity);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Character")
        {
            GameObject.Find("Character").GetComponent<CharacterMovement>().speed = 500;
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

    }
}
