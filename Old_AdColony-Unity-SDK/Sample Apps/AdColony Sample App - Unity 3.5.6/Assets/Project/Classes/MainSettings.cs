using UnityEngine;
using System.Collections;

public class MainSettings : MonoBehaviour {

	public GUISkin		guiSkin;
	public string		version;
	public string		iOS_appId;
	public string		iOS_zoneId1;
	public string		iOS_zoneId2;
	public string		iOS_v4vcId;
	public string		Android_appId;
	public string		Android_zoneId1;
	public string		Android_zoneId2;
	public string		Android_v4vcId;
	public string		videoText1;
	public string		videoText2;
	public string		v4vcText;
	public string		videoNotReadyText1;
	public string		videoNotReadyText2;
	public string		videoReadyText1;
	public string		videoReadyText2;
	public string		v4vcNotReadyText;
	public string		v4vcReadyText;
	public Texture2D	brandStamp;
	public Texture2D	iconNotReady;
	public Texture2D	iconReady;
	public float		fontSize;
	public float		gutter;

	private void Awake()
	{
	}

	private void Start()
	{
		if(GameObject.Find("Main") == null)
		{
			GameObject go = new GameObject( "Main" );
			MainBasic main = go.AddComponent<MainBasic>();
			main.name = "Main";
			main.SetupUI(guiSkin, videoText1, videoText2, v4vcText, videoNotReadyText1, videoNotReadyText2,
				videoReadyText1, videoReadyText2,v4vcNotReadyText, v4vcReadyText, brandStamp, iconNotReady,
				iconReady, fontSize, gutter);

#if UNITY_ANDROID
			main.Initialize(version, Android_appId, Android_zoneId1, Android_zoneId2, Android_v4vcId);
#else
			main.Initialize(version, iOS_appId, iOS_zoneId1, iOS_zoneId2, iOS_v4vcId);
#endif
		}
	}
}
