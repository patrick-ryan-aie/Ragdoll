using UnityEngine;
using System.Collections;

public class RagDollScript : MonoBehaviour {

	GameObject hitByBullet;
	public int impactMultiplier = 1000;

	/*// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/

	void SetImpact(GameObject bullet)
	{
		hitByBullet = bullet;
		BulletScript bs = hitByBullet.GetComponent<BulletScript>();

		//GameObject child = (GameObject) Instantiate(ragdoll, transform.position, transform.rotation);
		//child.transform.parent = transform;
		
		//child.SetActive(true);
		GameObject root;
		/*if(typeOfAttack == AttackTypes.Straight)
			{
				foreach(Transform c in transform)
				{
					if(c.name == "ranger_Hips")
					{
						Debug.Log("found hips");
						root = c.gameObject;
						root.rigidbody.AddForce(-transform.forward * 10);
					}
				}*/
		root = transform.FindChild("ranger_Reference/ranger_Hips").gameObject;
		//root.rigidbody.AddForce(hitByBullet.transform.forward * 1000,ForceMode.Acceleration);


		switch(bs.attackType)
		{
		case AttackTypes.Straight :
			root.rigidbody.AddForce(/*hitByBullet.transform.forward* */hitByBullet.transform.forward * impactMultiplier,ForceMode.Acceleration);
			break;
		case AttackTypes.Horizontal :
			root.rigidbody.AddForce(/*hitByBullet.transform.forward* */hitByBullet.transform.right * impactMultiplier,ForceMode.Acceleration);
			break;
		case AttackTypes.Verticle :
			root.rigidbody.AddForce(/*hitByBullet.transform.forward* */hitByBullet.transform.up * impactMultiplier,ForceMode.Acceleration);

			break;
		default:
			root.rigidbody.AddForce(/*hitByBullet.transform.forward* */hitByBullet.transform.forward * impactMultiplier,ForceMode.Acceleration);
			break;
		}




		//Debug.Log(hitByBullet.rigidbody.velocity);
		//root.rigidbody.AddForceAtPosition(hitByBullet.transform.forward, hitByBullet.transform.position, ForceMode.Acceleration);
		Destroy(hitByBullet);
	}
}
