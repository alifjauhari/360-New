using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;
using System.Collections;

public class linkITB : MonoBehaviour 
{
	[DllImport("__Internal")]
	private static extern void OpenNewTab(string url);

	public void OpenLinkMuseum()
	{
		#if !UNITY_EDITOR && UNITY_WEBGL
             OpenNewTab("https://goo.gl/maps/49Ehtg4B2vRazSqR9");
		#endif
	}
}