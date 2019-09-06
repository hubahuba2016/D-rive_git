using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GraphicSettings : MonoBehaviour {
	public GameObject maskimage;
	public GameObject GraphicSettingsText;
	public GameObject VeryLowGraphicButton;
	public GameObject LowGraphicButton;
	public GameObject MediumGraphicButton;
	public GameObject HighGraphicButton;
	public GameObject VeryHighGraphicButton;
	public GameObject UltraGraphicButton;

	public void VeryLowOnClick(){
		QualitySettings.SetQualityLevel (0);
		Destroy (GraphicSettingsText.gameObject);
		Destroy (VeryLowGraphicButton.gameObject);
		Destroy (LowGraphicButton.gameObject);
		Destroy (MediumGraphicButton.gameObject);
		Destroy (HighGraphicButton.gameObject);
		Destroy (VeryHighGraphicButton.gameObject);
		Destroy (UltraGraphicButton.gameObject);
		Destroy (maskimage.gameObject);
	}
	public void LowOnClick(){
		QualitySettings.SetQualityLevel (1);
		Destroy (GraphicSettingsText.gameObject);
		Destroy (VeryLowGraphicButton.gameObject);
		Destroy (LowGraphicButton.gameObject);
		Destroy (MediumGraphicButton.gameObject);
		Destroy (HighGraphicButton.gameObject);
		Destroy (VeryHighGraphicButton.gameObject);
		Destroy (UltraGraphicButton.gameObject);
		Destroy (maskimage.gameObject);
	}
	public void MediumOnClick(){
		QualitySettings.SetQualityLevel (2);
		Destroy (GraphicSettingsText.gameObject);
		Destroy (VeryLowGraphicButton.gameObject);
		Destroy (LowGraphicButton.gameObject);
		Destroy (MediumGraphicButton.gameObject);
		Destroy (HighGraphicButton.gameObject);
		Destroy (VeryHighGraphicButton.gameObject);
		Destroy (UltraGraphicButton.gameObject);
		Destroy (maskimage.gameObject);
	}
	public void HighOnClick(){
		QualitySettings.SetQualityLevel (3);
		Destroy (GraphicSettingsText.gameObject);
		Destroy (VeryLowGraphicButton.gameObject);
		Destroy (LowGraphicButton.gameObject);
		Destroy (MediumGraphicButton.gameObject);
		Destroy (HighGraphicButton.gameObject);
		Destroy (VeryHighGraphicButton.gameObject);
		Destroy (UltraGraphicButton.gameObject);
		Destroy (maskimage.gameObject);
	}
	public void VeryHighOnClick(){
		QualitySettings.SetQualityLevel (4);
		Destroy (GraphicSettingsText.gameObject);
		Destroy (VeryLowGraphicButton.gameObject);
		Destroy (LowGraphicButton.gameObject);
		Destroy (MediumGraphicButton.gameObject);
		Destroy (HighGraphicButton.gameObject);
		Destroy (VeryHighGraphicButton.gameObject);
		Destroy (UltraGraphicButton.gameObject);
		Destroy (maskimage.gameObject);
	}
	public void UltraOnClick(){
		QualitySettings.SetQualityLevel (5);
		Destroy (GraphicSettingsText.gameObject);
		Destroy (VeryLowGraphicButton.gameObject);
		Destroy (LowGraphicButton.gameObject);
		Destroy (MediumGraphicButton.gameObject);
		Destroy (HighGraphicButton.gameObject);
		Destroy (VeryHighGraphicButton.gameObject);
		Destroy (UltraGraphicButton.gameObject);
		Destroy (maskimage.gameObject);
	}
}
