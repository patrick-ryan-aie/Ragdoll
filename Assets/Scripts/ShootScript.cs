using UnityEngine;
using System.Collections;



public class ShootScript : MonoBehaviour {
	public AttackTypes attackType;
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		attackType = AttackTypes.Straight;
	}
	
	// Update is called once per frame
	void Update () 
	{


		if(Input.GetMouseButtonDown(0))
		{
			GameObject bullet = (GameObject) Instantiate(bulletPrefab, transform.position, transform.rotation);
			BulletScript bs = bullet.GetComponent<BulletScript>();
			bs.attackType = attackType;
		}
	}
}
