using UnityEngine;
public enum PieceType
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
        Queen,
        King
    }
public class ChessPiece : MonoBehaviour
{
    public PieceType pieceType;
    private SpriteRenderer spriteRenderer;
    public Color pieceColor = Color.white;
    private void DrawMove(Vector3 offset)
    {
        Gizmos.DrawWireCube(transform.position + offset, Vector3.one * 0.5f);
    }
    private void OnDrawGizmosSelected()
    {
        switch (pieceType)
        {
            case PieceType.Pawn:
                DrawPawnMoves();
                break;

            case PieceType.Rook:
                DrawRookMoves();
                break;

            case PieceType.Knight:
                DrawKnightMoves();
                break;

            case PieceType.Bishop:
                DrawBishopMoves();
                break;

            case PieceType.Queen:
                DrawQueenMoves();
                break;

            case PieceType.King:
                DrawKingMoves();
                break;
        }
    }
    private void DrawPawnMoves()
    {
        DrawMove(Vector3.up);
    }
    private void DrawRookMoves()
    {
        for (int i = 1; i < 8; i++)
        {
            DrawMove(Vector3.up * i);
            DrawMove(Vector3.down * i);
            DrawMove(Vector3.left * i);
            DrawMove(Vector3.right * i);
        }
    }
    private void DrawBishopMoves()
    {
        for (int i = 1; i < 8; i++)
        {
            DrawMove(new Vector3(i, i, 0));
            DrawMove(new Vector3(-i, i, 0));
            DrawMove(new Vector3(i, -i, 0));
            DrawMove(new Vector3(-i, -i, 0));
        }
    }
    private void DrawQueenMoves()
    {
        DrawRookMoves();
        DrawBishopMoves();
    }
    private void DrawKingMoves()
    {
        DrawMove(Vector3.up);
        DrawMove(Vector3.down);
        DrawMove(Vector3.left);
        DrawMove(Vector3.right);

        DrawMove(new Vector3(1, 1, 0));
        DrawMove(new Vector3(-1, 1, 0));
        DrawMove(new Vector3(1, -1, 0));
        DrawMove(new Vector3(-1, -1, 0));
    }
    private void DrawKnightMoves()
    {
        DrawMove(new Vector3(1, 2, 0));
        DrawMove(new Vector3(-1, 2, 0));

        DrawMove(new Vector3(1, -2, 0));
        DrawMove(new Vector3(-1, -2, 0));

        DrawMove(new Vector3(2, 1, 0));
        DrawMove(new Vector3(2, -1, 0));

        DrawMove(new Vector3(-2, 1, 0));
        DrawMove(new Vector3(-2, -1, 0));
    }
    private void OnValidate()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
            return;
        spriteRenderer.color = pieceColor;

        switch (pieceType)
        {
            case PieceType.Pawn:
                spriteRenderer.sprite = pawnSprite;
                break;
            case PieceType.Rook:
                spriteRenderer.sprite = rookSprite;
                break;
            case PieceType.Knight:
                spriteRenderer.sprite = knightSprite;
                break;
            case PieceType.Bishop:
                spriteRenderer.sprite = bishopSprite;
                break;
            case PieceType.Queen:
                spriteRenderer.sprite = queenSprite;
                break;
            case PieceType.King:
                spriteRenderer.sprite = kingSprite;
                break;
        }
    }
    public Sprite pawnSprite;
    public Sprite rookSprite;
    public Sprite knightSprite;
    public Sprite bishopSprite;
    public Sprite queenSprite;
    public Sprite kingSprite;
}
