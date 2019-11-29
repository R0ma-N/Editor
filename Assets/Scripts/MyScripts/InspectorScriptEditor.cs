using UnityEngine;
using UnityEditor;

namespace MyEditor
{
    [CustomEditor(typeof(InspectorScript))]
    public class InspectorScriptEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            GUILayout.Label("Объект", EditorStyles.boldLabel);
            InspectorScript myScript = (InspectorScript)target;
            myScript.Prefab = EditorGUILayout.ObjectField("Объект", myScript.Prefab, typeof(GameObject), false)
                    as GameObject;
            myScript._name = EditorGUILayout.TextField("Имя объекта", myScript._name = "GObject");
            GUILayout.Label("Настройки", EditorStyles.boldLabel);
            myScript._countObject = EditorGUILayout.IntSlider(myScript._countObject, 1, 20);

            myScript._space = EditorGUILayout.IntSlider(myScript._space, 20, 50);

            bool isPressButtonCreate = GUILayout.Button("Создать объекты", EditorStyles.miniButtonLeft);
            bool isPressButtonDelete = GUILayout.Button("Удалить объекты", EditorStyles.miniButtonLeft);

            if (isPressButtonCreate)
            {
                myScript.CreateObjs();
            }

            if (isPressButtonDelete)
            {
                myScript.DeleteObjs();
            }
        }
    }
}

