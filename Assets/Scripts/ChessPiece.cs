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
}
