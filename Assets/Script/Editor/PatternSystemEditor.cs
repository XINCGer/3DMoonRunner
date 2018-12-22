using UnityEngine;
using System.Collections;
using UnityEditor;

public class PatternSystemEditor : EditorWindow {

    [MenuItem("Window/AddPatternToSystem")]
    static void AddPatternToSystem()
    {
        var gameManager = GameObject.Find("GameManager");
        if(gameManager !=null)
        {
            var patternManager = gameManager.GetComponent<PatternManager>();

            if (Selection.gameObjects.Length == 1)
            {
                var item =  Selection.gameObjects[0].transform.Find("Item");
                if (item != null)
                {
                    Pattern pattern = new Pattern();
                    foreach (var child in item)
                    {
                        Transform childTransform = child as Transform;
                        if (childTransform != null)
                        {
                            var prefeb = UnityEditor.PrefabUtility.GetCorrespondingObjectFromSource(childTransform.gameObject);
                            if (prefeb != null)
                            {
                                PatternItem patternItem = new PatternItem
                                {
                                    gameobject = prefeb as GameObject,
                                    position = childTransform.transform.localPosition
                                };
                                pattern.PatternItems.Add(patternItem);
                            }
                        }
                    }
                    patternManager.Patterns.Add(pattern);
                }
            }

        }
    }
}
