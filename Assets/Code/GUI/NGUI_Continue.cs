using UnityEngine;
using System.Collections;

public class NGUI_Continue : MonoBehaviour
{
	public GUIMain guiMain;
	
	void OnMouseUp()
	{
		guiMain.Continue();
	}
}
