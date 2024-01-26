using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class EnemyScript : MonoBehaviour
{
    [SerializeField] bool isMove;
    public Transform character;
    public Animator animator;

    public enum enemyTypes
    {
        balloon,
        shacobox
    }
    public enemyTypes enemytype;
    
    private void Start()
    {
        if (enemytype == enemyTypes.balloon)
            Balloon();
    }
    void Balloon()
    {
        var sequence = DOTween.Sequence();
        sequence.Append
        (
            this.gameObject.transform.DOMove(new Vector3(character.gameObject.transform.position.x - 2, character.gameObject.transform.position.y - 2, 10), 1)
        ).OnComplete(() => { animator.SetBool("Boom", true);});
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(enemytype == enemyTypes.shacobox)
            if(collision.gameObject.tag == "Character")
                Debug.Log("a");

    }
    public void DestroyObject()
    {
        Destroy(this.gameObject);
    }

    void Update()
    {
      
    }
}
