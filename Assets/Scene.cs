using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour
{

	public KeyCode Reset = KeyCode.R;
	public KeyCode Quit = KeyCode.Escape;

	// Use this for initialization
	void Start()
	{
	
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(Reset))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
		
		if (Input.GetKeyDown(Quit))
		{
			Application.Quit();
		}
	}
}
