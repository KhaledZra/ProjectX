namespace UserInterface;

//Ska grid "stänga in/hålla ute" -dvs zones en spelare ej kan befinna sig på?
public class Grid
{
    public static void CreateGrid(int[,] twoDMap)
    {
        // Grid X axis
        for (int x = 0; x < twoDMap.GetLength(0); x++)
        {
            twoDMap[0, x] = 1;
            twoDMap[twoDMap.GetLength(1)-1, x] = 1;
        }

        // Grid Y axis
        for (int y = 0; y < twoDMap.GetLength(1); y++)
        {
            twoDMap[y, 0] = 1;
            twoDMap[y, twoDMap.GetLength(0)-1] = 1;
        }
    }

}