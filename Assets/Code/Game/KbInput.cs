using UnityEngine;
using System.Collections;
using HitPlaneOfPeople;

public class KbInput : MonoBehaviour, IKeyboardInput
{
	private IPlayerCtrl mPlayerCtrl;
	
	void Start ()
	{
	}
	
	void Update ()
	{
		if(Input.GetKey(KeyCode.A))
		{
			mPlayerCtrl.Move(Direction.left);	
		}
		
		else if(Input.GetKey(KeyCode.D))
		{
			mPlayerCtrl.Move(Direction.right);	
		}
		
		if(Input.GetKey(KeyCode.W))
		{
			mPlayerCtrl.Move(Direction.up);	
		}
		
		else if(Input.GetKey(KeyCode.S))
		{
			mPlayerCtrl.Move(Direction.down);	
		}
		
		if(Input.GetKey(KeyCode.Space))
		{
			mPlayerCtrl.Attack();	
		}
	}
	
	public void Init(IPlayerCtrl playerCtrl)
	{
		mPlayerCtrl = playerCtrl;
	}
}
