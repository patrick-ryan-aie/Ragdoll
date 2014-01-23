using UnityEngine;
using System.Collections;

public enum AttackTypes {Straight, Verticle, Horizontal};
public class AttackScript : MonoBehaviour {

	ShootScript shoot;
	public AttackTypes attackType;
	public GameObject horAttack;
	public GameObject vertAttack;
	public GameObject straightAttack;

	public KeyCode setStraightAttackKey;
	public KeyCode setVerticalAttackKey;
	public KeyCode setHorizontalAttackKey;


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
				horAttack.SetActive(false);
				vertAttack.SetActive(false);
				straightAttack.SetActive(false);
			}
		}


		if(Input.GetKeyDown(setStraightAttackKey))
		{
			attackType = AttackTypes.Straight;
			shoot.attackType = attackType;
			//StraightAttack();
		}
		if(Input.GetKeyDown(setHorizontalAttackKey))
		{
			attackType = AttackTypes.Horizontal;
			shoot.attackType = attackType;
			//HorizontalAttack();
		}
		if(Input.GetKeyDown(setVerticalAttackKey))
		{
			attackType = AttackTypes.Verticle;
			shoot.attackType = attackType;
			//VerticleAttack();
		}
	
	}

	void HorizontalAttack()
	{
		vertAttack.SetActive(false);
		straightAttack.SetActive(false);
		horAttack.SetActive(true);

		float horizontalAttackTime = 1.5f;
		disableTime = horizontalAttackTime;
	}

	void VerticleAttack()
	{
		horAttack.SetActive(false);
		straightAttack.SetActive(false);
		vertAttack.SetActive(true);
		
		float verticleAttackTime = 1.5f;
		disableTime = verticleAttackTime;
	}

	void StraightAttack()
	{
		horAttack.SetActive(false);
		vertAttack.SetActive(false);
		straightAttack.SetActive(true);
		
		float straightAttackTime = 1.5f;
		disableTime = straightAttackTime;
	}
}
