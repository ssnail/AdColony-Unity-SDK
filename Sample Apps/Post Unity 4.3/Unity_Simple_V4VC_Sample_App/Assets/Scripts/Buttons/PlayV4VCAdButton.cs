using UnityEngine;
using System.Collections;

/// <summary>
/// This is a class to wrap the gui texture button class. It serves as a way to integrate button press logic.
/// <summary>
/// <value name="currencyText">This is the GUIText GameObject to be used for displaying the currency being tracked by this script</value>
/// <value name="videoZoneStateTexture">This is the GUITexture GameObject that is used to communicate when the video is ready to display.</value>
/// <value name="readyTexture">This is the Texture that is used to communicate that the video is ready to play.</value>
/// <value name="notReadyTexture">This is the Texture that is used to communicate that the video is NOT ready to play.</value>
/// <value name="currencyAmount">This is the property used to track the amount of currency available to the play.</value>
/// <value name="appVersion">This is an arbitrary string to be used by the developer to indicate what version their app is on.</value>
/// <value name="appId">This is the app id provided by AdColony to help link the app created within AdColony to the application using the app id.</value>
/// <value name="zoneId">This is the zone id provided by AdColony. This is used to indicate what ads to play with the application.</value>
public class PlayV4VCAdButton : GUITextureButton {
  //---------------------------------------------------------------------------
  //private
  //---------------------------------------------------------------------------
  //---------------------------------------------------------------------------
  //public
  //---------------------------------------------------------------------------
  public GUIText currencyText = null;
  public GUITexture videoZoneStateTexture = null;

  public Texture readyTexture = null;
  public Texture notReadyTexture = null;

  public int currencyAmount = 0;

  public string appVersion = "1.0";
  public string appId = "";
  public string zoneId = "";
  //---------------------------------------------------------------------------

	// Use this for initialization
	public override void Start() {
    base.Start();
    ConfigureZoneString();
    AdColony.Configure(appVersion, appId, zoneId);
    AdColony.OnAdAvailabilityChange = OnAdAvailabilityChange;
    AdColony.OnV4VCResult = UpdateCurrencyText;
	}

	// Update is called once per frame
	void Update() {
	}

  /// <summary>
  /// This method uses platform dependent compilation to determine what type of app id and zone id to use for the buttons. There are other ways to do this, but platform dependent compliation makes it easier for the code to stay all in one place for configuration.
  /// Reference: http://docs.unity3d.com/Manual/PlatformDependentCompilation.html
  /// </summary>
  public void ConfigureZoneString() {
    #if UNITY_ANDROID
      // App ID
      appId= "app185a7e71e1714831a49ec7";
      // Video zones
      zoneId = "vz1fd5a8b2bf6841a0a4b826";
    //If not android defaults to setting the zone strings for iOS
    #else
      // App ID
      appId = "appbdee68ae27024084bb334a";
      // Video zones
      zoneId = "vzf8e4e97704c4445c87504e";
    #endif
  }

  /// <summary>
  /// This checks every update if the zone specified is ready to be played. If it is, it sets the GUITexture being used to display the status to the correct image.
  /// </summary>
  public void OnAdAvailabilityChange(bool available, string zoneIdChanged) {
    if(available
       && zoneId == zoneIdChanged) {
      videoZoneStateTexture.texture = readyTexture;
    }
    else {
      videoZoneStateTexture.texture = notReadyTexture;
    }
  }

  /// <summary>
  /// This will update the currency text so that it will reflect an accurate count of what currency is available. It's method signature must be like this in order to be assigned as the AdColony.OnV4VCResult delegate. This allows the AdColony plug-in to fire events to this method when they occur.
  /// </summary>
  /// <param name="success">Indicates if the ad was successful in playing</param>
  /// <param name="currencyName">This is the name of currency being rewarded. I.E. coins, gems, balloons, etc.</param>
  /// <param name="currencyAmount">This the amount of currency awarded on the completion of the video.</param>
  public void UpdateCurrencyText(bool success, string currencyName, int currencyAwarded) {
    Debug.Log("OnV4VCResult WAS JUST TRIGGERED.");
    Debug.Log("Was Successful: " + success);
    Debug.Log("--------------------------------");
    currencyAmount += currencyAwarded;
    if(currencyText != null) {
      currencyText.GetComponent<GUIText>().text = currencyName + ": " + currencyAmount;
    }
  }

  /// <summary>
  /// This is the default logic to be performed on button pressed
  /// </summary>
  public override void PerformButtonPressLogic() {
    if(AdColony.IsVideoAvailable(zoneId))
    {
      Debug.Log(this.gameObject.name + " triggered playing a video ad.");
      AdColony.OfferV4VC(true, zoneId);
    }
    else
    {
      Debug.Log(this.gameObject.name + " tried to trigger playing an ad, but the video is not available yet.");
    }
  }
}
