using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManageer : MonoBehaviour
{
	public static SceneManageer instance =null;
	public int currentPipe;
    public GameObject player; 
    public GameObject [] PipeArray;

    // Start is called before the first frame update
    void Awake()
    {
    	if (instance == null)
        {
    		DontDestroyOnLoad(gameObject);
    		instance = this;
    	}
        else if( instance != null) 
        {
        	Destroy(gameObject);

        }

        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        if (PipeArray.Length == 0)
        {
            PipeArray = GameObject.FindGameObjectsWithTag("Warp_Pipe"); 
        }

    }

   

    void OnLevelWasLoaded()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        PipeArray = GameObject.FindGameObjectsWithTag("Warp_Pipe"); 

        for (int i = 0; i < PipeArray.Length; i++)
        {
            if (PipeArray[i].GetComponent<Pipe>().PipeNumber == currentPipe)
            {
                player.transform.position = PipeArray[i].transform.position ; 
            }
           
        }

    }
     public void LoadScene(int passedPipeNumber)
    {
        
        currentPipe = passedPipeNumber;

        if(Application.loadedLevel == 1)
        {
            Application.LoadLevel(2);

        }

        if(Application.loadedLevel == 2)
        {
            Application.LoadLevel(1);
        }

    }
}
