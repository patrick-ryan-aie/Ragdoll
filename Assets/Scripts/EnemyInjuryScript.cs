using UnityEngine;
using System.Collections;

public class EnemyInjuryScript : MonoBehaviour {

	enum InjuryTypes {Straight, Verticle, Horizontal};
	InjuryTypes injuryType;
	public bool hasRagdoll;
	public GameObject ragdoll;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void RecieveInjury(AttackTypes typeOfAttack)
	{
		if(!hasRagdoll)
		{
			if(typeOfAttack == AttackTypes.Straight)
			{
				renderer.material.color = Color.red;
			}
			if(typeOfAttack == AttackTypes.Horizontal)
			{
				renderer.material.color = Color.blue;
			}
			if(typeOfAttack == AttackTypes.Verticle)
			{
				renderer.material.color = Color.green;
			}
		}
		else
		{

			GameObject child = (GameObject) Instantiate(ragdoll, transform.position, transform.rotation);
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
			root = child.transform.FindChild("ranger_Reference/ranger_Hips").gameObject;
			root.rigidbody.AddForce(-transform.forward * 1000);

			//}

			gameObject.SetActive(false);
		}

	}
}
