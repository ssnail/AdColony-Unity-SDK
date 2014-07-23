using UnityEngine;
using System.Collections;

/// <summary>
/// This is a class to wrap the gui texture button class. It serves as a lazy way to integrate button press logic and to play video ads on press.
/// <summary>
/// <value name="videoZoneStateTexture">This is the GUITexture GameObject that is used to communicate when the video is ready to display.</value>
/// <value name="readyTexture">This is the Texture that is used to communicate that the video is ready to play.</value>
/// <value name="notReadyTexture">This is the Texture that is used to communicate that the video is NOT ready to play.</value>
/// <value name="appVersion">This is an arbitrary string to be used by the developer to indicate what version their app is on.</value>
/// <value name="appId">This is the app id provided by AdColony to help link the app created within AdColony to the application using the app id.</value>
/// <value name="zoneId">This is the zone id provided by AdColony. This is used to indicate what ads to play with the application.</value>
public class PlayVideoZoneButton : GUITextureButton {
  //---------------------------------------------------------------------------
  //private
  //---------------------------------------------------------------------------
  //---------------------------------------------------------------------------
  //public
  //---------------------------------------------------------------------------
  public GUITexture videoZoneStateTexture = null;

  public Texture readyTexture = null;
  public Texture notReadyTexture = null;

  public string appVersion = "1.0";
  public string appId = "";
  public string zoneString = "";
  //---------------------------------------------------------------------------

	// Use this for initialization
	public override void Start() {
    base.Start();
    ConfigureZoneString();
    AdColony.Configure(appVersion, appId, zoneString);
	}

	// Update is called once per frame
	void Update() {
    PerformVideoReadyCheck();
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
      zoneString = "vz06e8c32a037749699e7050";
    //If not android defaults to setting the zone strings for iOS
    #else
      // App ID
      appId = "appbdee68ae27024084bb334a";
      // Video zones
      zoneString = "vzf8fb4670a60e4a139d01b5";
    #endif
  }

  /// <summary>
  /// This checks every update if the zone specified is ready to be played. If it is, it sets the GUITexture being used to display the status to the correct image.
  /// </summary>
  public void PerformVideoReadyCheck() {
    if(AdColony.IsVideoAvailable(zoneString)) {
      videoZoneStateTexture.texture = readyTexture;
    }
    else {
      videoZoneStateTexture.texture = notReadyTexture;
    }
  }

  /// <summary>
  /// This is the default logic to be performed on button pressed
  /// </summary>
  public override void PerformButtonPressLogic() {
    if(AdColony.IsVideoAvailable(zoneString))
    {
      Debug.Log(this.gameObject.name + " triggered playing a video ad.");
      AdColony.ShowVideoAd(zoneString);
    }
    else
    {
      Debug.Log(this.gameObject.name + " tried to trigger playing an ad, but the video is not available yet.");
    }
  }
}
