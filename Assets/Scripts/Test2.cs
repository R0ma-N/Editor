using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    [Header("Variables")]
    public NewBehaviourScript a;
    public int _min;
    public int _max;

    [Space(50), Header("Variables2")]

    public int gh;
    [ContextMenuItem("Randomize", nameof(Randomize))]
    [SerializeField] private int _testPrivate;

    [Range(0, 10)]
    public int b;

    [Multiline(5)]
    public string jklhk;

    [SerializeField, TextArea(4, 4), Tooltip("it is that")] string you;

    [SerializeField]

    void Randomize()
    {
        _testPrivate = UnityEngine.Random.Range(_min, _max);
    }

}
