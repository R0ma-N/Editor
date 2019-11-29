using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MyEditor
{
    public class InspectorScript : MonoBehaviour
    {
        public GameObject Prefab;
        public string _name;
        public int _countObject;
        public int _space;
        private GameObject[] _objs;
        
        public void CreateObjs()
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

        public void DeleteObjs()
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

