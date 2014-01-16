using UnityEngine;
using System.Collections;

public class EnemyInjuryScript : MonoBehaviour {

	enum InjuryTypes {Straight, Verticle, Horizontal};
	InjuryTypes injuryType;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void RecieveInjury(AttackTypes typeOfAttack)
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
}
