using UnityEngine;
using System.Collections;

public enum AttackTypes {Straight, Verticle, Horizontal};
public class AttackScript : MonoBehaviour {

	ShootScript shoot;
	public AttackTypes attackType;
	GameObject horAttack;
	GameObject vertAttack;
	GameObject straightAttack;

	float disableTime = 0.0f;

	// Use this for initialization
	void Start () {
		shoot = gameObject.GetComponent<ShootScript>();
	}
	
	// Update is called once per frame
	void Update () {

		if(disableTime > 0)
		{
			disableTime -= Time.deltaTime;
			if(disableTime <= 0)
			{
				horAttack.SetActive = false;
				vertAttack.SetActive = false;
				straightAttack.SetActive = false;
			}
		}


		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			attackType = AttackTypes.Straight;
			shoot.attackType = attackType;
			StraightAttack();
		}
		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			attackType = AttackTypes.Horizontal;
			shoot.attackType = attackType;
			HorizontalAttack();
		}
		if(Input.GetKeyDown(KeyCode.Alpha3))
		{
			attackType = AttackTypes.Verticle;
			shoot.attackType = attackType;
			VerticleAttack();
		}
	
	}

	void HorizontalAttack()
	{
		horAttack.SetActive = true;
		vertAttack.SetActive = false;
		straightAttack.SetActive = false;

		float horizontalAttackTime = 1.5f;
		disableTime = horizontalAttackTime;
	}

	void VerticleAttack()
	{
		horAttack.SetActive = false;
		vertAttack.SetActive = true;
		straightAttack.SetActive = false;
		
		float verticleAttackTime = 1.5f;
		disableTime = verticleAttackTime;
	}

	void StraightAttack()
	{
		horAttack.SetActive = false;
		vertAttack.SetActive = false;
		straightAttack.SetActive = true;
		
		float straightAttackTime = 1.5f;
		disableTime = straightlAttackTime;
	}
}
