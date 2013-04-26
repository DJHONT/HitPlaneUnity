using UnityEngine;
using System.Collections;

public class NGUI_Pause : MonoBehaviour
{
	public GUIMain guiMain;
	
	void OnMouseUp()
	{
		guiMain.Pause();
	}
}
