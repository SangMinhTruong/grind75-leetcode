public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        int sourceColor = image[sr][sc];
        FloodFill(image, sr, sc, color, sourceColor);

        return image;
    }

    public void FloodFill(int[][] image, int sr, int sc, int color, int sourceColor) {
        if(sr >= image.Length || sr < 0
            || sc >= image[0].Length || sc < 0
            || image[sr][sc] != sourceColor || image[sr][sc] == color) {
            return;
        }

        image[sr][sc] = color;

        FloodFill(image, sr + 1, sc, color, sourceColor);
        FloodFill(image, sr, sc + 1, color, sourceColor);
        FloodFill(image, sr - 1, sc, color, sourceColor);
        FloodFill(image, sr, sc - 1, color, sourceColor);
    }
}