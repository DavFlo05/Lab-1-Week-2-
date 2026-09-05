using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    public float squareSize = 1f;

    private void OnDrawGizmos()
    {
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                Vector3 squarePosition = transform.position + new Vector3(x * squareSize, y * squareSize, 0);
            }
        }
    }
}
