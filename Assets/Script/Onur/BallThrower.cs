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
        
        InvokeRepeating("ThrowBalls", TukurmeAralik, TukurmeAralik);
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
}
