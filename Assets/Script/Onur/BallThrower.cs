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
    }

    void ThrowBalls()
    {
        Instantiate(ballPrefab, TukurmeNoktasi.position, Quaternion.identity);
    }
}
