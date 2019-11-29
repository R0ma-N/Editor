using UnityEngine;
using UnityEditor;

namespace MyEditor
{
    public class Window : EditorWindow
    {
        public GameObject Prefab;
        public GameObject[] _objs;
        public string _name = "GObject";
        public int _countObject;
        public int _space;
        public bool _groupEnabled;

        private void OnGUI()
        {
            GUILayout.Label("Объекты для вставки", EditorStyles.boldLabel);
            Prefab = EditorGUILayout.ObjectField("Объект", Prefab, typeof(GameObject), true) as GameObject;
            _name = EditorGUILayout.TextField("Имя объекта", _name);
           
            _groupEnabled = EditorGUILayout.BeginToggleGroup("Дополнительные настройки", _groupEnabled);
            _countObject = EditorGUILayout.IntSlider("Количество объектов", _countObject, 1, 10);
            _space = EditorGUILayout.IntSlider("Площадь", _space, 10, 30);
            EditorGUILayout.EndToggleGroup();

            if (GUILayout.Button("Создать объекты"))
            {
                if (Prefab)
                {
                    GameObject root = new GameObject("Root");
                    root.tag = "NewObjs";
                    for (int i = 0; i < _countObject; i++)
                    {
                        Vector3 pos = new Vector3(Random.Range(-_space, _space), 0, Random.Range(-_space, _space));
                        GameObject temp = Instantiate(Prefab, pos, Quaternion.identity);
                        temp.name = _name + "_" + i;
                        temp.tag = "NewObjs";
                        temp.transform.parent = root.transform;
                    }
                }
            }

            if (GUILayout.Button("Удалить объекты"))
            {
                _objs = GameObject.FindGameObjectsWithTag("NewObjs");
                if (_objs != null)
                {
                    for (int i = 0; i < _objs.Length; i++)
                    {
                        DestroyImmediate(_objs[i]);
                    }
                }
            }
        }
    }
}
