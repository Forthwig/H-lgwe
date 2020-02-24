using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCController : MonoBehaviour
{	
	public  bool isHit;
	public  bool isHitLastFrame; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {	
        isHit = false;
    }

    void LateUpdate(){

    	if(!isHit && isHitLastFrame)
    	{
    		OnRayCastExit();
    		
    	}
    	isHitLastFrame = isHit;
    }

    public void OnRayCastHit(){

    	if (isHitLastFrame == false )
    	{
    		OnRayCastEnter();
    		
    	}
    	isHit = true ;
    }

    private  void OnRayCastEnter(){
    	//Je fais ce que j'ai a faire == Shader ++ Name en setActive
    	Debug.Log("1,2,3");
    }

    private  void OnRayCastExit(){
    	// Je réini tout ce que j'ai start
    	Debug.Log("3,2,1");
    }
}
