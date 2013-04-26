using UnityEngine;
using System.Collections;
using HitPlaneOfPeople;

public class Player : MonoBehaviour, IPlayer
{
	private float mInterval;
	private float mDelay;
	private IBullet mBullet;
	
	void Start ()
	{
		mInterval = Setting.LAUNCH_INTERVAL;
	}
	
	void Update ()
	{
		
	}

    #region IPawn Interface
    public float X
    {
        get
        {
            return transform.position.x;
        }
        set
        {
            transform.position = new Vector3(value, transform.position.y, transform.position.z);
        }
    }

    public float Y
    {
        get
        {
            return transform.position.y;
        }
        set
        {
            transform.position = new Vector3(transform.position.x, value, transform.position.z);
        }
    }

    public void UnderAttack(int damage)
    {
        //Tip:Player Animation
        throw new System.NotImplementedException();
    }

    public void Attack()
    {
        //Tip:Player Bullet Animation And Attack Animation
		
		if(Time.time > mDelay)
		{
			GameObject tmp = Instantiate(mBullet.GetBulletObj(), transform.position, transform.rotation) as GameObject;
			tmp.transform.position -= new Vector3(0, 0, 1);
			tmp.transform.Rotate(Vector3.left * 90);
			tmp.transform.parent = this.transform.parent;
			mDelay = Time.time + mInterval;
		}
		
    }

    public void Death()
    {
        //Tip:Player Death Animation
        throw new System.NotImplementedException();
    }
	
	public void BulletRefresh(IBullet newBullet)
	{
		//Tip:	When got bullet will be Avtive the Function.
		//		And Init will call ones.
		
		this.mBullet = newBullet;
	}

    #endregion
}
