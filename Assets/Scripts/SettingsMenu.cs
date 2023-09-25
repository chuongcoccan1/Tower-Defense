using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour {

	public string setting = "SettingsMenu";

	public SceneFader sceneFader;

	public void Setting ()
	{
		sceneFader.FadeTo(setting);
	}
	
	

}
