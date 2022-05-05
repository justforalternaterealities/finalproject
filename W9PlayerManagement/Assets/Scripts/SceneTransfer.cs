using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer : MonoBehaviour
{
    public string toScene = "XR";
    string previousScene;

    public void Transfer()
    {
        if (gameObject.scene.name == toScene) return;

        if (transform.parent != null)
        {
            transform.SetParent(null);
        }

        Scene newScene = SceneManager.GetSceneByName(toScene);
        if (newScene.IsValid())
        {
            previousScene = gameObject.scene.name;
            SceneManager.MoveGameObjectToScene(gameObject, newScene);
        }
    }

    public void Return()
    {
        if (previousScene == string.Empty) return;

        Scene prevScene = SceneManager.GetSceneByName(previousScene);
        if (!prevScene.IsValid())
        {
            prevScene = SceneManager.GetActiveScene();
        }

        if (gameObject.scene.name == prevScene.name) return;

        SceneManager.MoveGameObjectToScene(gameObject, prevScene);
    }
}
