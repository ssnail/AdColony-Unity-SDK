using UnityEngine;
using System.Collections;

/// <summary>
/// This is a class to wrap the gui texture button class. It serves as a way to integrate button press logic.
/// <summary>
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

  public string zoneIdKey = "";
  //---------------------------------------------------------------------------

	// Use this for initialization
	public override void Start() {
    base.Start();
	}

	// Update is called once per frame
	void Update() {
    if(ADCAdManager.IsVideoAvailableByZoneKey(zoneIdKey)) {
      videoZoneStateTexture.texture = readyTexture;
    }
    else {
      videoZoneStateTexture.texture = notReadyTexture;
    }
	}

  public override void PerformButtonPressLogic() {
    if(ADCAdManager.IsVideoAvailableByZoneKey(zoneIdKey))
    {
      Debug.Log(this.gameObject.name + " triggered playing a video ad.");
      // AdColony.ShowVideoAd(zoneIdKey);
      ADCAdManager.ShowVideoAdByZoneKey(zoneIdKey, true, false);
    }
    else
    {
      Debug.Log(this.gameObject.name + " tried to trigger playing an ad, but the video is not available yet.");
    }
  }
}
