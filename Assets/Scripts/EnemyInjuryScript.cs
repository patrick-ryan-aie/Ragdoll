using UnityEngine;
using System.Collections;

public class EnemyInjuryScript : MonoBehaviour {

	enum InjuryTypes {Straight, Verticle, Horizontal};
	InjuryTypes injuryType;
	public bool hasRagdoll;
	public GameObject ragdoll;
	GameObject hitByBullet;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SetImpact(GameObject bullet)
	{
		hitByBullet = bullet;
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


			RagDollScript ragdollscript = child.GetComponent<RagDollScript>();
			ragdollscript.SendMessage("SetImpact", hitByBullet);

			gameObject.SetActive(false);
			Destroy(gameObject);
		}

	}
}
