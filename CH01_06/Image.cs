using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01_06
{

    class Image
    {
        private char[,] data;

        public Image(char[,] image)
        {
            data = image;
        }


        public static void Rotate90Degrees(Image image)
        {
            char[,] array = image.data;

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            char[,] newArray = new char[rows, cols];


            for(int i =0, k=cols-1; i < rows; i++, k-- )
            {
                for(int j = 0; j < cols; j++)
                {
                    newArray[j,k] = array[i,j];
                }
            }

            image.data = newArray;


        }

        public static void Rotate90DegInPlace(Image img)
        {
            char[,] array = img.data;

            int n = array.GetLength(0); //NxN rows == cols
            
            for(int layer=0; layer < n/2; layer++)
            {
                int last = n-1-layer;

                for (int i = layer; i < last; i++)
                {
                    int offset = i - layer;

                    //save top
                    char top = array[layer, i];

                    //left -> top
                    array[layer,i] = array[last-offset, layer];

                    //bottom -> left

                    array[last - offset, layer] = array[last, last - offset];

                    // right -> bottom
                    array[last, last - offset] = array[i,last];

                    //top -> right
                    array[i, last] = top;

                }

            }


        }

    }

   

}
