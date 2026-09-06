using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ChessPiece))]
public class ChessPieceEditor : Editor
{
    private void OnSceneGUI()
    {
        ChessPiece piece = (ChessPiece)target;

        Handles.DrawWireCube(
            piece.transform.position,
            new Vector3(piece.borderSize, piece.borderSize, 0)
        );

        EditorGUI.BeginChangeCheck();

        float newSize = Handles.ScaleValueHandle(
            piece.borderSize,
            piece.transform.position + Vector3.right * piece.borderSize,
            Quaternion.identity,
            0.2f,
            Handles.CubeHandleCap,
            0.1f
        );

        if (EditorGUI.EndChangeCheck())
        {
            Undo.RecordObject(piece, "Change Border Size");

            piece.borderSize = newSize;

            EditorUtility.SetDirty(piece);
        }
    }
}
