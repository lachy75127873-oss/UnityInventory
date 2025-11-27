#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using TMPro;

public class TMPFontReplacer : MonoBehaviour
{
    public TMP_FontAsset newFont;

    [ContextMenu("Replace TMP Fonts")]
    void ReplaceFonts()
    {
        var texts = FindObjectsOfType<TextMeshProUGUI>(true); //활성,비활성된 모든 텍스트 객체들 찾기
        foreach (var t in texts)
        {
            Undo.RecordObject(t, "Replace TMP Font"); //undo기록 남기기 
            t.font = newFont;
        }
        Debug.Log($"Replaced Fonts on {texts.Length} TextMeshProUGUI objects!");
    }
}
#endif