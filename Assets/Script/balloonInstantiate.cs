using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
public class balloonInstantiate : MonoBehaviour
{
    public List<GameObject> balloons;
    [SerializeField] Transform instantiateLocation;

    int loopControl;
    void Start()
    {
        
    }
    async void Instantiator()
    {
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
       for(loopControl =0; loopControl< balloons.Count; loopControl++)
        {
            if(balloons[loopControl] != null)
            {
                Instantiate(balloons[loopControl], instantiateLocation.transform.position, instantiateLocation.transform.rotation);
                await Task.Delay(1000);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Character")
            Instantiator();
    }

}
