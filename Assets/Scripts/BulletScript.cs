using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public AttackTypes attackType;
	public float moveSpeed = 5.0f;
	Vector3 startingPos;

	// Use this for initialization
	void Start () {
		startingPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + transform.forward * moveSpeed * Time.deltaTime;
		if(Vector3.Distance(transform.position, startingPos) > 20)
		{
			Destroy(gameObject);
		}
	
	}

	void OnTriggerEnter(Collider c)
	{
		if(c.tag == "Enemy")
		{
			EnemyInjuryScript hitInjury = c.transform.gameObject.GetComponent<EnemyInjuryScript>();
			hitInjury.SendMessage("SetImpact", gameObject);
			hitInjury.SendMessage("RecieveInjury", attackType);

			//Destroy(gameObject);
		}
	}


}
