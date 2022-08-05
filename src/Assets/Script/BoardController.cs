using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    public const int BOARD_WIDTH = 6;
    public const int BOARD_HEIGHT = 6;

    int[,] _board = new int[BOARD_WIDTH, BOARD_HEIGHT];

    private void ClearAll()
    {
        for (int y = 0; y < BOARD_WIDTH; y++)
        {
            for (int x = 0; x < BOARD_WIDTH; x++)
            {
                _board[y, x] = 0;
            }
        }
    }
    public void Start()
    {
        ClearAll();
    }
    public static bool IsValidated(Vector2Int pos)
    {
        return 0 <= pos.x && pos.y < BOARD_WIDTH && 0 <= pos.x && pos.y < BOARD_HEIGHT;
    }
    public bool CanSettle(Vector2Int pos)
    {
        if (IsValidated(pos))
        {
            return false;
        }
        return 0 == _board[pos.y, pos.x];
    }
}
