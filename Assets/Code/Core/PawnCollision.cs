using UnityEngine;
using System.Collections;
using HitPlaneOfPeople;

public class PawnCollision : MonoBehaviour
{
	public MonoBehaviour pawnObj;
	private IPawn mPawn;
	
	
	void Start ()
	{
		mPawn = pawnObj as IPawn;
	}
	
	void Update ()
	{
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		Debug.Log(collider.tag);
		
		if(other.tag == "Bullet")
		{
			mPawn.UnderAttack(5);
		}
		
		if(other.tag == "AdvBullet")
		{
			mPawn.UnderAttack(10);
		}
	}
}
