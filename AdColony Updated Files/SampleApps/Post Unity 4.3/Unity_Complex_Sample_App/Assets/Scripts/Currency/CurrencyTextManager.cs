using UnityEngine;
using System.Collections;

/// <summary>
/// This was created to update the currency text on screen by querying the ADCAdManager
/// </summary>
public class CurrencyTextManager : MonoBehaviour {

  public GUIText currencyText = null;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
    currencyText.text = ("Credits: " + ADCAdManager.GetRegularCurrencyAmount());
	}
}
