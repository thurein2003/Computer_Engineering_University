using System;
using System.Threading;

class SpinningDonut
{
    static void Main()
    {
        float A = 0, B = 0;
        float i, j;
        int k;
        float[] z = new float[1760];
        char[] b = new char[1760];
        Console.Write("\x1b[2J");

        while (true)
        {
            Array.Fill(b, ' ');
            Array.Fill(z, 0f);

            for (j = 0; j < 6.28; j += 0.07f)
            {
                for (i = 0; i < 6.28; i += 0.02f)
                {
                    float c = (float)Math.Sin(i);
                    float d = (float)Math.Cos(j);
                    float e = (float)Math.Sin(A);
                    float f = (float)Math.Sin(j);
                    float g = (float)Math.Cos(A);
                    float h = d + 2;
                    float D = 1 / (c * h * e + f * g + 5);
                    float l = (float)Math.Cos(i);
                    float m = (float)Math.Cos(B);
                    float n = (float)Math.Sin(B);
                    float t = c * h * g - f * e;
                    int x = 40 + (int)(30 * D * (l * h * m - t * n));
                    int y = 12 + (int)(15 * D * (l * h * n + t * m));
                    int o = x + 80 * y;
                    int N = (int)(8 * ((f * e - c * d * g) * m - c * d * e - f * g - l * d * n));

                    if (y > 0 && y < 22 && x > 0 && x < 80 && D > z[o])
                    {
                        z[o] = D;
                        b[o] = ".,-~:;=!*#$@"[N > 0 ? N : 0];
                    }
                }
            }

            Console.SetCursorPosition(0, 0);

            for (k = 0; k < 1761; k++)
            {
                Console.Write(k % 80 == 0 ? '\n' : b[k]);
                A += 0.00004f;
                B += 0.00002f;
            }

            Thread.Sleep(30); 
        }
    }
}
