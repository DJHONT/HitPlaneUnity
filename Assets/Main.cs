using UnityEngine;
using System.Collections;
using HitPlaneOfPeople;

public class Main : MonoBehaviour
{
	public NormalBullet bullet;
	public KbInput kbInput;
	public GUIMain guiMain;
	public Transform camera;
    public Player player;

	private IGUI mGui;
	private IBullet mBullet;
    private IPlayer mPlayer;
    private IPlayerCtrl mPlayerCtrl;
	private IKeyboardInput mKeyboardInput;
	private IEngine mEngine;
	
	
	void Start ()
	{
		mGui = guiMain;
		mKeyboardInput = kbInput;
        mPlayer = player;
		mBullet = bullet;
		mPlayer.BulletRefresh(mBullet);
        mPlayerCtrl = new PlayerCtrl(mPlayer, camera, Setting.PLAYER_SPEED);
        mEngine = new Engine();
        
		mKeyboardInput.Init(mPlayerCtrl);
		mGui.Init(mPlayerCtrl, mEngine);
	}
	
	void Update ()
	{
	
	}
}
