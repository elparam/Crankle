using UnityEngine;

public class ChangeScene : MonoBehaviour {

	public void ChangeToScene (int sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }
}
