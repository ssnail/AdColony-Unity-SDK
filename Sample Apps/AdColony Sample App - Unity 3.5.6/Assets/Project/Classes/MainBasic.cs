/***
 * AdColony Unity Plugin Sample App.
 * This project was built using Unity 3.4.1f5
 * The app id and zone ids provided with this app point to test apps and zones and may not work.
 * To ensure that your app is working correctly with AdColony you should supply your own app id and zone id.
 * To get these register your app with http://clients.adcolony.com
 * */
using UnityEngine;
using System.Collections;

public class MainBasic : MonoBehaviour
{
	private GUISkin		guiSkin;
	private AudioSource music;

	private string		changeSceneText;
	private Rect		videoHeaderRect1;
	private Rect		videoHeaderRect2;
	private Rect		changeSceneRect;
	private Rect		videoRect1;
	private Rect		videoRect2;
	private Rect		v4vcRect;
	private Rect		statusIconRect1;
	private Rect		statusIconRect2;
	private Rect		statusLabelRect1;
	private Rect		statusLabelRect2;
	private Rect		v4vcIconRect;
	private Rect		v4vcLabelRect;
	private Rect		currencyBarRect;
	private Rect		brandStampRect;
	private int			currency;
	private bool		paused;

	private string		videoText1;
	private string		videoText2;
	private string		v4vcText;
	private string		videoNotReadyText1;
	private string		videoNotReadyText2;
	private string		videoReadyText1;
	private string		videoReadyText2;
	private string		v4vcNotReadyText;
	private string		v4vcReadyText;
	private Texture2D	brandStamp;
	private Texture2D	iconNotReady;
	private Texture2D	iconReady;
	private float		fontSize;
	private float		gutter;

	private string		version;
	private string		appId;
	private string		zoneId1;
	private string		zoneId2;
	private string		v4vcId;

	private void OnLevelWasLoaded()
	{
		this.findAudio();
	}

