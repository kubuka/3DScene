using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fps : MonoBehaviour
{

	[SerializeField] private Text _fpsText;
	[SerializeField] private float _hudRefreshRate = 1f;

	private float _timer;
	private int target = 60;

	private void Update()
	{
		if (Time.unscaledTime > _timer)
		{
			int fps = (int)(1f / Time.unscaledDeltaTime);
			_fpsText.text = "FPS: " + fps;
			_timer = Time.unscaledTime + _hudRefreshRate;
		}

		if (Application.targetFrameRate != target)
		{
			Application.targetFrameRate = target;
		}			
	}

	private void Awake()
	{
		Application.targetFrameRate = 60;
	}

}
