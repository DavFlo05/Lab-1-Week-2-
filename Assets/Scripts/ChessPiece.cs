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

    private void OnValidate()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

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
