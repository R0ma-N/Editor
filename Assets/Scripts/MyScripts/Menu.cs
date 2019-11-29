using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MyEditor
{
    public class Menu
    {
        [MenuItem("Новое меню/Окно", false, 0)]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(Window), false, "Объекты");
        }
    }
}
