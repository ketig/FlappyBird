using UnityEngine;

public class BirdScript : MonoBehaviour
{
	public Rigidbody2D myRigidbody;
	public float flapStrength;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		flapStrength = 10;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			myRigidbody.linearVelocity = Vector2.up * flapStrength;
		}
	}
}
