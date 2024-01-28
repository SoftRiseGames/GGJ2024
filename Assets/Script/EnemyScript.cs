using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine.UI;
using Cinemachine;
public class EnemyScript : MonoBehaviour
{
    [SerializeField] bool isMove;
    public Transform character;
    public Animator animator;
    public CinemachineImpulseSource impulse;
    public Slider slider;

    public enum enemyTypes
    {
        balloon,
        shacobox
    }
    public enemyTypes enemytype;
    
    private void Start()
    {
        slider = GameObject.Find("Canvas").transform.GetChild(0).transform.GetComponent<Slider>();
        character = GameObject.Find("Character").transform;
        if (enemytype == enemyTypes.balloon)
            Balloon();

        
       
    }
    void Balloon()
    {
        gameObject.transform.DOMove(new Vector3(character.gameObject.transform.position.x - Random.Range(-1,1), character.gameObject.transform.position.y - Random.Range(-1, 1), 10), 1).OnComplete(() => { animator.SetBool("Boom", true); });
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(enemytype == enemyTypes.shacobox)
            if(collision.gameObject.tag == "Character")
            {
                slider.value += 30;
                impulse.GenerateImpulse();
                character.GetComponent<CharacterMovement>().speed = 500;
                this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                this.gameObject.GetComponent<Animator>().SetBool("shacotime", true);
                GetComponent<AudioSource>().Play();
            }
              

    }
    public async void DestroyObject()
    {
        Debug.Log(Vector2.Distance(gameObject.transform.position, character.transform.position));
        GetComponent<AudioSource>().Play();
        if (Vector2.Distance(gameObject.transform.position, character.transform.position) < 6f)
        {
            slider.value += 30;

        GetComponent<AudioSource>().Play();
            impulse.GenerateImpulse();
            character.GetComponent<CharacterMovement>().speed = 500;
        }
        await Task.Delay(200);
        Destroy(this.gameObject);
    }

    void Update()
    {
      
    }
}
