using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
	public GameObject pipe;
	public float spawnRate = 2;
	private float timer = 0;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		SpawnPipe();
	}

	// Update is called once per frame
	void Update()
	{
		if (timer < spawnRate)
		{
			timer += Time.deltaTime;
		}
		else
		{
			SpawnPipe();
			timer = 0;
		}
	}

	void SpawnPipe()
	{
		Instantiate(pipe, transform.position, transform.rotation);
	}
}
