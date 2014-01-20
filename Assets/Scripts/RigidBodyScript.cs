using UnityEngine;
using System.Collections;

public class RigidBodyScript : MonoBehaviour {

	GameObject hitByBullet;

	/*// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/

	void SetImpact(GameObject bullet)
	{
		hitByBullet = bullet;
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
		//root.rigidbody.AddForce(-transform.forward * 1000);
		root.rigidbody.AddForceAtPosition(hitByBullet.transform.forward, hitByBullet.transform.position, ForceMode.Acceleration);
		Debug.Log ("should");
		Destroy(hitByBullet);
	}
}
