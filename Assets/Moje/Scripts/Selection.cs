using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
	Ray ray;
	RaycastHit rHit;
	Transform selection;
	public List<GameObject> trees = new List<GameObject>();
	[SerializeField] AudioSource aSource;
	[SerializeField] AudioClip clip;

    void Update()
    {
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray, out rHit) && rHit.distance <= 5f)
		{
			selection = rHit.transform;
		}

		if (Input.GetKeyDown(KeyCode.E) &&
			selection != null &&
			selection.tag == "Tree")
		{
			trees.Add(selection.gameObject);
			aSource.PlayOneShot(clip);
			selection.gameObject.SetActive(false);
			selection = null;
		}

		if(Input.GetKeyDown(KeyCode.R) && trees.Count > 0)
		{
			foreach (var item in trees)
			{
				item.SetActive(true);
			}
		}

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
    }
}
