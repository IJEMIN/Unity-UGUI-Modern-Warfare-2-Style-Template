using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class SettingPannel : MonoBehaviour {

	public Dropdown resolutionDropdown;
	public Dropdown qualityDropdown;
	private bool m_isFullscreen;

	void Start()
	{
		m_isFullscreen = Screen.fullScreen;

		// 초기화 (해상도 세팅)
		resolutionDropdown.ClearOptions();


		List<string> resOptions = (from resolution in Screen.resolutions select resolution.ToString()).ToList();

		resolutionDropdown.AddOptions(resOptions);
		resolutionDropdown.RefreshShownValue();

		resolutionDropdown.captionText.text = Screen.currentResolution.ToString();

		// 초기화 (퀄리티 세팅)
		qualityDropdown.ClearOptions();

		qualityDropdown.AddOptions(QualitySettings.names.ToList());
		qualityDropdown.RefreshShownValue();

		qualityDropdown.captionText.text = QualitySettings.names[QualitySettings.GetQualityLevel()];

	}

	public void OnResolutionSelected(int index)
	{
		var selectedResolution = Screen.resolutions[index];
		Screen.SetResolution(selectedResolution.width,selectedResolution.height,m_isFullscreen,selectedResolution.refreshRate);
	}

	public void SetFullscreen(bool isFullscreen)
	{
		m_isFullscreen = isFullscreen;
		Screen.fullScreen = m_isFullscreen;
	}

	public void SetQuality(int index)
	{
		QualitySettings.SetQualityLevel(index);
	}
}
