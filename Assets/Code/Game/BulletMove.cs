using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour
{
	
	float timeMaxmum = 2;
	float timeAdd;
	// Use this for initialization
	void Start ()
	{
		timeAdd = Time.time + timeMaxmum;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Time.time > timeAdd) Destroy(gameObject);
		
		transform.Translate(Vector3.forward*Setting.BULLET_SPEED);
	}
}
