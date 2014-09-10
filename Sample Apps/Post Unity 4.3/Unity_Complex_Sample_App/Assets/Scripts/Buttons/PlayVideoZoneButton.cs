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
    ADCAdManager.AddOnAdAvailabilityChangeMethod(OnAvailabilityChange);
	}

	// Update is called once per frame
	void Update() {
	}

  public override void PerformButtonPressLogic() {
    ADCAdManager.ShowVideoAdByZoneKey(zoneIdKey, true, false);
  }

  public void OnAvailabilityChange(bool availability, string zoneId) {
    if(ADCAdManager.GetZoneIdByKey(zoneIdKey) == zoneId) {
      if(availability) {
        videoZoneStateTexture.texture = readyTexture;
      }
      else {
        videoZoneStateTexture.texture = notReadyTexture;
      }
    }
  }
}
