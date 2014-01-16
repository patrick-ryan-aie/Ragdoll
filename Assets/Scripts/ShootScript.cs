using UnityEngine;
using System.Collections;

public enum AttackTypes {Straight, Verticle, Horizontal};

public class ShootScript : MonoBehaviour {
	AttackTypes attackType;
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		attackType = AttackTypes.Straight;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			attackType = AttackTypes.Straight;
		}
		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			attackType = AttackTypes.Horizontal;
		}
		if(Input.GetKeyDown(KeyCode.Alpha3))
		{
			attackType = AttackTypes.Verticle;
		}

		if(Input.GetMouseButtonDown(0))
		{
			GameObject bullet = (GameObject) Instantiate(bulletPrefab, transform.position, transform.rotation);
			BulletScript bs = bullet.GetComponent<BulletScript>();
			bs.attackType = attackType;
		}
	}
}
