using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using System.Linq;

public static class SceneSelector
{

    [MenuItem("Scenes/Safal Lobby")]
    static void OpenLobby()
    {
        Load("Lobby");
    }

    [MenuItem("Scenes/Priyam OwnRoom")]
    static void OpenOwnRoom()
    {
        Load("OwnRoom");
    }

    [MenuItem("Scenes/Shyngys Police Station")]
    static void OpenPolice()
    {
        Load("Working");
    }


    static void Load(string scene)
    {
        EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();

        Scene xrScene = EditorSceneManager.OpenScene("Assets/Scenes/XR.unity", OpenSceneMode.Single);
        Scene newScene = EditorSceneManager.OpenScene("Assets/Scenes/" + scene + ".unity", OpenSceneMode.Additive);

        XRSceneTransitionManager.PlaceXRRig(xrScene, newScene);
    }

    

}
