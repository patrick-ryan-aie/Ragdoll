using UnityEngine;
using System.Collections;

public class ResetScript : MonoBehaviour {
	public KeyCode resetLevel;
	public KeyCode spawnEnemy;

	public GameObject enemyPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (resetLevel))
		{
			Application.LoadLevel(0);
		}

		if (Input.GetKeyDown (spawnEnemy))
		{
			Instantiate(enemyPrefab, enemyPrefab.transform.position, enemyPrefab.transform.rotation);
		}
	
	}
}
