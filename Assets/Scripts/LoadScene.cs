using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour 
{
	public void LoadSceneNum(int index)
	{
		Application.LoadLevel(index);
	}

	public void QuitMenu()
	{
		Application.Quit();
	}
}