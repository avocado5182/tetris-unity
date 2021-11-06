using System.Collections.Generic;

public class Constants {
    public const int Columns = 20;
    public const int Rows = 10;

    // I,
    // L,
    // J,
    // T,
    // O,
    // S,
    // Z
    public static readonly Dictionary<string, int[,]> Shapes = new Dictionary<string, int[,]>() {
        {
            "I", new int[,] {
                {0, 0, 0, 0},
                {1, 1, 1, 1},
                {0, 0, 0, 0},
                {0, 0, 0, 0}
            }
        }, {
            "L", new int[,] {
                {1, 0, 0},
                {1, 1, 1},
                {0, 0, 0}
            }
        }, {
            "J", new int[,] {
                {0, 0, 1},
                {1, 1, 1},
                {0, 0, 0}
            }
        }, {
            "T", new int[,] {
                {0, 1, 0},
                {1, 1, 1},
                {0, 0, 0}
            }
        }, {
            "O", new int[,] {
                {1, 1},
                {1, 1}
            }
        }, {
            "S", new int[,] {
                {0, 1, 1},
                {1, 1, 0},
                {0, 0, 0}
            }
        }, {
            "Z", new int[,] {
                {1, 1, 0},
                {0, 1, 1},
                {0, 0, 0}
            }
        }
    };
}