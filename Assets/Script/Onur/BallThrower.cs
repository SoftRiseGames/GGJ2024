using UnityEngine;
using System.Threading.Tasks;
using DG.Tweening;
public class BallThrower : MonoBehaviour
{
    public float speed = 3f;
    public GameObject ballPrefab;
    public Transform TukurmeNoktasi;
    public float TukurmeAralik = 1f;
    [SerializeField] int counter;
    [SerializeField] Transform GoPoint;
    void Start()
    {
        
        InvokeRepeating("ThrowBalls", 2, TukurmeAralik);
    }

    void Update()
    {
        if (counter >= 3)
        {
            this.gameObject.transform.DOMove(GoPoint.position, 5).SetDelay(2f).OnComplete(() => { this.gameObject.SetActive(false); });
        }
    }
     
    
    void ThrowBalls()
    {
        if (counter < 3)
        {
            Instantiate(ballPrefab, TukurmeNoktasi.position, Quaternion.identity);
            counter += 1;
        }
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
