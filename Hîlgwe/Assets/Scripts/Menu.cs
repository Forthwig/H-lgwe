﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	public void PlayGame () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); //Index System for switch scene
	}

	public void QuitGame(){
		Debug.Log("QUIT");
		Application.Quit();
	}

	void Update (){
         if (Input.GetButton("Exit")){
         	Cursor.lockState = CursorLockMode.None;
         	Debug.Log("EHohe");
            SceneManager.LoadScene(0);
       }
    }



}
