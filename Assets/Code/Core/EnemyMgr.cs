using UnityEngine;
using System.Collections.Generic;
using HitPlaneOfPeople;

public class EnemyMgr : MonoBehaviour
{
	public MonoBehaviour[] enemys;
	/// <summary>
	/// 敌人激活的感知范围
	/// </summary>
	public Rect range;
	public Transform camera;
	private Rect mRange;
	private IEnemy[] mEnemys;
	
	void Start ()
	{
		mRange.width = range.width;
		mRange.height = range.height;
		
		mEnemys = new IEnemy[enemys.Length];
		
		for(int i=0; i<enemys.Length; i++)
		{
			mEnemys[i] = (IEnemy)enemys[i];
		}
	}
	
	void Update ()
	{
		mRange.x = camera.position.x + range.x;
		mRange.y = camera.position.y + range.y;
		
		for(int i=0; i<mEnemys.Length; i++)
		{
			if(mRange.Contains(new Vector2(mEnemys[i].X, mEnemys[i].Y)))
			{
				mEnemys[i].OnActiveUpdate();
			}
		}
	}
}
