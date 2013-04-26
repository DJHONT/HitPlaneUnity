using UnityEngine;
using System.Collections;
using HitPlaneOfPeople;

public class NormalBullet : MonoBehaviour, IBullet
{

	public int GetDamage()
	{
		return 5;
	}
	
	public UnityEngine.Object GetBulletObj()
	{
		return this.gameObject;
	}
}
