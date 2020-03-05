using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
	public int PipeNumber;

    void OnTriggerStay(){
    	
    	if(Input.GetKeyDown(KeyCode.C)){
    		SceneManageer.instance.LoadScene(PipeNumber);
    	}
    }
}
