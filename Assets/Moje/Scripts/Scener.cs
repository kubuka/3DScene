using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scener : MonoBehaviour
{
	Animator anim;

	private void Start()
	{
		anim = GetComponent<Animator>();
	}

	public void StartGame()
	{
		SceneManager.LoadScene(1);
	}

	public void StartAnim()
	{
		anim.SetTrigger("FadeNow");
	}

	public void Quit()
	{
		Application.Quit();
	}
}
