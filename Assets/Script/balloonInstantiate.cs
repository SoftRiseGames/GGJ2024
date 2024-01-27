using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
public class balloonInstantiate : MonoBehaviour
{
    public List<GameObject> balloons;
    void Start()
    {
        Instantiator();
    }
    async void Instantiator()
    {
       for(int i =0; i< balloons.Count; i++)
        {
            balloons[i].SetActive(true);
            await Task.Delay(1000);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
