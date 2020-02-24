
using UnityEngine;

public class Raycast : MonoBehaviour
{
	public float range = 5f;
	public Camera fpsCam;


    // Update is called once per frame
    void Update()
    {
    	RaycastHit hit;

    	if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range ))
    	{	

    		NPCController a = hit.collider.gameObject.GetComponent<NPCController>();
    		if ( a == null)
    		{
    			Debug.Log("Nop");
    		}  

    		else 
    		{
    			a.OnRayCastHit(); 	
    		} 		
    	}
    }
}