	private void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);
	}

	public void SetupUI(GUISkin guiSkin, string videoText1, string videoText2,
		string v4vcText, string videoNotReadyText1, string videoNotReadyText2,
		string videoReadyText1, string videoReadyText2, string v4vcNotReadyText,
		string v4vcReadyText, Texture2D brandStamp, Texture2D iconNotReady,
		Texture2D iconReady, float fontSize, float gutter)
	{
		this.guiSkin = guiSkin;
		this.videoText1 = videoText1;
		this.videoText2 = videoText2;
		this.v4vcText = v4vcText;
		this.videoNotReadyText1 = videoNotReadyText1;
		this.videoNotReadyText2 = videoNotReadyText2;
		this.videoReadyText1 = videoReadyText1;
		this.videoReadyText2 = videoReadyText2;
		this.v4vcNotReadyText = v4vcNotReadyText;
		this.v4vcReadyText = v4vcReadyText;
		this.brandStamp = brandStamp;
		this.iconNotReady = iconNotReady;
		this.iconReady = iconReady;
		this.fontSize = fontSize;
		this.gutter = gutter;
	}

	public void Initialize(string version, string appId, string zoneId1, string zoneId2, string v4vcId)
	{
		this.version = version;
		this.appId = appId;
		this.zoneId1 = zoneId1;
		this.zoneId2 = zoneId2;
		this.v4vcId = v4vcId;

		this.findAudio();

		//Assign any AdColony Delegates before calling Configure
		AdColony.OnVideoStarted		= this.OnVideoStarted;
		AdColony.OnVideoFinished	= this.OnVideoFinished;
		AdColony.OnV4VCResult		= this.OnV4VCResult;
		AdColony.OnAdAvailabilityChange = this.OnAdAvailabilityChange;

		// Replace these values with data for your own app and zones
		// The values are in the Main object in the Hierarchy of the ACUBasic scene
		AdColony.Configure
		(
			this.version,	// Arbitrary app version
			this.appId,		// ADC App ID from adcolony.com
			this.zoneId1,	// A zone ID from adcolony.com
			this.zoneId2,	// Any number of additional Zone IDS
			this.v4vcId
		);

		// Init UI - Not related to AdColony
		this.currency				= 0;

		this.currencyBarRect		= new Rect(0.0f, 0.0f, Camera.main.pixelWidth, 0.0f);
		this.currencyBarRect.height	= fontSize + gutter;
		this.currencyBarRect.y		= Camera.main.pixelHeight - this.currencyBarRect.height;

		this.brandStampRect			= new Rect(0.0f, 0.0f, this.brandStamp.width, this.brandStamp.height);
		this.brandStampRect.x		= Camera.main.pixelWidth - this.brandStampRect.width;
		this.brandStampRect.y		= Camera.main.pixelHeight - this.brandStampRect.height;

		this.v4vcRect				= new Rect(0.0f, 0.0f, 0.0f, 0.0f);
		this.v4vcRect.width			= Camera.main.pixelWidth * 0.9f;
		this.v4vcRect.height		= Camera.main.pixelHeight * 0.075f;
		this.v4vcRect.x				= (Camera.main.pixelWidth - this.v4vcRect.width) * 0.5f;
		this.v4vcRect.y				= this.currencyBarRect.y - this.v4vcRect.height - gutter;

		this.v4vcIconRect			= new Rect(this.v4vcRect.x, 0.0f, this.v4vcRect.height, this.v4vcRect.height);
		this.v4vcIconRect.y			= this.v4vcRect.y - this.v4vcIconRect.height;

		this.v4vcLabelRect			= new Rect(0.0f, this.v4vcIconRect.y, 0.0f, this.v4vcIconRect.height);
		this.v4vcLabelRect.x		= this.v4vcIconRect.x + this.v4vcIconRect.width + gutter;
		this.v4vcLabelRect.width	= this.v4vcRect.width - this.v4vcIconRect.width - gutter;

		this.videoRect2				= new Rect(this.v4vcRect.x, 0.0f, this.v4vcRect.width, this.v4vcRect.height);
		this.videoRect2.x			= (Camera.main.pixelWidth - this.videoRect2.width) * 0.5f;
		this.videoRect2.y			= this.v4vcIconRect.y - this.videoRect2.height - gutter;

		this.statusIconRect2		= new Rect(this.videoRect2.x, 0.0f, this.videoRect2.height, this.videoRect2.height);
		this.statusIconRect2.y		= this.videoRect2.y - this.statusIconRect2.height;

		this.statusLabelRect2		= new Rect(0.0f, this.statusIconRect2.y, 0.0f, this.statusIconRect2.height);
		this.statusLabelRect2.x		= this.statusIconRect2.x + this.statusIconRect2.width + gutter;
		this.statusLabelRect2.width	= this.videoRect2.width - this.statusIconRect2.width - gutter;

		this.videoRect1				= new Rect(this.videoRect2.x, 0.0f, this.v4vcRect.width, this.v4vcRect.height);
		this.videoRect1.y			= this.statusIconRect2.y - this.videoRect1.height - gutter;

		this.statusIconRect1		= new Rect(this.videoRect1.x, 0.0f, this.v4vcIconRect.width, this.v4vcIconRect.height);
		this.statusIconRect1.y		= this.videoRect1.y - this.statusIconRect1.height;

		this.statusLabelRect1		= new Rect(0.0f, this.statusIconRect1.y, 0.0f, this.statusIconRect1.height);
		this.statusLabelRect1.x		= this.statusIconRect1.x + this.statusIconRect1.width + gutter;
		this.statusLabelRect1.width	= this.videoRect1.width - this.statusIconRect1.width - gutter;

		this.changeSceneRect		= new Rect(this.videoRect1.x, 0.0f, this.v4vcRect.width, this.v4vcRect.height);
		this.changeSceneRect.y			= this.statusIconRect1.y - this.changeSceneRect.height - gutter;

		this.paused					= false;
	}

	private void OnGUI()
	{
		GUI.skin = this.guiSkin;

		if(this.paused) return;

		if(GUI.Button(this.changeSceneRect, this.changeSceneText))
		{
			if(Application.loadedLevelName == "ACUBasic")
			{
				this.changeSceneText = "Change To Scene 1";
				Application.LoadLevel("ACUScene2");
			}
			else
			{
				this.changeSceneText = "Change To Scene 2";
				Application.LoadLevel("ACUBasic");
			}
		}

		if(GUI.Button(this.videoRect1, this.videoText1))
		{
			Debug.Log("Status for zone: " + AdColony.StatusForZone( this.zoneId1 ));
			if(AdColony.IsVideoAvailable(this.zoneId1))
			{
				Debug.Log("Play AdColony Video1");
				AdColony.ShowVideoAd(this.zoneId1);
			}
			else
			{
				Debug.Log("Video1 Not Available");
			}
		}

		if(GUI.Button(this.videoRect2, this.videoText2))
		{
			if(AdColony.IsVideoAvailable(this.zoneId2))
			{
				Debug.Log("Play AdColony Video2");
				AdColony.ShowVideoAd(this.zoneId2);
			}
			else
			{
				Debug.Log("Video2 Not Available");
			}
		}

		if(GUI.Button(this.v4vcRect, this.v4vcText))
		{
			if(AdColony.IsV4VCAvailable(this.v4vcId))
			{
				Debug.Log("Do V4VC");
				AdColony.OfferV4VC(true, this.v4vcId);
			}
			else
			{
				Debug.Log("V4VC Not Available");
			}
		}

		if(Application.loadedLevelName == "ACUBasic")
		{
			this.changeSceneText = "Change To Scene 2";
		}
		else
		{
			this.changeSceneText = "Change To Scene 1";
		}
		if(AdColony.IsVideoAvailable(this.zoneId1))
		{
			GUI.Box(this.statusIconRect1, this.iconReady);
			GUI.Label(this.statusLabelRect1, this.videoReadyText1);
		}
		else
		{
			GUI.Box(this.statusIconRect1, this.iconNotReady);
			GUI.Label(this.statusLabelRect1, this.videoNotReadyText1);
		}

		if(AdColony.IsVideoAvailable(this.zoneId2))
		{
			GUI.Box(this.statusIconRect2, this.iconReady);
			GUI.Label(this.statusLabelRect2, this.videoReadyText2);
		}
		else
		{
			GUI.Box(this.statusIconRect2, this.iconNotReady);
			GUI.Label(this.statusLabelRect2, this.videoNotReadyText2);
		}

		if(AdColony.IsV4VCAvailable(this.v4vcId))
		{
			GUI.Box(this.v4vcIconRect, this.iconReady);
			GUI.Label(this.v4vcLabelRect, this.v4vcReadyText);
		}
		else
		{
			GUI.Box(this.v4vcIconRect, this.iconNotReady);
			GUI.Label(this.v4vcLabelRect, this.v4vcNotReadyText);
		}

		GUI.Label(this.currencyBarRect, "Currency: " + this.currency);

		GUI.Box(this.brandStampRect, this.brandStamp);
	}

	// You may want to pause certain elements of your game before calling ShowVideoAd.
	// It is especially important to pause any sounds before showing a video ad.
	// If your game is resource intensive then you may also need to free up some resources before playing an ad.
	public void Pause()
	{
		this.paused = true;
		//this.randomSpin.Pause();
		this.music.Pause();
	}

	public void Resume()
	{
		this.paused = false;
		//this.randomSpin.Resume();
		//this.findAudio();
		this.music.Play();
	}

	private void OnVideoStarted()
	{
		Debug.Log("On Video Started");

		this.Pause();
	}

	private void OnVideoFinished( bool ad_was_shown )
	{
		Debug.Log("On Video Finished, and Ad was shown: " + ad_was_shown);

		this.Resume();
	}

	// The V4VCResult Delegate assigned in Start, AdColony calls this after confirming V4VC transactions with your server
	// success - true: transaction completed, virtual currency awarded by your server - false: transaction failed, no virtual currency awarded
	// name - The name of your virtual currency, defined in your AdColony account
	// amount - The amount of virtual currency awarded for watching the video, defined in your AdColony account
	private void OnV4VCResult(bool success, string name, int amount)
	{
		if(success)
		{
			Debug.Log("V4VC SUCCESS: name = " + name + ", amount = " + amount);
			this.currency += amount;
		}
		else
		{
			Debug.LogWarning("V4VC FAILED!");
		}
	}

	private void OnAdAvailabilityChange( bool avail, string zone_id)
	{
		Debug.Log("Ad Availability Changed to available=" + avail + " In zone: "+ zone_id);
	}

	private void findAudio()
	{
		if(this.music == null) {
			this.music = (AudioSource) FindObjectOfType(typeof(AudioSource));
		}
	}
}
