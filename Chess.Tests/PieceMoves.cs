using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Tests
{
    internal class PieceMoves
    {
        public Dictionary<char, List<char>> GetRookMoves()
        {
            return new Dictionary<char, List<char>>
            {
                { '1', new List<char> { '4', '7', '2', '3' } },
                { '2', new List<char> { '1', '3', '5', '8', '0' } },
                { '3', new List<char> { '1', '2', '6', '9' } },
                { '4', new List<char> { '1', '5', '6', '7' } },
                { '5', new List<char> { '2', '4', '6', '8', '0' } },
                { '6', new List<char> { '3', '4', '5', '9' } },
                { '7', new List<char> { '1', '4', '8', '9' } },
                { '8', new List<char> { '2', '5', '7', '9', '0' } },
                { '9', new List<char> { '3', '6', '7', '8' } },
                { '0', new List<char> { '2', '5', '8' } },
                { '*', new List<char>() },
                { '#', new List<char>() }
            };
        }

        public Dictionary<char, List<char>> GetKnightMoves()
        {
            return new Dictionary<char, List<char>>
            {
                { '1', new List<char> { '6', '8' } },
                { '2', new List<char> { '7', '9' } },
                { '3', new List<char> { '4', '8' } },
                { '4', new List<char> { '3', '9', '0' } },
                { '5', new List<char>() },
                { '6', new List<char> { '1', '7', '0' } },
                { '7', new List<char> { '2', '6' } },
                { '8', new List<char> { '1', '3' } },
                { '9', new List<char> { '2', '4' } },
                { '0', new List<char> { '4', '6' } },
                { '*', new List<char>() },
                { '#', new List<char>() }
            };
        }

        public Dictionary<char, List<char>> GetBishopMoves()
        {
            return new Dictionary<char, List<char>>
            {
                { '1', new List<char> { '5', '9' } },
                { '2', new List<char> { '4', '6' } },
                { '3', new List<char> { '5', '7' } },
                { '4', new List<char> { '2', '8' } },
                { '5', new List<char> { '1', '3', '7', '9' } },
                { '6', new List<char> { '2', '8' } },
                { '7', new List<char> { '3', '5', '0' } },
                { '8', new List<char> { '4', '6' } },
                { '9', new List<char> { '1', '5', '0' } },
                { '0', new List<char> { '7', '9' } },
                { '*', new List<char>() },
                { '#', new List<char>() }
            };
        }

        public Dictionary<char, List<char>> GetQueenMoves()
        {
            return new Dictionary<char, List<char>>
            {
                { '1', new List<char> { '2', '3', '4', '5', '7', '9' } },
                { '2', new List<char> { '1', '3', '4', '5', '6', '8', '0' } },
                { '3', new List<char> { '1', '2', '5', '6', '7', '9' } },
                { '4', new List<char> { '1', '2', '5', '6', '7', '8' } },
                { '5', new List<char> { '1', '2', '3', '4', '6', '7', '8', '9', '0' } },
                { '6', new List<char> { '2', '3', '4', '5', '8', '9' } },
                { '7', new List<char> { '1', '3', '4', '5', '8', '9', '0' } },
                { '8', new List<char> { '2', '4', '5', '6', '7', '9', '0' } },
                { '9', new List<char> { '1', '3', '5', '6', '7', '8', '0' } },
                { '0', new List<char> { '2', '5', '7', '8', '9' } },
                { '*', new List<char>() },
                { '#', new List<char>() }
            };
        }

        public Dictionary<char, List<char>> GetKingMoves()
        {
            return new Dictionary<char, List<char>>
            {
                { '1', new List<char> { '2', '4', '5' } },
                { '2', new List<char> { '1', '3', '4', '5', '6' } },
                { '3', new List<char> { '2', '5', '6' } },
                { '4', new List<char> { '1', '2', '5', '7', '8' } },
                { '5', new List<char> { '1', '2', '3', '4', '6', '7', '8', '9' } },
                { '6', new List<char> { '2', '3', '5', '8', '9' } },
                { '7', new List<char> { '4', '5', '8', '0' } },
                { '8', new List<char> { '4', '5', '6', '7', '9', '0' } },
                { '9', new List<char> { '5', '6', '8', '0' } },
                { '0', new List<char> { '9', '7', '8' } },
                { '*', new List<char>() },
                { '#', new List<char>() }
            };
        }

        public Dictionary<char, List<char>> GetPawnMoves()
        {
            return new Dictionary<char, List<char>>
            {
                { '1', new List<char> { '4' } },
                { '2', new List<char> { '5' } },
                { '3', new List<char> { '6' } },
                { '4', new List<char> { '7' } },
                { '5', new List<char> { '8' } },
                { '6', new List<char> { '9' } },
                { '7', new List<char>() },
                { '8', new List<char>() },
                { '9', new List<char>() },
                { '0', new List<char>() },
                { '*', new List<char>() },
                { '#', new List<char>() }
            };
        }

    }
}
