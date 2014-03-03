using UnityEngine;
using System.Collections;

public class MoveKeyboardController : MonoBehaviour
{
	private Move move;

	public KeyCode Forward = KeyCode.UpArrow;
	public KeyCode Back = KeyCode.DownArrow;
	public KeyCode Left = KeyCode.LeftArrow;
	public KeyCode Right = KeyCode.RightArrow;
	public KeyCode Up = KeyCode.PageUp;
	public KeyCode Down = KeyCode.PageDown;

	// Use this for initialization
	void Start()
	{
		move = GetComponent<Move>();
		if (move == null)
		{
			throw new UnityException("move==null");
		}
	}
	
	// Update is called once per frame
	void Update()
	{

		Vector3 direction = new Vector3(0, 0, 0);
		Vector3 rotation = new Vector3(0, 0, 0);

		if (Input.GetKey(Forward))
		{
			direction.z += 1f;
		}
		if (Input.GetKey(Back))
		{
			direction.z -= 1f;
		}	
		if (Input.GetKey(Left))
		{
			rotation.y -= 1f;
		}
		if (Input.GetKey(Right))
		{
			rotation.y += 1f;
		}
		if (Input.GetKey(Up))
		{
			direction.y += 1f;
		}
		if (Input.GetKey(Down))
		{
			direction.y -= 1f;
		}
		
		move.direction = direction.normalized;
		move.rotation = rotation.normalized;

	}
}
