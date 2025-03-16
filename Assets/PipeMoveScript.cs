using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
	public float moveSpeed;
	public float deadZone = -75;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		moveSpeed = 5;
	}

	// Update is called once per frame
	void Update()
	{
		transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

		if (transform.position.x < deadZone)
		{
			Destroy(gameObject);
		}
	}
}
