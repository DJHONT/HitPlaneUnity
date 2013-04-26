using UnityEngine;
using System.Collections;
using HitPlaneOfPeople;

public class EasyEnemy1 : MonoBehaviour, IEnemy
{
	private int mHp;
	
	
	void Start ()
	{
		mHp = 100;
	}
	
	public void OnActiveUpdate()
	{
		if(mHp <= 0)
		{
			Destroy(gameObject);	
		}
		
	}
	
    public float X { get; set; }
    public float Y { get; set; }
	
    public void UnderAttack(int damage)
	{
		mHp -= damage;
	}
	
    public void Attack()
	{
		
	}
	
    public void Death()
	{
		
	}
}
