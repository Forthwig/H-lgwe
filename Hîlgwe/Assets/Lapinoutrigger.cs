using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lapinoutrigger : MonoBehaviour
{
	public GameObject lapinou;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(){
    	Destroy(gameObject);
    }
}
