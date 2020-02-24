using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
	public Animator transition;
	public float transitionTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ok");
    }

    void OnTriggerEnter(Collider other)
	    {
	       Debug.Log("GO SE TP MOTHERFUCK");

	       StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1));
	       
	    }

	IEnumerator LoadLevel (int levelIndex)
	{
		//Play animation
		transition.SetTrigger("Start");


		yield return new WaitForSeconds (transitionTime);
		SceneManager.LoadScene(levelIndex);		
	}

    

}
