using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string levelToLoad = "MainLevel";
	/*public string mainMenu = "MainMenu";*/
	public SceneFader sceneFader;

	public void Play ()
	{
		sceneFader.FadeTo(levelToLoad);
	}
	public void Setting()
	{
		SceneManager.LoadScene("SettingsMenu");
	}
	public void Back()
    {
		SceneManager.LoadScene("MainMenu");
	}
	public void Quit ()
	{
		Debug.Log("Exciting...");
		Application.Quit();
	}

}
