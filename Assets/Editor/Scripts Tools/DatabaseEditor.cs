using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DatabaseEditor : EditorWindow
{

    string test = "bonjour";
    [MenuItem("Outils/Database")]

    public static void ShowWindow()
    {
        EditorWindow.GetWindow<DatabaseEditor>("Database");
    }

    void OnGUI()
    {
        GUILayout.Label(test, EditorStyles.boldLabel);
        Handles.DrawLine(new Vector3(0, 50), new Vector3(maxSize.x, 50));

        if(GUILayout.Button("Create quelque chose")){

        }
    }
}
