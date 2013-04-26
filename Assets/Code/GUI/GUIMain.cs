using UnityEngine;
using System.Collections;
using HitPlaneOfPeople;

public class GUIMain : MonoBehaviour, IGUI
{
	private IEngine mEngine;
	private IPlayerCtrl mPlayerCtrl;
	
	
	void Start ()
	{
		
	}
	
	void Update ()
	{
		
	}
	
	public void Pause()
	{
		mEngine.Pause();
	}
	
	public void Continue()
	{
		mEngine.Continue();	
	}
	
	#region IGUI Interface
	public void Init(IPlayerCtrl playerCtrl, IEngine engine)
	{
		this.mPlayerCtrl = playerCtrl;
		this.mEngine = engine;
	}
	#endregion
}
