using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCController : MonoBehaviour
{	
	public  bool isHit;
	public  bool isHitLastFrame; 
	public GameObject Text;
    public DialogDisp startdialog;
    //le dialogue 

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
        
        startdialog.Displayline();

        
    	Text.GetComponent<MeshRenderer>().enabled = true;
    	//if (Text != null){
    	//	Text.transform.LookAt(Camera.main.transform.position);
    	//}
    	Debug.Log(gameObject.name.ToString());
    }

    private  void OnRayCastExit(){
    	// Je réini tout ce que j'ai start
    	Text.GetComponent<MeshRenderer>().enabled = false;
    }
}
