using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ChessLogic;
namespace ChessUI
{
    public static class Images
    {
        private static readonly Dictionary<PieceType, ImageSource> whiteSources = new()
        {
            { PieceType.Pawn, LoadImage("Assets/chess-pawn-white.png")},
            { PieceType.Bishop, LoadImage("Assets/chess-bishop-white.png")},
            { PieceType.Knight, LoadImage("Assets/chess-knight-white.png")},
            { PieceType.Rook, LoadImage("Assets/chess-rook-white.png")},
            { PieceType.Queen, LoadImage("Assets/chess-queen-white.png")},
            { PieceType.King, LoadImage("Assets/chess-king-white.png")},
        };
        private static readonly Dictionary<PieceType, ImageSource> blackSources = new()
        {
            { PieceType.Pawn, LoadImage("Assets/chess-pawn-black.png")},
            { PieceType.Bishop, LoadImage("Assets/chess-bishop-black.png")},
            { PieceType.Knight, LoadImage("Assets/chess-knight-black.png")},
            { PieceType.Rook, LoadImage("Assets/chess-rook-black.png")},
            { PieceType.Queen, LoadImage("Assets/chess-queen-black.png")},
            { PieceType.King, LoadImage("Assets/chess-king-black.png")},
        };
        private static ImageSource LoadImage(string filepath)
        {
            return new BitmapImage(new Uri(filepath, UriKind.Relative));
        }
        public static ImageSource GetImage(Player color, PieceType type)
        {
            return color switch
            {
                Player.White => whiteSources[type],
                Player.Black => blackSources[type],
                _ => null
            };
        }
        public static ImageSource GetImage(Piece piece)
        {
            if (piece == null) return null;
            return GetImage(piece.Color, piece.Type);
        }
    }
}
