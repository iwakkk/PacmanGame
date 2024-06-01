internal class Program
{

    static string[,] tembok = new string[31, 60];
    static string[,] setan = new string[31, 57]; //array posisi Setan Semua
    static bool statusghostmerah = false;
    static bool statusghostpink = false;
    static bool statusghostbiru = false;
    static bool statusghostorange = false;


    static void CetakMap()
    {
        for (int i = 0; i <= 30; i++)
        {
            for (int j = 0; j <= 54; j++)
            {
                if (setan[i, j] == "")
                {
                    //CETAK MAP
                    if (i == 12 && (j == 26 || j == 28))
                        Console.Write("{0}", tembok[i, j], Console.ForegroundColor = ConsoleColor.Green);// GERBANG [12,26] [12,28]
                    else if (tembok[i, j] == "?")
                        Console.Write("{0}", tembok[i, j], Console.ForegroundColor = ConsoleColor.DarkBlue);//WARNAIN TEMBOK
                    else if (tembok[i, j] == "*")
                        Console.Write("{0}", tembok[i, j], Console.ForegroundColor = ConsoleColor.Yellow);//WARNAIN MAKANAN
                    else if (tembok[i, j] == "O")
                        Console.Write("{0}", tembok[i, j], Console.ForegroundColor = ConsoleColor.DarkGreen);//WARNAIN MAKANAN YANG MENGUBAH PACKMAN MENGEJAR HANTU
                    else if (tembok[i, j] == " ")
                        Console.Write(" ");//SPASI

                    else if (tembok[i, j] == "C")
                        Console.Write("C", Console.ForegroundColor = ConsoleColor.White);//PACMAN
                }
                else if (setan[i, j] == "@" && statusghostmerah == false)
                {
                    Console.Write("@", Console.ForegroundColor = ConsoleColor.Red);
                }
                else if (setan[i, j] == "#" && statusghostpink == false)
                {
                    Console.Write("#", Console.ForegroundColor = ConsoleColor.Magenta);
                }
                else if (setan[i, j] == "$" && statusghostbiru == false)
                {
                    Console.Write("$", Console.ForegroundColor = ConsoleColor.Cyan);
                }
                else if (setan[i, j] == "%" && statusghostorange == false)
                {
                    Console.Write("%", Console.ForegroundColor = ConsoleColor.DarkYellow);
                }

                else if (setan[i, j] == "@" && statusghostmerah == true)
                {
                    Console.Write("@", Console.ForegroundColor = ConsoleColor.DarkCyan);
                }
                else if (setan[i, j] == "#" && statusghostpink == true)
                {
                    Console.Write("#", Console.ForegroundColor = ConsoleColor.DarkCyan);
                }
                else if (setan[i, j] == "$" && statusghostbiru == true)
                {
                    Console.Write("$", Console.ForegroundColor = ConsoleColor.DarkCyan);
                }
                else if (setan[i, j] == "%" && statusghostorange == true)
                {
                    Console.Write("%", Console.ForegroundColor = ConsoleColor.DarkCyan);
                }


            }
            Console.WriteLine();
        }
    }
    public static void Main(string[] args)
    {
    ulang:
        int level = 0;

        // BARIS KE 1
        {


            tembok[0, 0] = "?";
            tembok[0, 1] = " ";
            tembok[0, 2] = "?";
            tembok[0, 3] = " ";
            tembok[0, 4] = "?";
            tembok[0, 5] = " ";
            tembok[0, 6] = "?";
            tembok[0, 7] = " ";
            tembok[0, 8] = "?";
            tembok[0, 9] = " ";
            tembok[0, 10] = "?";
            tembok[0, 11] = " ";
            tembok[0, 12] = "?";
            tembok[0, 13] = " ";
            tembok[0, 14] = "?";
            tembok[0, 15] = " ";
            tembok[0, 16] = "?";
            tembok[0, 17] = " ";
            tembok[0, 18] = "?";
            tembok[0, 19] = " ";
            tembok[0, 20] = "?";
            tembok[0, 21] = " ";
            tembok[0, 22] = "?";
            tembok[0, 23] = " ";
            tembok[0, 24] = "?";
            tembok[0, 25] = " ";
            tembok[0, 26] = "?";
            tembok[0, 27] = " ";
            tembok[0, 28] = "?";
            tembok[0, 29] = " ";
            tembok[0, 30] = "?";
            tembok[0, 31] = " ";
            tembok[0, 32] = "?";
            tembok[0, 33] = " ";
            tembok[0, 34] = "?";
            tembok[0, 35] = " ";
            tembok[0, 36] = "?";
            tembok[0, 37] = " ";
            tembok[0, 38] = "?";
            tembok[0, 39] = " ";
            tembok[0, 40] = "?";
            tembok[0, 41] = " ";
            tembok[0, 42] = "?";
            tembok[0, 43] = " ";
            tembok[0, 44] = "?";
            tembok[0, 45] = " ";
            tembok[0, 46] = "?";
            tembok[0, 47] = " ";
            tembok[0, 48] = "?";
            tembok[0, 49] = " ";
            tembok[0, 50] = "?";
            tembok[0, 51] = " ";
            tembok[0, 52] = "?";
            tembok[0, 53] = " ";
            tembok[0, 54] = "?";
            // BARIS KE 2
            tembok[1, 0] = "?";
            tembok[1, 1] = " ";
            tembok[1, 2] = "*";
            tembok[1, 3] = " ";
            tembok[1, 4] = "*";
            tembok[1, 5] = " ";
            tembok[1, 6] = "*";
            tembok[1, 7] = " ";
            tembok[1, 8] = "*";
            tembok[1, 9] = " ";
            tembok[1, 10] = "*";
            tembok[1, 11] = " ";
            tembok[1, 12] = "*";
            tembok[1, 13] = " ";
            tembok[1, 14] = "*";
            tembok[1, 15] = " ";
            tembok[1, 16] = "*";
            tembok[1, 17] = " ";
            tembok[1, 18] = "*";
            tembok[1, 19] = " ";
            tembok[1, 20] = "*";
            tembok[1, 21] = " ";
            tembok[1, 22] = "*";
            tembok[1, 23] = " ";
            tembok[1, 24] = "*";
            tembok[1, 25] = " ";
            tembok[1, 26] = "?";
            tembok[1, 27] = " ";
            tembok[1, 28] = "?";
            tembok[1, 29] = " ";
            tembok[1, 30] = "*";
            tembok[1, 31] = " ";
            tembok[1, 32] = "*";
            tembok[1, 33] = " ";
            tembok[1, 34] = "*";
            tembok[1, 35] = " ";
            tembok[1, 36] = "*";
            tembok[1, 37] = " ";
            tembok[1, 38] = "*";
            tembok[1, 39] = " ";
            tembok[1, 40] = "*";
            tembok[1, 41] = " ";
            tembok[1, 42] = "*";
            tembok[1, 43] = " ";
            tembok[1, 44] = "*";
            tembok[1, 45] = " ";
            tembok[1, 46] = "*";
            tembok[1, 47] = " ";
            tembok[1, 48] = "*";
            tembok[1, 49] = " ";
            tembok[1, 50] = "*";
            tembok[1, 51] = " ";
            tembok[1, 52] = "*";
            tembok[1, 53] = " ";
            tembok[1, 54] = "?";
            // BARIS KE 3
            tembok[2, 0] = "?";
            tembok[2, 1] = " ";
            tembok[2, 2] = "*";
            tembok[2, 3] = " ";
            tembok[2, 4] = "?";
            tembok[2, 5] = " ";
            tembok[2, 6] = "?";
            tembok[2, 7] = " ";
            tembok[2, 8] = "?";
            tembok[2, 9] = " ";
            tembok[2, 10] = "?";
            tembok[2, 11] = " ";
            tembok[2, 12] = "*";
            tembok[2, 13] = " ";
            tembok[2, 14] = "?";
            tembok[2, 15] = " ";
            tembok[2, 16] = "?";
            tembok[2, 17] = " ";
            tembok[2, 18] = "?";
            tembok[2, 19] = " ";
            tembok[2, 20] = "?";
            tembok[2, 21] = " ";
            tembok[2, 22] = "?";
            tembok[2, 23] = " ";
            tembok[2, 24] = "*";
            tembok[2, 25] = " ";
            tembok[2, 26] = "?";
            tembok[2, 27] = " ";
            tembok[2, 28] = "?";
            tembok[2, 29] = " ";
            tembok[2, 30] = "*";
            tembok[2, 31] = " ";
            tembok[2, 32] = "?";
            tembok[2, 33] = " ";
            tembok[2, 34] = "?";
            tembok[2, 35] = " ";
            tembok[2, 36] = "?";
            tembok[2, 37] = " ";
            tembok[2, 38] = "?";
            tembok[2, 39] = " ";
            tembok[2, 40] = "?";
            tembok[2, 41] = " ";
            tembok[2, 42] = "*";
            tembok[2, 43] = " ";
            tembok[2, 44] = "?";
            tembok[2, 45] = " ";
            tembok[2, 46] = "?";
            tembok[2, 47] = " ";
            tembok[2, 48] = "?";
            tembok[2, 49] = " ";
            tembok[2, 50] = "?";
            tembok[2, 51] = " ";
            tembok[2, 52] = "*";
            tembok[2, 53] = " ";
            tembok[2, 54] = "?";
            // BARIS KE 4
            tembok[3, 0] = "?";
            tembok[3, 1] = " ";
            tembok[3, 2] = "O";
            tembok[3, 3] = " ";
            tembok[3, 4] = "?";
            tembok[3, 5] = " ";
            tembok[3, 6] = "?";
            tembok[3, 7] = " ";
            tembok[3, 8] = "?";
            tembok[3, 9] = " ";
            tembok[3, 10] = "?";
            tembok[3, 11] = " ";
            tembok[3, 12] = "*";
            tembok[3, 13] = " ";
            tembok[3, 14] = "?";
            tembok[3, 15] = " ";
            tembok[3, 16] = "?";
            tembok[3, 17] = " ";
            tembok[3, 18] = "?";
            tembok[3, 19] = " ";
            tembok[3, 20] = "?";
            tembok[3, 21] = " ";
            tembok[3, 22] = "?";
            tembok[3, 23] = " ";
            tembok[3, 24] = "*";
            tembok[3, 25] = " ";
            tembok[3, 26] = "?";
            tembok[3, 27] = " ";
            tembok[3, 28] = "?";
            tembok[3, 29] = " ";
            tembok[3, 30] = "*";
            tembok[3, 31] = " ";
            tembok[3, 32] = "?";
            tembok[3, 33] = " ";
            tembok[3, 34] = "?";
            tembok[3, 35] = " ";
            tembok[3, 36] = "?";
            tembok[3, 37] = " ";
            tembok[3, 38] = "?";
            tembok[3, 39] = " ";
            tembok[3, 40] = "?";
            tembok[3, 41] = " ";
            tembok[3, 42] = "*";
            tembok[3, 43] = " ";
            tembok[3, 44] = "?";
            tembok[3, 45] = " ";
            tembok[3, 46] = "?";
            tembok[3, 47] = " ";
            tembok[3, 48] = "?";
            tembok[3, 49] = " ";
            tembok[3, 50] = "?";
            tembok[3, 51] = " ";
            tembok[3, 52] = "O";
            tembok[3, 53] = " ";
            tembok[3, 54] = "?";
            // BARIS KE 5
            tembok[4, 0] = "?";
            tembok[4, 1] = " ";
            tembok[4, 2] = "*";
            tembok[4, 3] = " ";
            tembok[4, 4] = "?";
            tembok[4, 5] = " ";
            tembok[4, 6] = "?";
            tembok[4, 7] = " ";
            tembok[4, 8] = "?";
            tembok[4, 9] = " ";
            tembok[4, 10] = "?";
            tembok[4, 11] = " ";
            tembok[4, 12] = "*";
            tembok[4, 13] = " ";
            tembok[4, 14] = "?";
            tembok[4, 15] = " ";
            tembok[4, 16] = "?";
            tembok[4, 17] = " ";
            tembok[4, 18] = "?";
            tembok[4, 19] = " ";
            tembok[4, 20] = "?";
            tembok[4, 21] = " ";
            tembok[4, 22] = "?";
            tembok[4, 23] = " ";
            tembok[4, 24] = "*";
            tembok[4, 25] = " ";
            tembok[4, 26] = "?";
            tembok[4, 27] = " ";
            tembok[4, 28] = "?";
            tembok[4, 29] = " ";
            tembok[4, 30] = "*";
            tembok[4, 31] = " ";
            tembok[4, 32] = "?";
            tembok[4, 33] = " ";
            tembok[4, 34] = "?";
            tembok[4, 35] = " ";
            tembok[4, 36] = "?";
            tembok[4, 37] = " ";
            tembok[4, 38] = "?";
            tembok[4, 39] = " ";
            tembok[4, 40] = "?";
            tembok[4, 41] = " ";
            tembok[4, 42] = "*";
            tembok[4, 43] = " ";
            tembok[4, 44] = "?";
            tembok[4, 45] = " ";
            tembok[4, 46] = "?";
            tembok[4, 47] = " ";
            tembok[4, 48] = "?";
            tembok[4, 49] = " ";
            tembok[4, 50] = "?";
            tembok[4, 51] = " ";
            tembok[4, 52] = "*";
            tembok[4, 53] = " ";
            tembok[4, 54] = "?";
            // BARIS KE 6
            tembok[5, 0] = "?";
            tembok[5, 1] = " ";
            tembok[5, 2] = "*";
            tembok[5, 3] = " ";
            tembok[5, 4] = "*";
            tembok[5, 5] = " ";
            tembok[5, 6] = "*";
            tembok[5, 7] = " ";
            tembok[5, 8] = "*";
            tembok[5, 9] = " ";
            tembok[5, 10] = "*";
            tembok[5, 11] = " ";
            tembok[5, 12] = "*";
            tembok[5, 13] = " ";
            tembok[5, 14] = "*";
            tembok[5, 15] = " ";
            tembok[5, 16] = "*";
            tembok[5, 17] = " ";
            tembok[5, 18] = "*";
            tembok[5, 19] = " ";
            tembok[5, 20] = "*";
            tembok[5, 21] = " ";
            tembok[5, 22] = "*";
            tembok[5, 23] = " ";
            tembok[5, 24] = "*";
            tembok[5, 25] = " ";
            tembok[5, 26] = "*";
            tembok[5, 27] = " ";
            tembok[5, 28] = "*";
            tembok[5, 29] = " ";
            tembok[5, 30] = "*";
            tembok[5, 31] = " ";
            tembok[5, 32] = "*";
            tembok[5, 33] = " ";
            tembok[5, 34] = "*";
            tembok[5, 35] = " ";
            tembok[5, 36] = "*";
            tembok[5, 37] = " ";
            tembok[5, 38] = "*";
            tembok[5, 39] = " ";
            tembok[5, 40] = "*";
            tembok[5, 41] = " ";
            tembok[5, 42] = "*";
            tembok[5, 43] = " ";
            tembok[5, 44] = "*";
            tembok[5, 45] = " ";
            tembok[5, 46] = "*";
            tembok[5, 47] = " ";
            tembok[5, 48] = "*";
            tembok[5, 49] = " ";
            tembok[5, 50] = "*";
            tembok[5, 51] = " ";
            tembok[5, 52] = "*";
            tembok[5, 53] = " ";
            tembok[5, 54] = "?";
            // BARIS KE 7
            tembok[6, 0] = "?";
            tembok[6, 1] = " ";
            tembok[6, 2] = "*";
            tembok[6, 3] = " ";
            tembok[6, 4] = "?";
            tembok[6, 5] = " ";
            tembok[6, 6] = "?";
            tembok[6, 7] = " ";
            tembok[6, 8] = "?";
            tembok[6, 9] = " ";
            tembok[6, 10] = "?";
            tembok[6, 11] = " ";
            tembok[6, 12] = "*";
            tembok[6, 13] = " ";
            tembok[6, 14] = "?";
            tembok[6, 15] = " ";
            tembok[6, 16] = "?";
            tembok[6, 17] = " ";
            tembok[6, 18] = "*";
            tembok[6, 19] = " ";
            tembok[6, 20] = "?";
            tembok[6, 21] = " ";
            tembok[6, 22] = "?";
            tembok[6, 23] = " ";
            tembok[6, 24] = "?";
            tembok[6, 25] = " ";
            tembok[6, 26] = "?";
            tembok[6, 27] = " ";
            tembok[6, 28] = "?";
            tembok[6, 29] = " ";
            tembok[6, 30] = "?";
            tembok[6, 31] = " ";
            tembok[6, 32] = "?";
            tembok[6, 33] = " ";
            tembok[6, 34] = "?";
            tembok[6, 35] = " ";
            tembok[6, 36] = "*";
            tembok[6, 37] = " ";
            tembok[6, 38] = "?";
            tembok[6, 39] = " ";
            tembok[6, 40] = "?";
            tembok[6, 41] = " ";
            tembok[6, 42] = "*";
            tembok[6, 43] = " ";
            tembok[6, 44] = "?";
            tembok[6, 45] = " ";
            tembok[6, 46] = "?";
            tembok[6, 47] = " ";
            tembok[6, 48] = "?";
            tembok[6, 49] = " ";
            tembok[6, 50] = "?";
            tembok[6, 51] = " ";
            tembok[6, 52] = "*";
            tembok[6, 53] = " ";
            tembok[6, 54] = "?";
            // BARIS KE 8
            tembok[7, 0] = "?";
            tembok[7, 1] = " ";
            tembok[7, 2] = "*";
            tembok[7, 3] = " ";
            tembok[7, 4] = "?";
            tembok[7, 5] = " ";
            tembok[7, 6] = "?";
            tembok[7, 7] = " ";
            tembok[7, 8] = "?";
            tembok[7, 9] = " ";
            tembok[7, 10] = "?";
            tembok[7, 11] = " ";
            tembok[7, 12] = "*";
            tembok[7, 13] = " ";
            tembok[7, 14] = "?";
            tembok[7, 15] = " ";
            tembok[7, 16] = "?";
            tembok[7, 17] = " ";
            tembok[7, 18] = "*";
            tembok[7, 19] = " ";
            tembok[7, 20] = "?";
            tembok[7, 21] = " ";
            tembok[7, 22] = "?";
            tembok[7, 23] = " ";
            tembok[7, 24] = "?";
            tembok[7, 25] = " ";
            tembok[7, 26] = "?";
            tembok[7, 27] = " ";
            tembok[7, 28] = "?";
            tembok[7, 29] = " ";
            tembok[7, 30] = "?";
            tembok[7, 31] = " ";
            tembok[7, 32] = "?";
            tembok[7, 33] = " ";
            tembok[7, 34] = "?";
            tembok[7, 35] = " ";
            tembok[7, 36] = "*";
            tembok[7, 37] = " ";
            tembok[7, 38] = "?";
            tembok[7, 39] = " ";
            tembok[7, 40] = "?";
            tembok[7, 41] = " ";
            tembok[7, 42] = "*";
            tembok[7, 43] = " ";
            tembok[7, 44] = "?";
            tembok[7, 45] = " ";
            tembok[7, 46] = "?";
            tembok[7, 47] = " ";
            tembok[7, 48] = "?";
            tembok[7, 49] = " ";
            tembok[7, 50] = "?";
            tembok[7, 51] = " ";
            tembok[7, 52] = "*";
            tembok[7, 53] = " ";
            tembok[7, 54] = "?";
            // BARIS KE 9
            tembok[8, 0] = "?";
            tembok[8, 1] = " ";
            tembok[8, 2] = "*";
            tembok[8, 3] = " ";
            tembok[8, 4] = "*";
            tembok[8, 5] = " ";
            tembok[8, 6] = "*";
            tembok[8, 7] = " ";
            tembok[8, 8] = "*";
            tembok[8, 9] = " ";
            tembok[8, 10] = "*";
            tembok[8, 11] = " ";
            tembok[8, 12] = "*";
            tembok[8, 13] = " ";
            tembok[8, 14] = "?";
            tembok[8, 15] = " ";
            tembok[8, 16] = "?";
            tembok[8, 17] = " ";
            tembok[8, 18] = "*";
            tembok[8, 19] = " ";
            tembok[8, 20] = "*";
            tembok[8, 21] = " ";
            tembok[8, 22] = "*";
            tembok[8, 23] = " ";
            tembok[8, 24] = "*";
            tembok[8, 25] = " ";
            tembok[8, 26] = "?";
            tembok[8, 27] = " ";
            tembok[8, 28] = "?";
            tembok[8, 29] = " ";
            tembok[8, 30] = "*";
            tembok[8, 31] = " ";
            tembok[8, 32] = "*";
            tembok[8, 33] = " ";
            tembok[8, 34] = "*";
            tembok[8, 35] = " ";
            tembok[8, 36] = "*";
            tembok[8, 37] = " ";
            tembok[8, 38] = "?";
            tembok[8, 39] = " ";
            tembok[8, 40] = "?";
            tembok[8, 41] = " ";
            tembok[8, 42] = "*";
            tembok[8, 43] = " ";
            tembok[8, 44] = "*";
            tembok[8, 45] = " ";
            tembok[8, 46] = "*";
            tembok[8, 47] = " ";
            tembok[8, 48] = "*";
            tembok[8, 49] = " ";
            tembok[8, 50] = "*";
            tembok[8, 51] = " ";
            tembok[8, 52] = "*";
            tembok[8, 53] = " ";
            tembok[8, 54] = "?";
            // BARIS KE 10
            tembok[9, 0] = "?";
            tembok[9, 1] = " ";
            tembok[9, 2] = "?";
            tembok[9, 3] = " ";
            tembok[9, 4] = "?";
            tembok[9, 5] = " ";
            tembok[9, 6] = "?";
            tembok[9, 7] = " ";
            tembok[9, 8] = "?";
            tembok[9, 9] = " ";
            tembok[9, 10] = "?";
            tembok[9, 11] = " ";
            tembok[9, 12] = "*";
            tembok[9, 13] = " ";
            tembok[9, 14] = "?";
            tembok[9, 15] = " ";
            tembok[9, 16] = "?";
            tembok[9, 17] = " ";
            tembok[9, 18] = "?";
            tembok[9, 19] = " ";
            tembok[9, 20] = "?";
            tembok[9, 21] = " ";
            tembok[9, 22] = "?";
            tembok[9, 23] = " ";
            tembok[9, 24] = " ";
            tembok[9, 25] = " ";
            tembok[9, 26] = "?";
            tembok[9, 27] = " ";
            tembok[9, 28] = "?";
            tembok[9, 29] = " ";
            tembok[9, 30] = " ";
            tembok[9, 31] = " ";
            tembok[9, 32] = "?";
            tembok[9, 33] = " ";
            tembok[9, 34] = "?";
            tembok[9, 35] = " ";
            tembok[9, 36] = "?";
            tembok[9, 37] = " ";
            tembok[9, 38] = "?";
            tembok[9, 39] = " ";
            tembok[9, 40] = "?";
            tembok[9, 41] = " ";
            tembok[9, 42] = "*";
            tembok[9, 43] = " ";
            tembok[9, 44] = "?";
            tembok[9, 45] = " ";
            tembok[9, 46] = "?";
            tembok[9, 47] = " ";
            tembok[9, 48] = "?";
            tembok[9, 49] = " ";
            tembok[9, 50] = "?";
            tembok[9, 51] = " ";
            tembok[9, 52] = "?";
            tembok[9, 53] = " ";
            tembok[9, 54] = "?";
            //BARIS KE 11
            tembok[10, 0] = " ";
            tembok[10, 1] = " ";
            tembok[10, 2] = " ";
            tembok[10, 3] = " ";
            tembok[10, 4] = " ";
            tembok[10, 5] = " ";
            tembok[10, 6] = " ";
            tembok[10, 7] = " ";
            tembok[10, 8] = " ";
            tembok[10, 9] = " ";
            tembok[10, 10] = "?";
            tembok[10, 11] = " ";
            tembok[10, 12] = "*";
            tembok[10, 13] = " ";
            tembok[10, 14] = "?";
            tembok[10, 15] = " ";
            tembok[10, 16] = "?";
            tembok[10, 17] = " ";
            tembok[10, 18] = "?";
            tembok[10, 19] = " ";
            tembok[10, 20] = "?";
            tembok[10, 21] = " ";
            tembok[10, 22] = "?";
            tembok[10, 23] = " ";
            tembok[10, 24] = " ";
            tembok[10, 25] = " ";
            tembok[10, 26] = "?";
            tembok[10, 27] = " ";
            tembok[10, 28] = "?";
            tembok[10, 29] = " ";
            tembok[10, 30] = " ";
            tembok[10, 31] = " ";
            tembok[10, 32] = "?";
            tembok[10, 33] = " ";
            tembok[10, 34] = "?";
            tembok[10, 35] = " ";
            tembok[10, 36] = "?";
            tembok[10, 37] = " ";
            tembok[10, 38] = "?";
            tembok[10, 39] = " ";
            tembok[10, 40] = "?";
            tembok[10, 41] = " ";
            tembok[10, 42] = "*";
            tembok[10, 43] = " ";
            tembok[10, 44] = "?";
            tembok[10, 45] = " ";
            tembok[10, 46] = " ";
            tembok[10, 47] = " ";
            tembok[10, 48] = " ";
            tembok[10, 49] = " ";
            tembok[10, 50] = " ";
            tembok[10, 51] = " ";
            tembok[10, 52] = " ";
            tembok[10, 53] = " ";
            tembok[10, 54] = " ";
            //BARIS KE 12
            tembok[11, 0] = " ";
            tembok[11, 1] = " ";
            tembok[11, 2] = " ";
            tembok[11, 3] = " ";
            tembok[11, 4] = " ";
            tembok[11, 5] = " ";
            tembok[11, 6] = " ";
            tembok[11, 7] = " ";
            tembok[11, 8] = " ";
            tembok[11, 9] = " ";
            tembok[11, 10] = "?";
            tembok[11, 11] = " ";
            tembok[11, 12] = "*";
            tembok[11, 13] = " ";
            tembok[11, 14] = "?";
            tembok[11, 15] = " ";
            tembok[11, 16] = "?";
            tembok[11, 17] = " ";
            tembok[11, 18] = " ";
            tembok[11, 19] = " ";
            tembok[11, 20] = " ";
            tembok[11, 21] = " ";
            tembok[11, 22] = " ";
            tembok[11, 23] = " ";
            tembok[11, 24] = " ";
            tembok[11, 25] = " ";
            tembok[11, 26] = " ";
            tembok[11, 27] = " ";
            tembok[11, 28] = " ";
            tembok[11, 29] = " ";
            tembok[11, 30] = " ";
            tembok[11, 31] = " ";
            tembok[11, 32] = " ";
            tembok[11, 33] = " ";
            tembok[11, 34] = " ";
            tembok[11, 35] = " ";
            tembok[11, 36] = " ";
            tembok[11, 37] = " ";
            tembok[11, 38] = "?";
            tembok[11, 39] = " ";
            tembok[11, 40] = "?";
            tembok[11, 41] = " ";
            tembok[11, 42] = "*";
            tembok[11, 43] = " ";
            tembok[11, 44] = "?";
            tembok[11, 45] = " ";
            tembok[11, 46] = " ";
            tembok[11, 47] = " ";
            tembok[11, 48] = " ";
            tembok[11, 49] = " ";
            tembok[11, 50] = " ";
            tembok[11, 51] = " ";
            tembok[11, 52] = " ";
            tembok[11, 53] = " ";
            tembok[11, 54] = " ";
            //BARIS KE 13
            tembok[12, 0] = " ";
            tembok[12, 1] = " ";
            tembok[12, 2] = " ";
            tembok[12, 3] = " ";
            tembok[12, 4] = " ";
            tembok[12, 5] = " ";
            tembok[12, 6] = " ";
            tembok[12, 7] = " ";
            tembok[12, 8] = " ";
            tembok[12, 9] = " ";
            tembok[12, 10] = "?";
            tembok[12, 11] = " ";
            tembok[12, 12] = "*";
            tembok[12, 13] = " ";
            tembok[12, 14] = "?";
            tembok[12, 15] = " ";
            tembok[12, 16] = "?";
            tembok[12, 17] = " ";
            tembok[12, 18] = " ";
            tembok[12, 19] = " ";
            tembok[12, 20] = "?";
            tembok[12, 21] = " ";
            tembok[12, 22] = "?";
            tembok[12, 23] = " ";
            tembok[12, 24] = "?";
            tembok[12, 25] = " ";
            tembok[12, 26] = "?";
            tembok[12, 27] = " ";
            tembok[12, 28] = "?";
            tembok[12, 29] = " ";
            tembok[12, 30] = "?";
            tembok[12, 31] = " ";
            tembok[12, 32] = "?";
            tembok[12, 33] = " ";
            tembok[12, 34] = "?";
            tembok[12, 35] = " ";
            tembok[12, 36] = " ";
            tembok[12, 37] = " ";
            tembok[12, 38] = "?";
            tembok[12, 39] = " ";
            tembok[12, 40] = "?";
            tembok[12, 41] = " ";
            tembok[12, 42] = "*";
            tembok[12, 43] = " ";
            tembok[12, 44] = "?";
            tembok[12, 45] = " ";
            tembok[12, 46] = " ";
            tembok[12, 47] = " ";
            tembok[12, 48] = " ";
            tembok[12, 49] = " ";
            tembok[12, 50] = " ";
            tembok[12, 51] = " ";
            tembok[12, 52] = " ";
            tembok[12, 53] = " ";
            tembok[12, 54] = " ";
            // BARIS KE 14
            tembok[13, 0] = "?";
            tembok[13, 1] = " ";
            tembok[13, 2] = "?";
            tembok[13, 3] = " ";
            tembok[13, 4] = "?";
            tembok[13, 5] = " ";
            tembok[13, 6] = "?";
            tembok[13, 7] = " ";
            tembok[13, 8] = "?";
            tembok[13, 9] = " ";
            tembok[13, 10] = "?";
            tembok[13, 11] = " ";
            tembok[13, 12] = "*";
            tembok[13, 13] = " ";
            tembok[13, 14] = "?";
            tembok[13, 15] = " ";
            tembok[13, 16] = "?";
            tembok[13, 17] = " ";
            tembok[13, 18] = " ";
            tembok[13, 19] = " ";
            tembok[13, 20] = "?";
            tembok[13, 21] = " ";
            tembok[13, 22] = " ";
            tembok[13, 23] = " ";
            tembok[13, 24] = " ";
            tembok[13, 25] = " ";
            tembok[13, 26] = " ";
            tembok[13, 27] = " ";
            tembok[13, 28] = " ";
            tembok[13, 29] = " ";
            tembok[13, 30] = " ";
            tembok[13, 31] = " ";
            tembok[13, 32] = " ";
            tembok[13, 33] = " ";
            tembok[13, 34] = "?";
            tembok[13, 35] = " ";
            tembok[13, 36] = " ";
            tembok[13, 37] = " ";
            tembok[13, 38] = "?";
            tembok[13, 39] = " ";
            tembok[13, 40] = "?";
            tembok[13, 41] = " ";
            tembok[13, 42] = "*";
            tembok[13, 43] = " ";
            tembok[13, 44] = "?";
            tembok[13, 45] = " ";
            tembok[13, 46] = "?";
            tembok[13, 47] = " ";
            tembok[13, 48] = "?";
            tembok[13, 49] = " ";
            tembok[13, 50] = "?";
            tembok[13, 51] = " ";
            tembok[13, 52] = "?";
            tembok[13, 53] = " ";
            tembok[13, 54] = "?";
            // BARIS KE 15
            tembok[14, 0] = " ";
            tembok[14, 1] = " ";
            tembok[14, 2] = " ";
            tembok[14, 3] = " ";
            tembok[14, 4] = " ";
            tembok[14, 5] = " ";
            tembok[14, 6] = " ";
            tembok[14, 7] = " ";
            tembok[14, 8] = " ";
            tembok[14, 9] = " ";
            tembok[14, 10] = " ";
            tembok[14, 11] = " ";
            tembok[14, 12] = "*";
            tembok[14, 13] = " ";
            tembok[14, 14] = " ";
            tembok[14, 15] = " ";
            tembok[14, 16] = " ";
            tembok[14, 17] = " ";
            tembok[14, 18] = " ";
            tembok[14, 19] = " ";
            tembok[14, 20] = "?";
            tembok[14, 21] = " ";
            tembok[14, 22] = " ";
            tembok[14, 23] = " ";
            tembok[14, 24] = " ";
            tembok[14, 25] = " ";
            tembok[14, 26] = " ";
            tembok[14, 27] = " ";
            tembok[14, 28] = " ";
            tembok[14, 29] = " ";
            tembok[14, 30] = " ";
            tembok[14, 31] = " ";
            tembok[14, 32] = " ";
            tembok[14, 33] = " ";
            tembok[14, 34] = "?";
            tembok[14, 35] = " ";
            tembok[14, 36] = " ";
            tembok[14, 37] = " ";
            tembok[14, 38] = " ";
            tembok[14, 39] = " ";
            tembok[14, 40] = " ";
            tembok[14, 41] = " ";
            tembok[14, 42] = "*";
            tembok[14, 43] = " ";
            tembok[14, 44] = " ";
            tembok[14, 45] = " ";
            tembok[14, 46] = " ";
            tembok[14, 47] = " ";
            tembok[14, 48] = " ";
            tembok[14, 49] = " ";
            tembok[14, 50] = " ";
            tembok[14, 51] = " ";
            tembok[14, 52] = " ";
            tembok[14, 53] = " ";
            tembok[14, 54] = " ";
            // BARIS KE 16
            tembok[15, 0] = "?";
            tembok[15, 1] = " ";
            tembok[15, 2] = "?";
            tembok[15, 3] = " ";
            tembok[15, 4] = "?";
            tembok[15, 5] = " ";
            tembok[15, 6] = "?";
            tembok[15, 7] = " ";
            tembok[15, 8] = "?";
            tembok[15, 9] = " ";
            tembok[15, 10] = "?";
            tembok[15, 11] = " ";
            tembok[15, 12] = "*";
            tembok[15, 13] = " ";
            tembok[15, 14] = "?";
            tembok[15, 15] = " ";
            tembok[15, 16] = "?";
            tembok[15, 17] = " ";
            tembok[15, 18] = " ";
            tembok[15, 19] = " ";
            tembok[15, 20] = "?";
            tembok[15, 21] = " ";
            tembok[15, 22] = " ";
            tembok[15, 23] = " ";
            tembok[15, 24] = " ";
            tembok[15, 25] = " ";
            tembok[15, 26] = " ";
            tembok[15, 27] = " ";
            tembok[15, 28] = " ";
            tembok[15, 29] = " ";
            tembok[15, 30] = " ";
            tembok[15, 31] = " ";
            tembok[15, 32] = " ";
            tembok[15, 33] = " ";
            tembok[15, 34] = "?";
            tembok[15, 35] = " ";
            tembok[15, 36] = " ";
            tembok[15, 37] = " ";
            tembok[15, 38] = "?";
            tembok[15, 39] = " ";
            tembok[15, 40] = "?";
            tembok[15, 41] = " ";
            tembok[15, 42] = "*";
            tembok[15, 43] = " ";
            tembok[15, 44] = "?";
            tembok[15, 45] = " ";
            tembok[15, 46] = "?";
            tembok[15, 47] = " ";
            tembok[15, 48] = "?";
            tembok[15, 49] = " ";
            tembok[15, 50] = "?";
            tembok[15, 51] = " ";
            tembok[15, 52] = "?";
            tembok[15, 53] = " ";
            tembok[15, 54] = "?";
            //BARIS KE 17
            tembok[16, 0] = " ";
            tembok[16, 1] = " ";
            tembok[16, 2] = " ";
            tembok[16, 3] = " ";
            tembok[16, 4] = " ";
            tembok[16, 5] = " ";
            tembok[16, 6] = " ";
            tembok[16, 7] = " ";
            tembok[16, 8] = " ";
            tembok[16, 9] = " ";
            tembok[16, 10] = "?";
            tembok[16, 11] = " ";
            tembok[16, 12] = "*";
            tembok[16, 13] = " ";
            tembok[16, 14] = "?";
            tembok[16, 15] = " ";
            tembok[16, 16] = "?";
            tembok[16, 17] = " ";
            tembok[16, 18] = " ";
            tembok[16, 19] = " ";
            tembok[16, 20] = "?";
            tembok[16, 21] = " ";
            tembok[16, 22] = "?";
            tembok[16, 23] = " ";
            tembok[16, 24] = "?";
            tembok[16, 25] = " ";
            tembok[16, 26] = "?";
            tembok[16, 27] = " ";
            tembok[16, 28] = "?";
            tembok[16, 29] = " ";
            tembok[16, 30] = "?";
            tembok[16, 31] = " ";
            tembok[16, 32] = "?";
            tembok[16, 33] = " ";
            tembok[16, 34] = "?";
            tembok[16, 35] = " ";
            tembok[16, 36] = " ";
            tembok[16, 37] = " ";
            tembok[16, 38] = "?";
            tembok[16, 39] = " ";
            tembok[16, 40] = "?";
            tembok[16, 41] = " ";
            tembok[16, 42] = "*";
            tembok[16, 43] = " ";
            tembok[16, 44] = "?";
            tembok[16, 45] = " ";
            tembok[16, 46] = " ";
            tembok[16, 47] = " ";
            tembok[16, 48] = " ";
            tembok[16, 49] = " ";
            tembok[16, 50] = " ";
            tembok[16, 51] = " ";
            tembok[16, 52] = " ";
            tembok[16, 53] = " ";
            tembok[16, 54] = " ";
            //BARIS KE 18
            tembok[17, 0] = " ";
            tembok[17, 1] = " ";
            tembok[17, 2] = " ";
            tembok[17, 3] = " ";
            tembok[17, 4] = " ";
            tembok[17, 5] = " ";
            tembok[17, 6] = " ";
            tembok[17, 7] = " ";
            tembok[17, 8] = " ";
            tembok[17, 9] = " ";
            tembok[17, 10] = "?";
            tembok[17, 11] = " ";
            tembok[17, 12] = "*";
            tembok[17, 13] = " ";
            tembok[17, 14] = "?";
            tembok[17, 15] = " ";
            tembok[17, 16] = "?";
            tembok[17, 17] = " ";
            tembok[17, 18] = " ";
            tembok[17, 19] = " ";
            tembok[17, 20] = " ";
            tembok[17, 21] = " ";
            tembok[17, 22] = " ";
            tembok[17, 23] = " ";
            tembok[17, 24] = " ";
            tembok[17, 25] = " ";
            tembok[17, 26] = " ";
            tembok[17, 27] = " ";
            tembok[17, 28] = " ";
            tembok[17, 29] = " ";
            tembok[17, 30] = " ";
            tembok[17, 31] = " ";
            tembok[17, 32] = " ";
            tembok[17, 33] = " ";
            tembok[17, 34] = " ";
            tembok[17, 35] = " ";
            tembok[17, 36] = " ";
            tembok[17, 37] = " ";
            tembok[17, 38] = "?";
            tembok[17, 39] = " ";
            tembok[17, 40] = "?";
            tembok[17, 41] = " ";
            tembok[17, 42] = "*";
            tembok[17, 43] = " ";
            tembok[17, 44] = "?";
            tembok[17, 45] = " ";
            tembok[17, 46] = " ";
            tembok[17, 47] = " ";
            tembok[17, 48] = " ";
            tembok[17, 49] = " ";
            tembok[17, 50] = " ";
            tembok[17, 51] = " ";
            tembok[17, 52] = " ";
            tembok[17, 53] = " ";
            tembok[17, 54] = " ";
            //BARIS KE 19
            tembok[18, 0] = " ";
            tembok[18, 1] = " ";
            tembok[18, 2] = " ";
            tembok[18, 3] = " ";
            tembok[18, 4] = " ";
            tembok[18, 5] = " ";
            tembok[18, 6] = " ";
            tembok[18, 7] = " ";
            tembok[18, 8] = " ";
            tembok[18, 9] = " ";
            tembok[18, 10] = "?";
            tembok[18, 11] = " ";
            tembok[18, 12] = "*";
            tembok[18, 13] = " ";
            tembok[18, 14] = "?";
            tembok[18, 15] = " ";
            tembok[18, 16] = "?";
            tembok[18, 17] = " ";
            tembok[18, 18] = " ";
            tembok[18, 19] = " ";
            tembok[18, 20] = "?";
            tembok[18, 21] = " ";
            tembok[18, 22] = "?";
            tembok[18, 23] = " ";
            tembok[18, 24] = "?";
            tembok[18, 25] = " ";
            tembok[18, 26] = "?";
            tembok[18, 27] = " ";
            tembok[18, 28] = "?";
            tembok[18, 29] = " ";
            tembok[18, 30] = "?";
            tembok[18, 31] = " ";
            tembok[18, 32] = "?";
            tembok[18, 33] = " ";
            tembok[18, 34] = "?";
            tembok[18, 35] = " ";
            tembok[18, 36] = " ";
            tembok[18, 37] = " ";
            tembok[18, 38] = "?";
            tembok[18, 39] = " ";
            tembok[18, 40] = "?";
            tembok[18, 41] = " ";
            tembok[18, 42] = "*";
            tembok[18, 43] = " ";
            tembok[18, 44] = "?";
            tembok[18, 45] = " ";
            tembok[18, 46] = " ";
            tembok[18, 47] = " ";
            tembok[18, 48] = " ";
            tembok[18, 49] = " ";
            tembok[18, 50] = " ";
            tembok[18, 51] = " ";
            tembok[18, 52] = " ";
            tembok[18, 53] = " ";
            tembok[18, 54] = " ";
            //BARIS KE 20
            tembok[19, 0] = "?";
            tembok[19, 1] = " ";
            tembok[19, 2] = "?";
            tembok[19, 3] = " ";
            tembok[19, 4] = "?";
            tembok[19, 5] = " ";
            tembok[19, 6] = "?";
            tembok[19, 7] = " ";
            tembok[19, 8] = "?";
            tembok[19, 9] = " ";
            tembok[19, 10] = "?";
            tembok[19, 11] = " ";
            tembok[19, 12] = "*";
            tembok[19, 13] = " ";
            tembok[19, 14] = "?";
            tembok[19, 15] = " ";
            tembok[19, 16] = "?";
            tembok[19, 17] = " ";
            tembok[19, 18] = " ";
            tembok[19, 19] = " ";
            tembok[19, 20] = "?";
            tembok[19, 21] = " ";
            tembok[19, 22] = "?";
            tembok[19, 23] = " ";
            tembok[19, 24] = "?";
            tembok[19, 25] = " ";
            tembok[19, 26] = "?";
            tembok[19, 27] = " ";
            tembok[19, 28] = "?";
            tembok[19, 29] = " ";
            tembok[19, 30] = "?";
            tembok[19, 31] = " ";
            tembok[19, 32] = "?";
            tembok[19, 33] = " ";
            tembok[19, 34] = "?";
            tembok[19, 35] = " ";
            tembok[19, 36] = " ";
            tembok[19, 37] = " ";
            tembok[19, 38] = "?";
            tembok[19, 39] = " ";
            tembok[19, 40] = "?";
            tembok[19, 41] = " ";
            tembok[19, 42] = "*";
            tembok[19, 43] = " ";
            tembok[19, 44] = "?";
            tembok[19, 45] = " ";
            tembok[19, 46] = "?";
            tembok[19, 47] = " ";
            tembok[19, 48] = "?";
            tembok[19, 49] = " ";
            tembok[19, 50] = "?";
            tembok[19, 51] = " ";
            tembok[19, 52] = "?";
            tembok[19, 53] = " ";
            tembok[19, 54] = "?";
            // BARIS KE 21
            tembok[20, 0] = "?";
            tembok[20, 1] = " ";
            tembok[20, 2] = "*";
            tembok[20, 3] = " ";
            tembok[20, 4] = "*";
            tembok[20, 5] = " ";
            tembok[20, 6] = "*";
            tembok[20, 7] = " ";
            tembok[20, 8] = "*";
            tembok[20, 9] = " ";
            tembok[20, 10] = "*";
            tembok[20, 11] = " ";
            tembok[20, 12] = "*";
            tembok[20, 13] = " ";
            tembok[20, 14] = "*";
            tembok[20, 15] = " ";
            tembok[20, 16] = "*";
            tembok[20, 17] = " ";
            tembok[20, 18] = "*";
            tembok[20, 19] = " ";
            tembok[20, 20] = "*";
            tembok[20, 21] = " ";
            tembok[20, 22] = "*";
            tembok[20, 23] = " ";
            tembok[20, 24] = "*";
            tembok[20, 25] = " ";
            tembok[20, 26] = "?";
            tembok[20, 27] = " ";
            tembok[20, 28] = "?";
            tembok[20, 29] = " ";
            tembok[20, 30] = "*";
            tembok[20, 31] = " ";
            tembok[20, 32] = "*";
            tembok[20, 33] = " ";
            tembok[20, 34] = "*";
            tembok[20, 35] = " ";
            tembok[20, 36] = "*";
            tembok[20, 37] = " ";
            tembok[20, 38] = "*";
            tembok[20, 39] = " ";
            tembok[20, 40] = "*";
            tembok[20, 41] = " ";
            tembok[20, 42] = "*";
            tembok[20, 43] = " ";
            tembok[20, 44] = "*";
            tembok[20, 45] = " ";
            tembok[20, 46] = "*";
            tembok[20, 47] = " ";
            tembok[20, 48] = "*";
            tembok[20, 49] = " ";
            tembok[20, 50] = "*";
            tembok[20, 51] = " ";
            tembok[20, 52] = "*";
            tembok[20, 53] = " ";
            tembok[20, 54] = "?";
            // BARIS KE 22
            tembok[21, 0] = "?";
            tembok[21, 1] = " ";
            tembok[21, 2] = "*";
            tembok[21, 3] = " ";
            tembok[21, 4] = "?";
            tembok[21, 5] = " ";
            tembok[21, 6] = "?";
            tembok[21, 7] = " ";
            tembok[21, 8] = "?";
            tembok[21, 9] = " ";
            tembok[21, 10] = "?";
            tembok[21, 11] = " ";
            tembok[21, 12] = "*";
            tembok[21, 13] = " ";
            tembok[21, 14] = "?";
            tembok[21, 15] = " ";
            tembok[21, 16] = "?";
            tembok[21, 17] = " ";
            tembok[21, 18] = "?";
            tembok[21, 19] = " ";
            tembok[21, 20] = "?";
            tembok[21, 21] = " ";
            tembok[21, 22] = "?";
            tembok[21, 23] = " ";
            tembok[21, 24] = "*";
            tembok[21, 25] = " ";
            tembok[21, 26] = "?";
            tembok[21, 27] = " ";
            tembok[21, 28] = "?";
            tembok[21, 29] = " ";
            tembok[21, 30] = "*";
            tembok[21, 31] = " ";
            tembok[21, 32] = "?";
            tembok[21, 33] = " ";
            tembok[21, 34] = "?";
            tembok[21, 35] = " ";
            tembok[21, 36] = "?";
            tembok[21, 37] = " ";
            tembok[21, 38] = "?";
            tembok[21, 39] = " ";
            tembok[21, 40] = "?";
            tembok[21, 41] = " ";
            tembok[21, 42] = "*";
            tembok[21, 43] = " ";
            tembok[21, 44] = "?";
            tembok[21, 45] = " ";
            tembok[21, 46] = "?";
            tembok[21, 47] = " ";
            tembok[21, 48] = "?";
            tembok[21, 49] = " ";
            tembok[21, 50] = "?";
            tembok[21, 51] = " ";
            tembok[21, 52] = "*";
            tembok[21, 53] = " ";
            tembok[21, 54] = "?";
            //BARIS KE 23
            tembok[22, 0] = "?";
            tembok[22, 1] = " ";
            tembok[22, 2] = "*";
            tembok[22, 3] = " ";
            tembok[22, 4] = "?";
            tembok[22, 5] = " ";
            tembok[22, 6] = "?";
            tembok[22, 7] = " ";
            tembok[22, 8] = "?";
            tembok[22, 9] = " ";
            tembok[22, 10] = "?";
            tembok[22, 11] = " ";
            tembok[22, 12] = "*";
            tembok[22, 13] = " ";
            tembok[22, 14] = "?";
            tembok[22, 15] = " ";
            tembok[22, 16] = "?";
            tembok[22, 17] = " ";
            tembok[22, 18] = "?";
            tembok[22, 19] = " ";
            tembok[22, 20] = "?";
            tembok[22, 21] = " ";
            tembok[22, 22] = "?";
            tembok[22, 23] = " ";
            tembok[22, 24] = "*";
            tembok[22, 25] = " ";
            tembok[22, 26] = "?";
            tembok[22, 27] = " ";
            tembok[22, 28] = "?";
            tembok[22, 29] = " ";
            tembok[22, 30] = "*";
            tembok[22, 31] = " ";
            tembok[22, 32] = "?";
            tembok[22, 33] = " ";
            tembok[22, 34] = "?";
            tembok[22, 35] = " ";
            tembok[22, 36] = "?";
            tembok[22, 37] = " ";
            tembok[22, 38] = "?";
            tembok[22, 39] = " ";
            tembok[22, 40] = "?";
            tembok[22, 41] = " ";
            tembok[22, 42] = "*";
            tembok[22, 43] = " ";
            tembok[22, 44] = "?";
            tembok[22, 45] = " ";
            tembok[22, 46] = "?";
            tembok[22, 47] = " ";
            tembok[22, 48] = "?";
            tembok[22, 49] = " ";
            tembok[22, 50] = "?";
            tembok[22, 51] = " ";
            tembok[22, 52] = "*";
            tembok[22, 53] = " ";
            tembok[22, 54] = "?";
            // BARIS KE 24
            tembok[23, 0] = "?";
            tembok[23, 1] = " ";
            tembok[23, 2] = "O";
            tembok[23, 3] = " ";
            tembok[23, 4] = "*";
            tembok[23, 5] = " ";
            tembok[23, 6] = "*";
            tembok[23, 7] = " ";
            tembok[23, 8] = "?";
            tembok[23, 9] = " ";
            tembok[23, 10] = "?";
            tembok[23, 11] = " ";
            tembok[23, 12] = "*";
            tembok[23, 13] = " ";
            tembok[23, 14] = "*";
            tembok[23, 15] = " ";
            tembok[23, 16] = "*";
            tembok[23, 17] = " ";
            tembok[23, 18] = "*";
            tembok[23, 19] = " ";
            tembok[23, 20] = "*";
            tembok[23, 21] = " ";
            tembok[23, 22] = "*";
            tembok[23, 23] = " ";
            tembok[23, 24] = "*";
            tembok[23, 25] = " ";
            tembok[23, 26] = "*";
            tembok[23, 27] = " ";
            tembok[23, 28] = "*";
            tembok[23, 29] = " ";
            tembok[23, 30] = "*";
            tembok[23, 31] = " ";
            tembok[23, 32] = "*";
            tembok[23, 33] = " ";
            tembok[23, 34] = "*";
            tembok[23, 35] = " ";
            tembok[23, 36] = "*";
            tembok[23, 37] = " ";
            tembok[23, 38] = "*";
            tembok[23, 39] = " ";
            tembok[23, 40] = "*";
            tembok[23, 41] = " ";
            tembok[23, 42] = "*";
            tembok[23, 43] = " ";
            tembok[23, 44] = "?";
            tembok[23, 45] = " ";
            tembok[23, 46] = "?";
            tembok[23, 47] = " ";
            tembok[23, 48] = "*";
            tembok[23, 49] = " ";
            tembok[23, 50] = "*";
            tembok[23, 51] = " ";
            tembok[23, 52] = "O";
            tembok[23, 53] = " ";
            tembok[23, 54] = "?";
            // BARIS KE 25
            tembok[24, 0] = "?";
            tembok[24, 1] = " ";
            tembok[24, 2] = "?";
            tembok[24, 3] = " ";
            tembok[24, 4] = "?";
            tembok[24, 5] = " ";
            tembok[24, 6] = "*";
            tembok[24, 7] = " ";
            tembok[24, 8] = "?";
            tembok[24, 9] = " ";
            tembok[24, 10] = "?";
            tembok[24, 11] = " ";
            tembok[24, 12] = "*";
            tembok[24, 13] = " ";
            tembok[24, 14] = "?";
            tembok[24, 15] = " ";
            tembok[24, 16] = "?";
            tembok[24, 17] = " ";
            tembok[24, 18] = "*";
            tembok[24, 19] = " ";
            tembok[24, 20] = "?";
            tembok[24, 21] = " ";
            tembok[24, 22] = "?";
            tembok[24, 23] = " ";
            tembok[24, 24] = "?";
            tembok[24, 25] = " ";
            tembok[24, 26] = "?";
            tembok[24, 27] = " ";
            tembok[24, 28] = "?";
            tembok[24, 29] = " ";
            tembok[24, 30] = "?";
            tembok[24, 31] = " ";
            tembok[24, 32] = "?";
            tembok[24, 33] = " ";
            tembok[24, 34] = "?";
            tembok[24, 35] = " ";
            tembok[24, 36] = "*";
            tembok[24, 37] = " ";
            tembok[24, 38] = "?";
            tembok[24, 39] = " ";
            tembok[24, 40] = "?";
            tembok[24, 41] = " ";
            tembok[24, 42] = "*";
            tembok[24, 43] = " ";
            tembok[24, 44] = "?";
            tembok[24, 45] = " ";
            tembok[24, 46] = "?";
            tembok[24, 47] = " ";
            tembok[24, 48] = "*";
            tembok[24, 49] = " ";
            tembok[24, 50] = "?";
            tembok[24, 51] = " ";
            tembok[24, 52] = "?";
            tembok[24, 53] = " ";
            tembok[24, 54] = "?";
            // BARIS KE 26
            tembok[25, 0] = "?";
            tembok[25, 1] = " ";
            tembok[25, 2] = "?";
            tembok[25, 3] = " ";
            tembok[25, 4] = "?";
            tembok[25, 5] = " ";
            tembok[25, 6] = "*";
            tembok[25, 7] = " ";
            tembok[25, 8] = "?";
            tembok[25, 9] = " ";
            tembok[25, 10] = "?";
            tembok[25, 11] = " ";
            tembok[25, 12] = "*";
            tembok[25, 13] = " ";
            tembok[25, 14] = "?";
            tembok[25, 15] = " ";
            tembok[25, 16] = "?";
            tembok[25, 17] = " ";
            tembok[25, 18] = "*";
            tembok[25, 19] = " ";
            tembok[25, 20] = "?";
            tembok[25, 21] = " ";
            tembok[25, 22] = "?";
            tembok[25, 23] = " ";
            tembok[25, 24] = "?";
            tembok[25, 25] = " ";
            tembok[25, 26] = "?";
            tembok[25, 27] = " ";
            tembok[25, 28] = "?";
            tembok[25, 29] = " ";
            tembok[25, 30] = "?";
            tembok[25, 31] = " ";
            tembok[25, 32] = "?";
            tembok[25, 33] = " ";
            tembok[25, 34] = "?";
            tembok[25, 35] = " ";
            tembok[25, 36] = "*";
            tembok[25, 37] = " ";
            tembok[25, 38] = "?";
            tembok[25, 39] = " ";
            tembok[25, 40] = "?";
            tembok[25, 41] = " ";
            tembok[25, 42] = "*";
            tembok[25, 43] = " ";
            tembok[25, 44] = "?";
            tembok[25, 45] = " ";
            tembok[25, 46] = "?";
            tembok[25, 47] = " ";
            tembok[25, 48] = "*";
            tembok[25, 49] = " ";
            tembok[25, 50] = "?";
            tembok[25, 51] = " ";
            tembok[25, 52] = "?";
            tembok[25, 53] = " ";
            tembok[25, 54] = "?";
            // BARIS KE 27
            tembok[26, 0] = "?";
            tembok[26, 1] = " ";
            tembok[26, 2] = "*";
            tembok[26, 3] = " ";
            tembok[26, 4] = "*";
            tembok[26, 5] = " ";
            tembok[26, 6] = "*";
            tembok[26, 7] = " ";
            tembok[26, 8] = "*";
            tembok[26, 9] = " ";
            tembok[26, 10] = "*";
            tembok[26, 11] = " ";
            tembok[26, 12] = "*";
            tembok[26, 13] = " ";
            tembok[26, 14] = "?";
            tembok[26, 15] = " ";
            tembok[26, 16] = "?";
            tembok[26, 17] = " ";
            tembok[26, 18] = "*";
            tembok[26, 19] = " ";
            tembok[26, 20] = "*";
            tembok[26, 21] = " ";
            tembok[26, 22] = "*";
            tembok[26, 23] = " ";
            tembok[26, 24] = "*";
            tembok[26, 25] = " ";
            tembok[26, 26] = "?";
            tembok[26, 27] = " ";
            tembok[26, 28] = "?";
            tembok[26, 29] = " ";
            tembok[26, 30] = "*";
            tembok[26, 31] = " ";
            tembok[26, 32] = "*";
            tembok[26, 33] = " ";
            tembok[26, 34] = "*";
            tembok[26, 35] = " ";
            tembok[26, 36] = "*";
            tembok[26, 37] = " ";
            tembok[26, 38] = "?";
            tembok[26, 39] = " ";
            tembok[26, 40] = "?";
            tembok[26, 41] = " ";
            tembok[26, 42] = "*";
            tembok[26, 43] = " ";
            tembok[26, 44] = "*";
            tembok[26, 45] = " ";
            tembok[26, 46] = "*";
            tembok[26, 47] = " ";
            tembok[26, 48] = "*";
            tembok[26, 49] = " ";
            tembok[26, 50] = "*";
            tembok[26, 51] = " ";
            tembok[26, 52] = "*";
            tembok[26, 53] = " ";
            tembok[26, 54] = "?";
            //BARIS KE 28
            tembok[27, 0] = "?";
            tembok[27, 1] = " ";
            tembok[27, 2] = "*";
            tembok[27, 3] = " ";
            tembok[27, 4] = "?";
            tembok[27, 5] = " ";
            tembok[27, 6] = "?";
            tembok[27, 7] = " ";
            tembok[27, 8] = "?";
            tembok[27, 9] = " ";
            tembok[27, 10] = "?";
            tembok[27, 11] = " ";
            tembok[27, 12] = "?";
            tembok[27, 13] = " ";
            tembok[27, 14] = "?";
            tembok[27, 15] = " ";
            tembok[27, 16] = "?";
            tembok[27, 17] = " ";
            tembok[27, 18] = "?";
            tembok[27, 19] = " ";
            tembok[27, 20] = "?";
            tembok[27, 21] = " ";
            tembok[27, 22] = "?";
            tembok[27, 23] = " ";
            tembok[27, 24] = "*";
            tembok[27, 25] = " ";
            tembok[27, 26] = "?";
            tembok[27, 27] = " ";
            tembok[27, 28] = "?";
            tembok[27, 29] = " ";
            tembok[27, 30] = "*";
            tembok[27, 31] = " ";
            tembok[27, 32] = "?";
            tembok[27, 33] = " ";
            tembok[27, 34] = "?";
            tembok[27, 35] = " ";
            tembok[27, 36] = "?";
            tembok[27, 37] = " ";
            tembok[27, 38] = "?";
            tembok[27, 39] = " ";
            tembok[27, 40] = "?";
            tembok[27, 41] = " ";
            tembok[27, 42] = "?";
            tembok[27, 43] = " ";
            tembok[27, 44] = "?";
            tembok[27, 45] = " ";
            tembok[27, 46] = "?";
            tembok[27, 47] = " ";
            tembok[27, 48] = "?";
            tembok[27, 49] = " ";
            tembok[27, 50] = "?";
            tembok[27, 51] = " ";
            tembok[27, 52] = "*";
            tembok[27, 53] = " ";
            tembok[27, 54] = "?";
            //BARIS KE 29
            tembok[28, 0] = "?";
            tembok[28, 1] = " ";
            tembok[28, 2] = "*";
            tembok[28, 3] = " ";
            tembok[28, 4] = "?";
            tembok[28, 5] = " ";
            tembok[28, 6] = "?";
            tembok[28, 7] = " ";
            tembok[28, 8] = "?";
            tembok[28, 9] = " ";
            tembok[28, 10] = "?";
            tembok[28, 11] = " ";
            tembok[28, 12] = "?";
            tembok[28, 13] = " ";
            tembok[28, 14] = "?";
            tembok[28, 15] = " ";
            tembok[28, 16] = "?";
            tembok[28, 17] = " ";
            tembok[28, 18] = "?";
            tembok[28, 19] = " ";
            tembok[28, 20] = "?";
            tembok[28, 21] = " ";
            tembok[28, 22] = "?";
            tembok[28, 23] = " ";
            tembok[28, 24] = "*";
            tembok[28, 25] = " ";
            tembok[28, 26] = "?";
            tembok[28, 27] = " ";
            tembok[28, 28] = "?";
            tembok[28, 29] = " ";
            tembok[28, 30] = "*";
            tembok[28, 31] = " ";
            tembok[28, 32] = "?";
            tembok[28, 33] = " ";
            tembok[28, 34] = "?";
            tembok[28, 35] = " ";
            tembok[28, 36] = "?";
            tembok[28, 37] = " ";
            tembok[28, 38] = "?";
            tembok[28, 39] = " ";
            tembok[28, 40] = "?";
            tembok[28, 41] = " ";
            tembok[28, 42] = "?";
            tembok[28, 43] = " ";
            tembok[28, 44] = "?";
            tembok[28, 45] = " ";
            tembok[28, 46] = "?";
            tembok[28, 47] = " ";
            tembok[28, 48] = "?";
            tembok[28, 49] = " ";
            tembok[28, 50] = "?";
            tembok[28, 51] = " ";
            tembok[28, 52] = "*";
            tembok[28, 53] = " ";
            tembok[28, 54] = "?";
            //BARIS KE 30
            tembok[29, 0] = "?";
            tembok[29, 1] = " ";
            tembok[29, 2] = "*";
            tembok[29, 3] = " ";
            tembok[29, 4] = "*";
            tembok[29, 5] = " ";
            tembok[29, 6] = "*";
            tembok[29, 7] = " ";
            tembok[29, 8] = "*";
            tembok[29, 9] = " ";
            tembok[29, 10] = "*";
            tembok[29, 11] = " ";
            tembok[29, 12] = "*";
            tembok[29, 13] = " ";
            tembok[29, 14] = "*";
            tembok[29, 15] = " ";
            tembok[29, 16] = "*";
            tembok[29, 17] = " ";
            tembok[29, 18] = "*";
            tembok[29, 19] = " ";
            tembok[29, 20] = "*";
            tembok[29, 21] = " ";
            tembok[29, 22] = "*";
            tembok[29, 23] = " ";
            tembok[29, 24] = "*";
            tembok[29, 25] = " ";
            tembok[29, 26] = "*";
            tembok[29, 27] = " ";
            tembok[29, 28] = "*";
            tembok[29, 29] = " ";
            tembok[29, 30] = "*";
            tembok[29, 31] = " ";
            tembok[29, 32] = "*";
            tembok[29, 33] = " ";
            tembok[29, 34] = "*";
            tembok[29, 35] = " ";
            tembok[29, 36] = "*";
            tembok[29, 37] = " ";
            tembok[29, 38] = "*";
            tembok[29, 39] = " ";
            tembok[29, 40] = "*";
            tembok[29, 41] = " ";
            tembok[29, 42] = "*";
            tembok[29, 43] = " ";
            tembok[29, 44] = "*";
            tembok[29, 45] = " ";
            tembok[29, 46] = "*";
            tembok[29, 47] = " ";
            tembok[29, 48] = "*";
            tembok[29, 49] = " ";
            tembok[29, 50] = "*";
            tembok[29, 51] = " ";
            tembok[29, 52] = "*";
            tembok[29, 53] = " ";
            tembok[29, 54] = "?";
            // BARIS KE 31
            tembok[30, 0] = "?";
            tembok[30, 1] = " ";
            tembok[30, 2] = "?";
            tembok[30, 3] = " ";
            tembok[30, 4] = "?";
            tembok[30, 5] = " ";
            tembok[30, 6] = "?";
            tembok[30, 7] = " ";
            tembok[30, 8] = "?";
            tembok[30, 9] = " ";
            tembok[30, 10] = "?";
            tembok[30, 11] = " ";
            tembok[30, 12] = "?";
            tembok[30, 13] = " ";
            tembok[30, 14] = "?";
            tembok[30, 15] = " ";
            tembok[30, 16] = "?";
            tembok[30, 17] = " ";
            tembok[30, 18] = "?";
            tembok[30, 19] = " ";
            tembok[30, 20] = "?";
            tembok[30, 21] = " ";
            tembok[30, 22] = "?";
            tembok[30, 23] = " ";
            tembok[30, 24] = "?";
            tembok[30, 25] = " ";
            tembok[30, 26] = "?";
            tembok[30, 27] = " ";
            tembok[30, 28] = "?";
            tembok[30, 29] = " ";
            tembok[30, 30] = "?";
            tembok[30, 31] = " ";
            tembok[30, 32] = "?";
            tembok[30, 33] = " ";
            tembok[30, 34] = "?";
            tembok[30, 35] = " ";
            tembok[30, 36] = "?";
            tembok[30, 37] = " ";
            tembok[30, 38] = "?";
            tembok[30, 39] = " ";
            tembok[30, 40] = "?";
            tembok[30, 41] = " ";
            tembok[30, 42] = "?";
            tembok[30, 43] = " ";
            tembok[30, 44] = "?";
            tembok[30, 45] = " ";
            tembok[30, 46] = "?";
            tembok[30, 47] = " ";
            tembok[30, 48] = "?";
            tembok[30, 49] = " ";
            tembok[30, 50] = "?";
            tembok[30, 51] = " ";
            tembok[30, 52] = "?";
            tembok[30, 53] = " ";
            tembok[30, 54] = "?";
        }
        Console.WriteLine("PILIH LEVEL 1 2 3");
        int pilihlevel = Convert.ToInt32(Console.ReadLine());
        if (pilihlevel == 1)
        {
            level = 200;
        }
        else if (pilihlevel == 2)
            level = 150;
        else if (pilihlevel == 3)
            level = 100;


        Console.Write("PRESS ANY KEY TO PLAY");
        //set posisi awal pacman
        bool apaSudahgerak = false;
        int posXpacman = 28;//28
        int posYpacman = 17;//17
        tembok[posYpacman, posXpacman] = "C";


        //set arah Ghost Merah: @
        string arahSetanMerah = "";
        string arahbalikSetanMerah = "";

        //set posisi awal Ghost Merah: @
        int posXghostmerah = 28;
        int posYghostmerah = 11;
        setan[posYghostmerah, posXghostmerah] = "@";
        int simpanPosXghostmerah = 0;
        int simpanPosYghostmerah = 0;
        string simpanArahghostmerah1 = "";
        string simpanArahghostmerah2 = "";

        //set arah Ghost Pink: #

        string arahSetanPink = "";
        string arahbalikSetanPink = "";

        //set posisi awal Ghost Pink: #

        int posXghostpink = 26;
        int posYghostpink = 14;

        // set arah Ghost Biru: $
        string arahSetanBiru = "";
        string arahbalikSetanBiru = "";

        //set posisi awal Ghost Biru: $
        int posXghostbiru = 24;
        int posYghostbiru = 14;

        //set arah Ghost Orange: %
        string arahSetanOrange = "";
        string arahbalikSetanOrange = "";

        //set posisi awal Ghost Orange: %
        int posXghostorange = 28;
        int posYghostorange = 14;

        //set waktu
        int waktu = 0;

        //set score
        int score = 0;

        //set arah pacman
        string arah = " ";
        string arahsebelum = " ";

        //Nyawa
        int live = 3;

        //count
        int count = 0;

        //arahrandomsetan
        int arahRandomSetanMerah = 0;
        int arahRandomSetanPink = 0;
        int arahRandomSetanBiru = 0;
        int arahRandomSetanOrange = 0;

        //bool reset posisi awal
        bool resetSetanMerah = false;
        bool resetSetanPink = false;
        bool resetSetanBiru = false;
        bool resetSetanOrange = false;

        //waktu makan O
        bool statuspacman = false;
        int waktuPowerUp = 100;//100

        //randomizer
        Random rand = new Random();
        do
        {
            //arah sebelum dan sesudah pacman dan para dajjal
            arahsebelum = arah;
            //cek tombol yang ditekan
            var key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.LeftArrow) { arah = "kiri"; apaSudahgerak = true; }
            else if (key.Key == ConsoleKey.RightArrow) { arah = "kanan"; apaSudahgerak = true; }
            else if (key.Key == ConsoleKey.UpArrow) { arah = "atas"; apaSudahgerak = true; }
            else if (key.Key == ConsoleKey.DownArrow) { arah = "bawah"; apaSudahgerak = true; }

            while (!Console.KeyAvailable)
            {
                if (apaSudahgerak == true)
                    waktu++;
                //---------------------GHOST MERAH --------------------//
                //Set arah Ghost Merah
                if(resetSetanMerah==true)
                {
                    if (posYghostmerah > 11 && posXghostmerah == 26)
                        posYghostmerah--;
                    else if (posYghostmerah == 11 && posXghostmerah > 24)
                    {
                        posXghostmerah -= 2;

                        if(posXghostmerah == 24)
                        {
                            resetSetanMerah = false;
                            arahSetanMerah = "kiri";
                        }
                    }
                }
                else if (apaSudahgerak == true && count != 2)
                {
                    if (posYghostmerah == 11 && posXghostmerah > 24)
                        posXghostmerah -= 2;//kiri
                    else if (posYghostmerah > 8 && posXghostmerah == 24)
                        posYghostmerah -= 1;//atas
                    else if (posYghostmerah == 8 && posXghostmerah > 18)
                        posXghostmerah -= 2;//kiri
                    else if (posYghostmerah > 5 && posXghostmerah == 18)
                        posYghostmerah -= 1;
                    else if (posYghostmerah == 5 && posXghostmerah < 52)
                        posXghostmerah += 2;
                    else if (posYghostmerah > 1 && posXghostmerah == 52)
                        posYghostmerah -= 1;
                    else if (posYghostmerah == 1 && posXghostmerah > 42)
                        posXghostmerah -= 2;
                    else if (posYghostmerah < 5 && posXghostmerah == 42)
                        posYghostmerah += 1;


                    if (posYghostmerah == 1 && posXghostmerah == 42)
                        count++;
                }
                //GhostMerah
                else if (count == 2 || score > 800)
                {

                    if (statusghostmerah == false)
                    {
                        //jika setan melihat pacman secara langsung
                        if (posXghostmerah == posXpacman && posYghostmerah > posYpacman && tembok[posYghostmerah - 1, posXghostmerah] != "?")
                        {
                            arahSetanMerah = "atas";
                            simpanArahghostmerah1 = "atas";
                            if (simpanPosYghostmerah == 0 && (tembok[posYpacman + 1, posXpacman] != "?" || tembok[posYpacman - 1, posXpacman] != "?"))
                            {
                                if (arah == "kiri" || arah == "kanan")
                                {
                                    simpanPosYghostmerah = posYpacman;
                                    simpanArahghostmerah2 = arah;
                                }
                            }
                        }

                        else if (posXghostmerah == posXpacman && posYghostmerah < posYpacman && tembok[posYghostmerah + 1, posXghostmerah] != "?")
                        {
                            arahSetanMerah = "bawah";
                            simpanArahghostmerah1 = "bawah";
                            if (simpanPosYghostmerah == 0 && (tembok[posYpacman + 1, posXpacman] != "?" || tembok[posYpacman - 1, posXpacman] != "?"))
                            {
                                if (arah == "kiri" || arah == "kanan")
                                {
                                    simpanPosYghostmerah = posYpacman;
                                    simpanArahghostmerah2 = arah;
                                }
                            }
                        }

                        else if (posXghostmerah < posXpacman && posYghostmerah == posYpacman && tembok[posYghostmerah, posXghostmerah + 2] != "?")
                        {
                            arahSetanMerah = "kanan";
                            simpanArahghostmerah1 = "kanan";
                            if (simpanPosYghostmerah == 0 && (tembok[posYpacman + 1, posXpacman] != "?" || tembok[posYpacman - 1, posXpacman] != "?"))
                            {
                                if (arah == "atas" || arah == "bawah")
                                {
                                    simpanPosXghostmerah = posXpacman;
                                    simpanArahghostmerah2 = arah;
                                }
                            }
                        }

                        else if (posXghostmerah > posXpacman && posYghostmerah == posYpacman && tembok[posYghostmerah, posXghostmerah - 2] != "?")
                        {
                            arahSetanMerah = "kiri";
                            simpanArahghostmerah1 = "kiri";
                            if (simpanPosYghostmerah == 0 && (tembok[posYpacman + 1, posXpacman] != "?" || tembok[posYpacman - 1, posXpacman] != "?"))
                            {
                                if (arah == "atas" || arah == "bawah")
                                {
                                    simpanPosXghostmerah = posXpacman;
                                    simpanArahghostmerah2 = arah;
                                }
                            }
                        }
                        //setan merah teleport
                        else if (posYghostmerah == 14 && posXghostmerah == 0)
                        {
                            setan[posYghostmerah, posXghostmerah] = "";
                            posXghostmerah = 54;
                            arahSetanMerah = "kiri";
                        }
                        else if (posYghostmerah == 14 && posXghostmerah == 54)
                        {
                            setan[posYghostmerah, posXghostmerah] = "";
                            posXghostmerah = 0;
                            arahSetanMerah = "kanan";
                        }


                        //random gerakan Ghost Merah di perempatan
                        else if (tembok[posYghostmerah, posXghostmerah - 2] != "?" && tembok[posYghostmerah, posXghostmerah + 2] != "?" && tembok[posYghostmerah + 1, posXghostmerah] != "?" && tembok[posYghostmerah - 1, posXghostmerah] != "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 5);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kanan";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "bawah";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 3)
                            {
                                arahSetanMerah = "kiri";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 4)
                            {
                                arahSetanMerah = "atas";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }

                        //random gerakan Ghost Merah di pertigaan (atas kanan bawah)
                        else if (tembok[posYghostmerah, posXghostmerah - 2] == "?" && tembok[posYghostmerah, posXghostmerah + 2] != "?" && tembok[posYghostmerah + 1, posXghostmerah] != "?" && tembok[posYghostmerah - 1, posXghostmerah] != "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 4);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kanan";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;

                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "bawah";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 3)
                            {
                                arahSetanMerah = "atas";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }
                        //random gerakan Ghost Merah di pertigaan (kanan bawah kiri)
                        else if (tembok[posYghostmerah, posXghostmerah - 2] != "?" && tembok[posYghostmerah, posXghostmerah + 2] != "?" && tembok[posYghostmerah + 1, posXghostmerah] != "?" && tembok[posYghostmerah - 1, posXghostmerah] == "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 4);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kanan";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;

                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "bawah";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 3)
                            {
                                arahSetanMerah = "kiri";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;

                            }

                        }
                        //random gerakan Ghost Merah di pertigaan (bawah kiri atas)
                        else if (tembok[posYghostmerah, posXghostmerah - 2] != "?" && tembok[posYghostmerah, posXghostmerah + 2] == "?" && tembok[posYghostmerah + 1, posXghostmerah] != "?" && tembok[posYghostmerah - 1, posXghostmerah] != "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 4);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kiri";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;

                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "bawah";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 3)
                            {
                                arahSetanMerah = "atas";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }

                        }
                        //random gerakan Ghost Merah di pertigaan (kiri atas kanan)
                        else if (tembok[posYghostmerah, posXghostmerah - 2] != "?" && tembok[posYghostmerah, posXghostmerah + 2] != "?" && tembok[posYghostmerah + 1, posXghostmerah] == "?" && tembok[posYghostmerah - 1, posXghostmerah] != "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 4);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kanan";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;

                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "kiri";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 3)
                            {
                                arahSetanMerah = "atas";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }
                        //arah ghost bila di perduaan atas kanan
                        else if (tembok[posYghostmerah, posXghostmerah - 2] == "?" && tembok[posYghostmerah, posXghostmerah + 2] != "?" && tembok[posYghostmerah + 1, posXghostmerah] == "?" && tembok[posYghostmerah - 1, posXghostmerah] != "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 3);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kanan";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "atas";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }
                        //arah ghost bila di perduaan kanan bawah
                        else if (tembok[posYghostmerah, posXghostmerah - 2] == "?" && tembok[posYghostmerah, posXghostmerah + 2] != "?" && tembok[posYghostmerah + 1, posXghostmerah] != "?" && tembok[posYghostmerah - 1, posXghostmerah] == "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 3);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kanan";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "bawah";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }
                        //arah ghost bila di perduaan bawah kiri
                        else if (tembok[posYghostmerah, posXghostmerah - 2] != "?" && tembok[posYghostmerah, posXghostmerah + 2] == "?" && tembok[posYghostmerah + 1, posXghostmerah] != "?" && tembok[posYghostmerah - 1, posXghostmerah] == "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 3);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "bawah";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "kiri";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }
                        //arah ghost bila di perduaan kiri atas
                        else if (tembok[posYghostmerah, posXghostmerah - 2] != "?" && tembok[posYghostmerah, posXghostmerah + 2] == "?" && tembok[posYghostmerah + 1, posXghostmerah] == "?" && tembok[posYghostmerah - 1, posXghostmerah] != "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 3);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kiri";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "atas";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }
                    }

                    else if (statusghostmerah == true)
                    {


                        //setan merah teleport
                        if (posYghostmerah == 14 && posXghostmerah == 0)
                        {
                            setan[posYghostmerah, posXghostmerah] = "";
                            posXghostmerah = 54;
                            arahSetanMerah = "kiri";
                        }
                        else if (posYghostmerah == 14 && posXghostmerah == 54)
                        {
                            setan[posYghostmerah, posXghostmerah] = "";
                            posXghostmerah = 0;
                            arahSetanMerah = "kanan";
                        }


                        //random gerakan Ghost Merah di perempatan
                        else if (tembok[posYghostmerah, posXghostmerah - 2] != "?" && tembok[posYghostmerah, posXghostmerah + 2] != "?" && tembok[posYghostmerah + 1, posXghostmerah] != "?" && tembok[posYghostmerah - 1, posXghostmerah] != "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 5);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kanan";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "bawah";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 3)
                            {
                                arahSetanMerah = "kiri";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 4)
                            {
                                arahSetanMerah = "atas";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }

                        //random gerakan Ghost Merah di pertigaan (atas kanan bawah)
                        else if (tembok[posYghostmerah, posXghostmerah - 2] == "?" && tembok[posYghostmerah, posXghostmerah + 2] != "?" && tembok[posYghostmerah + 1, posXghostmerah] != "?" && tembok[posYghostmerah - 1, posXghostmerah] != "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 4);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kanan";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;

                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "bawah";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 3)
                            {
                                arahSetanMerah = "atas";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }
                        //random gerakan Ghost Merah di pertigaan (kanan bawah kiri)
                        else if (tembok[posYghostmerah, posXghostmerah - 2] != "?" && tembok[posYghostmerah, posXghostmerah + 2] != "?" && tembok[posYghostmerah + 1, posXghostmerah] != "?" && tembok[posYghostmerah - 1, posXghostmerah] == "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 4);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kanan";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;

                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "bawah";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 3)
                            {
                                arahSetanMerah = "kiri";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;

                            }

                        }
                        //random gerakan Ghost Merah di pertigaan (bawah kiri atas)
                        else if (tembok[posYghostmerah, posXghostmerah - 2] != "?" && tembok[posYghostmerah, posXghostmerah + 2] == "?" && tembok[posYghostmerah + 1, posXghostmerah] != "?" && tembok[posYghostmerah - 1, posXghostmerah] != "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 4);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kiri";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;

                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "bawah";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 3)
                            {
                                arahSetanMerah = "atas";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }

                        }
                        //random gerakan Ghost Merah di pertigaan (kiri atas kanan)
                        else if (tembok[posYghostmerah, posXghostmerah - 2] != "?" && tembok[posYghostmerah, posXghostmerah + 2] != "?" && tembok[posYghostmerah + 1, posXghostmerah] == "?" && tembok[posYghostmerah - 1, posXghostmerah] != "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 4);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kanan";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;

                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "kiri";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 3)
                            {
                                arahSetanMerah = "atas";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }
                        //arah ghost bila di perduaan atas kanan
                        else if (tembok[posYghostmerah, posXghostmerah - 2] == "?" && tembok[posYghostmerah, posXghostmerah + 2] != "?" && tembok[posYghostmerah + 1, posXghostmerah] == "?" && tembok[posYghostmerah - 1, posXghostmerah] != "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 3);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kanan";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "atas";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }
                        //arah ghost bila di perduaan kanan bawah
                        else if (tembok[posYghostmerah, posXghostmerah - 2] == "?" && tembok[posYghostmerah, posXghostmerah + 2] != "?" && tembok[posYghostmerah + 1, posXghostmerah] != "?" && tembok[posYghostmerah - 1, posXghostmerah] == "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 3);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kanan";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "bawah";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }
                        //arah ghost bila di perduaan bawah kiri
                        else if (tembok[posYghostmerah, posXghostmerah - 2] != "?" && tembok[posYghostmerah, posXghostmerah + 2] == "?" && tembok[posYghostmerah + 1, posXghostmerah] != "?" && tembok[posYghostmerah - 1, posXghostmerah] == "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 3);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "bawah";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "kiri";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }
                        //arah ghost bila di perduaan kiri atas
                        else if (tembok[posYghostmerah, posXghostmerah - 2] != "?" && tembok[posYghostmerah, posXghostmerah + 2] == "?" && tembok[posYghostmerah + 1, posXghostmerah] == "?" && tembok[posYghostmerah - 1, posXghostmerah] != "?")
                        {
                        randomlagi:
                            arahRandomSetanMerah = rand.Next(1, 3);
                            if (arahRandomSetanMerah == 1)
                            {
                                arahSetanMerah = "kiri";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                            else if (arahRandomSetanMerah == 2)
                            {
                                arahSetanMerah = "atas";
                                if (arahSetanMerah == arahbalikSetanMerah)
                                    goto randomlagi;
                            }
                        }

                    }



                    //gerakan Setan Merah
                    if (arahSetanMerah == "bawah")
                    {
                        posYghostmerah += 1;
                        arahbalikSetanMerah = "atas";
                    }
                    else if (arahSetanMerah == "atas")
                    {
                        posYghostmerah -= 1;
                        arahbalikSetanMerah = "bawah";
                    }
                    else if (arahSetanMerah == "kiri")
                    {
                        posXghostmerah -= 2;
                        arahbalikSetanMerah = "kanan";
                    }
                    else if (arahSetanMerah == "kanan")
                    {
                        posXghostmerah += 2;
                        arahbalikSetanMerah = "kiri";
                    }
                }

                //---------------------GHOST PINK --------------------//
                if (waktu > 60)
                {
                    if(resetSetanPink==true)
                    {
                        if (posYghostpink > 11 && posXghostpink == 26)
                            posYghostpink -= 1;
                        else if (posYghostpink == 11 && posXghostpink > 24)
                        {
                            posXghostpink -= 2;
                            resetSetanPink = false;
                        }
                    }

                    else if (waktu < 65)
                    {
                        if (posYghostpink > 11 && posXghostpink == 26)
                            posYghostpink -= 1;
                        else if (posYghostpink == 11 && posXghostpink > 24)
                        {
                            posXghostpink -= 2;
                            resetSetanPink = false;
                        }
                            
                    }
                    else
                    {
                        if (statusghostpink == false)
                        {
                            //jika setan melihat pacman secara langsung
                            if (posXghostpink == posXpacman && posYghostpink > posYpacman && tembok[posYghostpink - 1, posXghostpink] != "?")
                            {
                                arahSetanPink = "atas";
                            }

                            else if (posXghostpink == posXpacman && posYghostpink < posYpacman && tembok[posYghostpink + 1, posXghostpink] != "?")
                            {
                                arahSetanPink = "bawah";
                            }

                            else if (posXghostpink < posXpacman && posYghostpink == posYpacman && tembok[posYghostpink, posXghostpink + 2] != "?")
                            {
                                arahSetanPink = "kanan";
                            }

                            else if (posXghostpink > posXpacman && posYghostpink == posYpacman && tembok[posYghostpink, posXghostpink - 2] != "?")
                            {
                                arahSetanPink = "kiri";
                            }
                            //setan pink teleport
                            else if (posYghostpink == 14 && posXghostpink == 0)
                            {
                                setan[posYghostpink, posXghostpink] = "";
                                posXghostpink = 54;
                                arahSetanPink = "kiri";
                            }
                            else if (posYghostpink == 14 && posXghostpink == 54)
                            {
                                setan[posYghostpink, posXghostpink] = "";
                                posXghostpink = 0;
                                arahSetanPink = "kanan";
                            }

                            //random gerakan Ghost pink di perempatan
                            else if (tembok[posYghostpink, posXghostpink - 2] != "?" && tembok[posYghostpink, posXghostpink + 2] != "?" && tembok[posYghostpink + 1, posXghostpink] != "?" && tembok[posYghostpink - 1, posXghostpink] != "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 5);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kanan";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "bawah";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 3)
                                {
                                    arahSetanPink = "kiri";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 4)
                                {
                                    arahSetanPink = "atas";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }

                            //random gerakan Ghost pink di pertigaan (atas kanan bawah)
                            else if (tembok[posYghostpink, posXghostpink - 2] == "?" && tembok[posYghostpink, posXghostpink + 2] != "?" && tembok[posYghostpink + 1, posXghostpink] != "?" && tembok[posYghostpink - 1, posXghostpink] != "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 4);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kanan";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "bawah";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 3)
                                {
                                    arahSetanPink = "atas";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }
                            //random gerakan Ghost pink di pertigaan (kanan bawah kiri)
                            else if (tembok[posYghostpink, posXghostpink - 2] != "?" && tembok[posYghostpink, posXghostpink + 2] != "?" && tembok[posYghostpink + 1, posXghostpink] != "?" && tembok[posYghostpink - 1, posXghostpink] == "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 4);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kanan";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "bawah";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 3)
                                {
                                    arahSetanPink = "kiri";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;

                                }

                            }
                            //random gerakan Ghost pink di pertigaan (bawah kiri atas)
                            else if (tembok[posYghostpink, posXghostpink - 2] != "?" && tembok[posYghostpink, posXghostpink + 2] == "?" && tembok[posYghostpink + 1, posXghostpink] != "?" && tembok[posYghostpink - 1, posXghostpink] != "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 4);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kiri";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "bawah";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 3)
                                {
                                    arahSetanPink = "atas";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }

                            }
                            //random gerakan Ghost pink di pertigaan (kiri atas kanan)
                            else if (tembok[posYghostpink, posXghostpink - 2] != "?" && tembok[posYghostpink, posXghostpink + 2] != "?" && tembok[posYghostpink + 1, posXghostpink] == "?" && tembok[posYghostpink - 1, posXghostpink] != "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 4);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kanan";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "kiri";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 3)
                                {
                                    arahSetanPink = "atas";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan atas kanan
                            else if (tembok[posYghostpink, posXghostpink - 2] == "?" && tembok[posYghostpink, posXghostpink + 2] != "?" && tembok[posYghostpink + 1, posXghostpink] == "?" && tembok[posYghostpink - 1, posXghostpink] != "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 3);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kanan";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "atas";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan kanan bawah
                            else if (tembok[posYghostpink, posXghostpink - 2] == "?" && tembok[posYghostpink, posXghostpink + 2] != "?" && tembok[posYghostpink + 1, posXghostpink] != "?" && tembok[posYghostpink - 1, posXghostpink] == "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 3);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kanan";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "bawah";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan bawah kiri
                            else if (tembok[posYghostpink, posXghostpink - 2] != "?" && tembok[posYghostpink, posXghostpink + 2] == "?" && tembok[posYghostpink + 1, posXghostpink] != "?" && tembok[posYghostpink - 1, posXghostpink] == "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 3);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "bawah";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "kiri";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan kiri atas
                            else if (tembok[posYghostpink, posXghostpink - 2] != "?" && tembok[posYghostpink, posXghostpink + 2] == "?" && tembok[posYghostpink + 1, posXghostpink] == "?" && tembok[posYghostpink - 1, posXghostpink] != "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 3);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kiri";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "atas";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }
                        }

                        else if (statusghostpink == true)
                        {
                            //setan pink teleport
                            if (posYghostpink == 14 && posXghostpink == 0)
                            {
                                setan[posYghostpink, posXghostpink] = "";
                                posXghostpink = 54;
                                arahSetanPink = "kiri";
                            }
                            else if (posYghostpink == 14 && posXghostpink == 54)
                            {
                                setan[posYghostpink, posXghostpink] = "";
                                posXghostpink = 0;
                                arahSetanPink = "kanan";
                            }
                            //random gerakan Ghost pink di perempatan
                            else if (tembok[posYghostpink, posXghostpink - 2] != "?" && tembok[posYghostpink, posXghostpink + 2] != "?" && tembok[posYghostpink + 1, posXghostpink] != "?" && tembok[posYghostpink - 1, posXghostpink] != "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 5);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kanan";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "bawah";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 3)
                                {
                                    arahSetanPink = "kiri";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 4)
                                {
                                    arahSetanPink = "atas";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }

                            //random gerakan Ghost pink di pertigaan (atas kanan bawah)
                            else if (tembok[posYghostpink, posXghostpink - 2] == "?" && tembok[posYghostpink, posXghostpink + 2] != "?" && tembok[posYghostpink + 1, posXghostpink] != "?" && tembok[posYghostpink - 1, posXghostpink] != "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 4);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kanan";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "bawah";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 3)
                                {
                                    arahSetanPink = "atas";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }
                            //random gerakan Ghost pink di pertigaan (kanan bawah kiri)
                            else if (tembok[posYghostpink, posXghostpink - 2] != "?" && tembok[posYghostpink, posXghostpink + 2] != "?" && tembok[posYghostpink + 1, posXghostpink] != "?" && tembok[posYghostpink - 1, posXghostpink] == "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 4);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kanan";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "bawah";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 3)
                                {
                                    arahSetanPink = "kiri";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;

                                }

                            }
                            //random gerakan Ghost pink di pertigaan (bawah kiri atas)
                            else if (tembok[posYghostpink, posXghostpink - 2] != "?" && tembok[posYghostpink, posXghostpink + 2] == "?" && tembok[posYghostpink + 1, posXghostpink] != "?" && tembok[posYghostpink - 1, posXghostpink] != "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 4);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kiri";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "bawah";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 3)
                                {
                                    arahSetanPink = "atas";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }

                            }
                            //random gerakan Ghost pink di pertigaan (kiri atas kanan)
                            else if (tembok[posYghostpink, posXghostpink - 2] != "?" && tembok[posYghostpink, posXghostpink + 2] != "?" && tembok[posYghostpink + 1, posXghostpink] == "?" && tembok[posYghostpink - 1, posXghostpink] != "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 4);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kanan";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "kiri";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 3)
                                {
                                    arahSetanPink = "atas";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan atas kanan
                            else if (tembok[posYghostpink, posXghostpink - 2] == "?" && tembok[posYghostpink, posXghostpink + 2] != "?" && tembok[posYghostpink + 1, posXghostpink] == "?" && tembok[posYghostpink - 1, posXghostpink] != "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 3);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kanan";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "atas";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan kanan bawah
                            else if (tembok[posYghostpink, posXghostpink - 2] == "?" && tembok[posYghostpink, posXghostpink + 2] != "?" && tembok[posYghostpink + 1, posXghostpink] != "?" && tembok[posYghostpink - 1, posXghostpink] == "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 3);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kanan";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "bawah";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan bawah kiri
                            else if (tembok[posYghostpink, posXghostpink - 2] != "?" && tembok[posYghostpink, posXghostpink + 2] == "?" && tembok[posYghostpink + 1, posXghostpink] != "?" && tembok[posYghostpink - 1, posXghostpink] == "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 3);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "bawah";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "kiri";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan kiri atas
                            else if (tembok[posYghostpink, posXghostpink - 2] != "?" && tembok[posYghostpink, posXghostpink + 2] == "?" && tembok[posYghostpink + 1, posXghostpink] == "?" && tembok[posYghostpink - 1, posXghostpink] != "?")
                            {
                            randomlagi:
                                arahRandomSetanPink = rand.Next(1, 3);
                                if (arahRandomSetanPink == 1)
                                {
                                    arahSetanPink = "kiri";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanPink == 2)
                                {
                                    arahSetanPink = "atas";
                                    if (arahSetanPink == arahbalikSetanPink)
                                        goto randomlagi;
                                }
                            }



                        }


                    }

                    //gerakan Setan Pink
                    if (arahSetanPink == "bawah")
                    {
                        posYghostpink += 1;
                        arahbalikSetanPink = "atas";
                    }
                    else if (arahSetanPink == "atas")
                    {
                        posYghostpink -= 1;
                        arahbalikSetanPink = "bawah";
                    }
                    else if (arahSetanPink == "kiri")
                    {
                        posXghostpink -= 2;
                        arahbalikSetanPink = "kanan";
                    }
                    else if (arahSetanPink == "kanan")
                    {
                        posXghostpink += 2;
                        arahbalikSetanPink = "kiri";
                    }
                }
                //---------------------GHOST BIRU --------------------//
                if (waktu > 100)
                {
                    if(resetSetanBiru == true)
                    {
                        if (posYghostbiru == 14 && posXghostbiru < 26)
                            posXghostbiru += 2;
                        else if (posYghostbiru > 11 && posXghostbiru == 26)
                            posYghostbiru -= 1;
                        else if (posYghostbiru == 11 && posXghostbiru > 24)
                        {
                            posXghostbiru -= 2;
                            resetSetanBiru = false;
                            arahSetanBiru = "kiri";
                        }
                    }
                    else if (waktu < 110)
                    {
                        if (posYghostbiru == 14 && posXghostbiru < 26)
                            posXghostbiru += 2;
                        else if (posYghostbiru > 11 && posXghostbiru == 26)
                            posYghostbiru -= 1;
                        else if (posYghostbiru == 11 && posXghostbiru > 24)
                        {
                            posXghostbiru -= 2;
                            resetSetanBiru = false;
                        }    
                    }
                    else
                    {
                        if (statusghostbiru == false)
                        {
                            //jika setan melihat pacman secara langsung
                            if (posXghostbiru == posXpacman && posYghostbiru > posYpacman && tembok[posYghostbiru - 1, posXghostbiru] != "?")
                            {
                                arahSetanBiru = "atas";
                            }

                            else if (posXghostbiru == posXpacman && posYghostbiru < posYpacman && tembok[posYghostbiru + 1, posXghostbiru] != "?")
                            {
                                arahSetanBiru = "bawah";
                            }

                            else if (posXghostbiru < posXpacman && posYghostbiru == posYpacman && tembok[posYghostbiru, posXghostbiru + 2] != "?")
                            {
                                arahSetanBiru = "kanan";
                            }

                            else if (posXghostbiru > posXpacman && posYghostbiru == posYpacman && tembok[posYghostbiru, posXghostbiru - 2] != "?")
                            {
                                arahSetanBiru = "kiri";
                            }
                            //setan biru teleport
                            else if (posYghostbiru == 14 && posXghostbiru == 0)
                            {
                                setan[posYghostbiru, posXghostbiru] = "";
                                posXghostbiru = 54;
                                arahSetanBiru = "kiri";
                            }
                            else if (posYghostbiru == 14 && posXghostbiru == 54)
                            {
                                setan[posYghostbiru, posXghostbiru] = "";
                                posXghostbiru = 0;
                                arahSetanBiru = "kanan";
                            }

                            //random gerakan Ghost biru di perempatan
                            else if (tembok[posYghostbiru, posXghostbiru - 2] != "?" && tembok[posYghostbiru, posXghostbiru + 2] != "?" && tembok[posYghostbiru + 1, posXghostbiru] != "?" && tembok[posYghostbiru - 1, posXghostbiru] != "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 5);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kanan";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "bawah";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 3)
                                {
                                    arahSetanBiru = "kiri";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 4)
                                {
                                    arahSetanBiru = "atas";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }

                            //random gerakan Ghost biru di pertigaan (atas kanan bawah)
                            else if (tembok[posYghostbiru, posXghostbiru - 2] == "?" && tembok[posYghostbiru, posXghostbiru + 2] != "?" && tembok[posYghostbiru + 1, posXghostbiru] != "?" && tembok[posYghostbiru - 1, posXghostbiru] != "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 4);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kanan";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "bawah";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 3)
                                {
                                    arahSetanBiru = "atas";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }
                            //random gerakan Ghost biru di pertigaan (kanan bawah kiri)
                            else if (tembok[posYghostbiru, posXghostbiru - 2] != "?" && tembok[posYghostbiru, posXghostbiru + 2] != "?" && tembok[posYghostbiru + 1, posXghostbiru] != "?" && tembok[posYghostbiru - 1, posXghostbiru] == "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 4);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kanan";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "bawah";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 3)
                                {
                                    arahSetanBiru = "kiri";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;

                                }

                            }
                            //random gerakan Ghost biru di pertigaan (bawah kiri atas)
                            else if (tembok[posYghostbiru, posXghostbiru - 2] != "?" && tembok[posYghostbiru, posXghostbiru + 2] == "?" && tembok[posYghostbiru + 1, posXghostbiru] != "?" && tembok[posYghostbiru - 1, posXghostbiru] != "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 4);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kiri";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "bawah";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 3)
                                {
                                    arahSetanBiru = "atas";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }

                            }
                            //random gerakan Ghost biru di pertigaan (kiri atas kanan)
                            else if (tembok[posYghostbiru, posXghostbiru - 2] != "?" && tembok[posYghostbiru, posXghostbiru + 2] != "?" && tembok[posYghostbiru + 1, posXghostbiru] == "?" && tembok[posYghostbiru - 1, posXghostbiru] != "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 4);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kanan";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "kiri";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 3)
                                {
                                    arahSetanBiru = "atas";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan atas kanan
                            else if (tembok[posYghostbiru, posXghostbiru - 2] == "?" && tembok[posYghostbiru, posXghostbiru + 2] != "?" && tembok[posYghostbiru + 1, posXghostbiru] == "?" && tembok[posYghostbiru - 1, posXghostbiru] != "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 3);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kanan";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "atas";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan kanan bawah
                            else if (tembok[posYghostbiru, posXghostbiru - 2] == "?" && tembok[posYghostbiru, posXghostbiru + 2] != "?" && tembok[posYghostbiru + 1, posXghostbiru] != "?" && tembok[posYghostbiru - 1, posXghostbiru] == "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 3);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kanan";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "bawah";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan bawah kiri
                            else if (tembok[posYghostbiru, posXghostbiru - 2] != "?" && tembok[posYghostbiru, posXghostbiru + 2] == "?" && tembok[posYghostbiru + 1, posXghostbiru] != "?" && tembok[posYghostbiru - 1, posXghostbiru] == "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 3);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "bawah";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "kiri";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan kiri atas
                            else if (tembok[posYghostbiru, posXghostbiru - 2] != "?" && tembok[posYghostbiru, posXghostbiru + 2] == "?" && tembok[posYghostbiru + 1, posXghostbiru] == "?" && tembok[posYghostbiru - 1, posXghostbiru] != "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 3);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kiri";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "atas";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }

                        }
                        else if (statusghostbiru == true)
                        {
                            //setan biru teleport
                            if (posYghostbiru == 14 && posXghostbiru == 0)
                            {
                                setan[posYghostbiru, posXghostbiru] = "";
                                posXghostbiru = 54;
                                arahSetanBiru = "kiri";
                            }
                            else if (posYghostbiru == 14 && posXghostbiru == 54)
                            {
                                setan[posYghostbiru, posXghostbiru] = "";
                                posXghostbiru = 0;
                                arahSetanBiru = "kanan";
                            }

                            //random gerakan Ghost biru di perempatan
                            else if (tembok[posYghostbiru, posXghostbiru - 2] != "?" && tembok[posYghostbiru, posXghostbiru + 2] != "?" && tembok[posYghostbiru + 1, posXghostbiru] != "?" && tembok[posYghostbiru - 1, posXghostbiru] != "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 5);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kanan";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "bawah";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 3)
                                {
                                    arahSetanBiru = "kiri";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 4)
                                {
                                    arahSetanBiru = "atas";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }

                            //random gerakan Ghost biru di pertigaan (atas kanan bawah)
                            else if (tembok[posYghostbiru, posXghostbiru - 2] == "?" && tembok[posYghostbiru, posXghostbiru + 2] != "?" && tembok[posYghostbiru + 1, posXghostbiru] != "?" && tembok[posYghostbiru - 1, posXghostbiru] != "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 4);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kanan";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "bawah";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 3)
                                {
                                    arahSetanBiru = "atas";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }
                            //random gerakan Ghost biru di pertigaan (kanan bawah kiri)
                            else if (tembok[posYghostbiru, posXghostbiru - 2] != "?" && tembok[posYghostbiru, posXghostbiru + 2] != "?" && tembok[posYghostbiru + 1, posXghostbiru] != "?" && tembok[posYghostbiru - 1, posXghostbiru] == "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 4);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kanan";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "bawah";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 3)
                                {
                                    arahSetanBiru = "kiri";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;

                                }

                            }
                            //random gerakan Ghost biru di pertigaan (bawah kiri atas)
                            else if (tembok[posYghostbiru, posXghostbiru - 2] != "?" && tembok[posYghostbiru, posXghostbiru + 2] == "?" && tembok[posYghostbiru + 1, posXghostbiru] != "?" && tembok[posYghostbiru - 1, posXghostbiru] != "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 4);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kiri";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "bawah";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 3)
                                {
                                    arahSetanBiru = "atas";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }

                            }
                            //random gerakan Ghost biru di pertigaan (kiri atas kanan)
                            else if (tembok[posYghostbiru, posXghostbiru - 2] != "?" && tembok[posYghostbiru, posXghostbiru + 2] != "?" && tembok[posYghostbiru + 1, posXghostbiru] == "?" && tembok[posYghostbiru - 1, posXghostbiru] != "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 4);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kanan";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "kiri";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 3)
                                {
                                    arahSetanBiru = "atas";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan atas kanan
                            else if (tembok[posYghostbiru, posXghostbiru - 2] == "?" && tembok[posYghostbiru, posXghostbiru + 2] != "?" && tembok[posYghostbiru + 1, posXghostbiru] == "?" && tembok[posYghostbiru - 1, posXghostbiru] != "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 3);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kanan";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "atas";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan kanan bawah
                            else if (tembok[posYghostbiru, posXghostbiru - 2] == "?" && tembok[posYghostbiru, posXghostbiru + 2] != "?" && tembok[posYghostbiru + 1, posXghostbiru] != "?" && tembok[posYghostbiru - 1, posXghostbiru] == "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 3);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kanan";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "bawah";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan bawah kiri
                            else if (tembok[posYghostbiru, posXghostbiru - 2] != "?" && tembok[posYghostbiru, posXghostbiru + 2] == "?" && tembok[posYghostbiru + 1, posXghostbiru] != "?" && tembok[posYghostbiru - 1, posXghostbiru] == "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 3);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "bawah";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "kiri";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan kiri atas
                            else if (tembok[posYghostbiru, posXghostbiru - 2] != "?" && tembok[posYghostbiru, posXghostbiru + 2] == "?" && tembok[posYghostbiru + 1, posXghostbiru] == "?" && tembok[posYghostbiru - 1, posXghostbiru] != "?")
                            {
                            randomlagi:
                                arahRandomSetanBiru = rand.Next(1, 3);
                                if (arahRandomSetanBiru == 1)
                                {
                                    arahSetanBiru = "kiri";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanBiru == 2)
                                {
                                    arahSetanBiru = "atas";
                                    if (arahSetanBiru == arahbalikSetanBiru)
                                        goto randomlagi;
                                }
                            }

                        }
                    }
                    //gerakan Setan biru
                    if (arahSetanBiru == "bawah")
                    {
                        posYghostbiru += 1;
                        arahbalikSetanBiru = "atas";
                    }
                    else if (arahSetanBiru == "atas")
                    {
                        posYghostbiru -= 1;
                        arahbalikSetanBiru = "bawah";
                    }
                    else if (arahSetanBiru == "kiri")
                    {
                        posXghostbiru -= 2;
                        arahbalikSetanBiru = "kanan";
                    }
                    else if (arahSetanBiru == "kanan")
                    {
                        posXghostbiru += 2;
                        arahbalikSetanBiru = "kiri";
                    }
                }
                //---------------------GHOST ORANGE --------------------//
                if (waktu > 150)
                {
                    if(resetSetanOrange == true)
                    {
                        if (posYghostorange > 11 && posXghostorange == 28)
                            posYghostorange -= 1;
                        else if (posYghostorange == 11 && posXghostorange > 24)
                        {
                            posXghostorange -= 2;
                            resetSetanOrange = false;
                            arahSetanOrange = "kiri";
                        }
                    }
                    else if (waktu < 156)
                    {
                        if (posYghostorange > 11 && posXghostorange == 28)
                            posYghostorange -= 1;
                        else if (posYghostorange == 11 && posXghostorange > 24)
                        {
                            posXghostorange -= 2;
                            resetSetanOrange = false;
                        }
                            
                    }
                    else
                    {
                        if (statusghostorange == false)
                        {
                            //jika setan melihat pacman secara langsung
                            if (posXghostorange == posXpacman && posYghostorange > posYpacman && tembok[posYghostorange - 1, posXghostorange] != "?")
                            {
                                arahSetanOrange = "atas";
                            }

                            else if (posXghostorange == posXpacman && posYghostorange < posYpacman && tembok[posYghostorange + 1, posXghostorange] != "?")
                            {
                                arahSetanOrange = "bawah";
                            }

                            else if (posXghostorange < posXpacman && posYghostorange == posYpacman && tembok[posYghostorange, posXghostorange + 2] != "?")
                            {
                                arahSetanOrange = "kanan";
                            }

                            else if (posXghostorange > posXpacman && posYghostorange == posYpacman && tembok[posYghostorange, posXghostorange - 2] != "?")
                            {
                                arahSetanOrange = "kiri";
                            }
                            //setan Orange teleport
                            else if (posYghostorange == 14 && posXghostorange == 0)
                            {
                                setan[posYghostorange, posXghostorange] = "";
                                posXghostorange = 54;
                                arahSetanOrange = "kiri";
                            }
                            else if (posYghostorange == 14 && posXghostorange == 54)
                            {
                                setan[posYghostorange, posXghostorange] = "";
                                posXghostorange = 0;
                                arahSetanOrange = "kanan";
                            }

                            //random gerakan Ghost Orange di perempatan
                            else if (tembok[posYghostorange, posXghostorange - 2] != "?" && tembok[posYghostorange, posXghostorange + 2] != "?" && tembok[posYghostorange + 1, posXghostorange] != "?" && tembok[posYghostorange - 1, posXghostorange] != "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 5);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kanan";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "bawah";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 3)
                                {
                                    arahSetanOrange = "kiri";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 4)
                                {
                                    arahSetanOrange = "atas";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }

                            //random gerakan Ghost Orange di pertigaan (atas kanan bawah)
                            else if (tembok[posYghostorange, posXghostorange - 2] == "?" && tembok[posYghostorange, posXghostorange + 2] != "?" && tembok[posYghostorange + 1, posXghostorange] != "?" && tembok[posYghostorange - 1, posXghostorange] != "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 4);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kanan";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "bawah";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 3)
                                {
                                    arahSetanOrange = "atas";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }
                            //random gerakan Ghost Orange di pertigaan (kanan bawah kiri)
                            else if (tembok[posYghostorange, posXghostorange - 2] != "?" && tembok[posYghostorange, posXghostorange + 2] != "?" && tembok[posYghostorange + 1, posXghostorange] != "?" && tembok[posYghostorange - 1, posXghostorange] == "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 4);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kanan";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "bawah";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 3)
                                {
                                    arahSetanOrange = "kiri";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;

                                }

                            }
                            //random gerakan Ghost Orange di pertigaan (bawah kiri atas)
                            else if (tembok[posYghostorange, posXghostorange - 2] != "?" && tembok[posYghostorange, posXghostorange + 2] == "?" && tembok[posYghostorange + 1, posXghostorange] != "?" && tembok[posYghostorange - 1, posXghostorange] != "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 4);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kiri";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "bawah";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 3)
                                {
                                    arahSetanOrange = "atas";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }

                            }
                            //random gerakan Ghost Orange di pertigaan (kiri atas kanan)
                            else if (tembok[posYghostorange, posXghostorange - 2] != "?" && tembok[posYghostorange, posXghostorange + 2] != "?" && tembok[posYghostorange + 1, posXghostorange] == "?" && tembok[posYghostorange - 1, posXghostorange] != "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 4);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kanan";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "kiri";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 3)
                                {
                                    arahSetanOrange = "atas";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan atas kanan
                            else if (tembok[posYghostorange, posXghostorange - 2] == "?" && tembok[posYghostorange, posXghostorange + 2] != "?" && tembok[posYghostorange + 1, posXghostorange] == "?" && tembok[posYghostorange - 1, posXghostorange] != "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 3);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kanan";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "atas";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan kanan bawah
                            else if (tembok[posYghostorange, posXghostorange - 2] == "?" && tembok[posYghostorange, posXghostorange + 2] != "?" && tembok[posYghostorange + 1, posXghostorange] != "?" && tembok[posYghostorange - 1, posXghostorange] == "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 3);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kanan";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "bawah";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan bawah kiri
                            else if (tembok[posYghostorange, posXghostorange - 2] != "?" && tembok[posYghostorange, posXghostorange + 2] == "?" && tembok[posYghostorange + 1, posXghostorange] != "?" && tembok[posYghostorange - 1, posXghostorange] == "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 3);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "bawah";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "kiri";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan kiri atas
                            else if (tembok[posYghostorange, posXghostorange - 2] != "?" && tembok[posYghostorange, posXghostorange + 2] == "?" && tembok[posYghostorange + 1, posXghostorange] == "?" && tembok[posYghostorange - 1, posXghostorange] != "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 3);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kiri";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "atas";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }

                        }
                        else if (statusghostorange == true)
                        {
                            //setan Orange teleport
                            if (posYghostorange == 14 && posXghostorange == 0)
                            {
                                setan[posYghostorange, posXghostorange] = "";
                                posXghostorange = 54;
                                arahSetanOrange = "kiri";
                            }
                            else if (posYghostorange == 14 && posXghostorange == 54)
                            {
                                setan[posYghostorange, posXghostorange] = "";
                                posXghostorange = 0;
                                arahSetanOrange = "kanan";
                            }

                            //random gerakan Ghost Orange di perempatan
                            else if (tembok[posYghostorange, posXghostorange - 2] != "?" && tembok[posYghostorange, posXghostorange + 2] != "?" && tembok[posYghostorange + 1, posXghostorange] != "?" && tembok[posYghostorange - 1, posXghostorange] != "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 5);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kanan";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "bawah";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 3)
                                {
                                    arahSetanOrange = "kiri";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 4)
                                {
                                    arahSetanOrange = "atas";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }

                            //random gerakan Ghost Orange di pertigaan (atas kanan bawah)
                            else if (tembok[posYghostorange, posXghostorange - 2] == "?" && tembok[posYghostorange, posXghostorange + 2] != "?" && tembok[posYghostorange + 1, posXghostorange] != "?" && tembok[posYghostorange - 1, posXghostorange] != "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 4);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kanan";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "bawah";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 3)
                                {
                                    arahSetanOrange = "atas";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }
                            //random gerakan Ghost Orange di pertigaan (kanan bawah kiri)
                            else if (tembok[posYghostorange, posXghostorange - 2] != "?" && tembok[posYghostorange, posXghostorange + 2] != "?" && tembok[posYghostorange + 1, posXghostorange] != "?" && tembok[posYghostorange - 1, posXghostorange] == "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 4);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kanan";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "bawah";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 3)
                                {
                                    arahSetanOrange = "kiri";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;

                                }

                            }
                            //random gerakan Ghost Orange di pertigaan (bawah kiri atas)
                            else if (tembok[posYghostorange, posXghostorange - 2] != "?" && tembok[posYghostorange, posXghostorange + 2] == "?" && tembok[posYghostorange + 1, posXghostorange] != "?" && tembok[posYghostorange - 1, posXghostorange] != "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 4);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kiri";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "bawah";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 3)
                                {
                                    arahSetanOrange = "atas";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }

                            }
                            //random gerakan Ghost Orange di pertigaan (kiri atas kanan)
                            else if (tembok[posYghostorange, posXghostorange - 2] != "?" && tembok[posYghostorange, posXghostorange + 2] != "?" && tembok[posYghostorange + 1, posXghostorange] == "?" && tembok[posYghostorange - 1, posXghostorange] != "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 4);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kanan";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;

                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "kiri";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 3)
                                {
                                    arahSetanOrange = "atas";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan atas kanan
                            else if (tembok[posYghostorange, posXghostorange - 2] == "?" && tembok[posYghostorange, posXghostorange + 2] != "?" && tembok[posYghostorange + 1, posXghostorange] == "?" && tembok[posYghostorange - 1, posXghostorange] != "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 3);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kanan";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "atas";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan kanan bawah
                            else if (tembok[posYghostorange, posXghostorange - 2] == "?" && tembok[posYghostorange, posXghostorange + 2] != "?" && tembok[posYghostorange + 1, posXghostorange] != "?" && tembok[posYghostorange - 1, posXghostorange] == "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 3);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kanan";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "bawah";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan bawah kiri
                            else if (tembok[posYghostorange, posXghostorange - 2] != "?" && tembok[posYghostorange, posXghostorange + 2] == "?" && tembok[posYghostorange + 1, posXghostorange] != "?" && tembok[posYghostorange - 1, posXghostorange] == "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 3);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "bawah";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "kiri";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }
                            //arah ghost bila di perduaan kiri atas
                            else if (tembok[posYghostorange, posXghostorange - 2] != "?" && tembok[posYghostorange, posXghostorange + 2] == "?" && tembok[posYghostorange + 1, posXghostorange] == "?" && tembok[posYghostorange - 1, posXghostorange] != "?")
                            {
                            randomlagi:
                                arahRandomSetanOrange = rand.Next(1, 3);
                                if (arahRandomSetanOrange == 1)
                                {
                                    arahSetanOrange = "kiri";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                                else if (arahRandomSetanOrange == 2)
                                {
                                    arahSetanOrange = "atas";
                                    if (arahSetanOrange == arahbalikSetanOrange)
                                        goto randomlagi;
                                }
                            }

                        }
                    }
                    //gerakan Setan Orange
                    if (arahSetanOrange == "bawah")
                    {
                        posYghostorange += 1;
                        arahbalikSetanOrange = "atas";
                    }
                    else if (arahSetanOrange == "atas")
                    {
                        posYghostorange -= 1;
                        arahbalikSetanOrange = "bawah";
                    }
                    else if (arahSetanOrange == "kiri")
                    {
                        posXghostorange -= 2;
                        arahbalikSetanOrange = "kanan";
                    }
                    else if (arahSetanOrange == "kanan")
                    {
                        posXghostorange += 2;
                        arahbalikSetanOrange = "kiri";
                    }
                }


                //Teleport
                if (posYpacman == 14 && posXpacman == 0 && arah == "kiri")
                {
                    tembok[posYpacman, posXpacman] = " ";
                    posXpacman = 54;
                }
                else if (posYpacman == 14 && posXpacman == 54 && arah == "kanan")
                {
                    tembok[posYpacman, posXpacman] = " ";
                    posXpacman = 0;
                }



                //Gerakan pacman
                else if (arah == "kiri" && tembok[posYpacman, posXpacman - 2] != "?")
                {
                    tembok[posYpacman, posXpacman] = " ";
                    posXpacman -= 2;
                }
                else if (arah == "kanan" && tembok[posYpacman, posXpacman + 2] != "?")
                {
                    tembok[posYpacman, posXpacman] = " ";
                    posXpacman += 2;
                }
                else if (arah == "bawah" && tembok[posYpacman + 1, posXpacman] != "?")
                {
                    tembok[posYpacman, posXpacman] = " ";
                    posYpacman += 1;
                }
                else if (arah == "atas" && tembok[posYpacman - 1, posXpacman] != "?")
                {
                    tembok[posYpacman, posXpacman] = " ";
                    posYpacman -= 1;
                }


                //cek tembok agar gerakan tetap jalan
                if (arahsebelum == "atas" && arah == "kanan")
                {
                    if (tembok[posYpacman, posXpacman + 2] == "?")
                    {
                        arah = "atas";
                    }
                    else
                        arahsebelum = "kanan";
                }
                else if (arahsebelum == "atas" && arah == "kiri")
                {
                    if (tembok[posYpacman, posXpacman - 2] == "?")
                    {
                        arah = "atas";
                    }
                    else
                        arahsebelum = "kiri";
                }
                else if (arahsebelum == "bawah" && arah == "kanan")
                {
                    if (tembok[posYpacman, posXpacman + 2] == "?")
                    {
                        arah = "bawah";
                    }
                    else
                        arahsebelum = "kanan";
                }
                else if (arahsebelum == "bawah" && arah == "kiri")
                {
                    if (tembok[posYpacman, posXpacman - 2] == "?")
                    {
                        arah = "bawah";
                    }
                    else
                        arahsebelum = "kiri";
                }
                else if (arahsebelum == "kiri" && arah == "atas")
                {
                    if (tembok[posYpacman - 1, posXpacman] == "?")
                    {
                        arah = "kiri";
                    }
                    else
                        arahsebelum = "atas";
                }
                else if (arahsebelum == "kiri" && arah == "bawah")
                {
                    if (tembok[posYpacman + 1, posXpacman] == "?")
                    {
                        arah = "kiri";
                    }
                    else
                        arahsebelum = "bawah";
                }
                else if (arahsebelum == "kanan" && arah == "atas")
                {
                    if (tembok[posYpacman - 1, posXpacman] == "?")
                    {
                        arah = "kanan";
                    }
                    arahsebelum = "atas";
                }
                else if (arahsebelum == "kanan" && arah == "bawah")
                {
                    if (tembok[posYpacman + 1, posXpacman] == "?")
                    {
                        arah = "kanan";
                    }
                    else
                        arahsebelum = "bawah";
                }



                if ((arah == "kiri" || arah == "kanan" || arah == "atas" || arah == "bawah") && tembok[posYpacman, posXpacman] == "*")
                    score += 10;
                else if ((arah == "kiri" || arah == "kanan" || arah == "atas" || arah == "bawah") && tembok[posYpacman, posXpacman] == "O")
                    score += 50;
                if (tembok[posYpacman, posXpacman] == "O")
                {
                    statuspacman = true;
                    statusghostmerah = true;
                    statusghostpink = true;
                    statusghostorange = true;
                    statusghostbiru = true;
                }

                tembok[posYpacman, posXpacman] = "C";
                //Setting Posisi Ghost
                for (int i = 0; i <= 30; i++)
                {
                    for (int j = 0; j <= 54; j++)
                    {
                        setan[i, j] = "";
                    }
                }
                setan[posYghostmerah, posXghostmerah] = "@";
                setan[posYghostpink, posXghostpink] = "#";
                setan[posYghostbiru, posXghostbiru] = "$";
                setan[posYghostorange, posXghostorange] = "%";

                // jika pacman makan Power up "O"
                if (statuspacman == true)
                {
                    if (posYghostmerah == posYpacman && posXpacman == posXghostmerah && statusghostmerah == true)
                    {
                        statusghostmerah = false;
                        arahSetanMerah = "";
                        resetSetanMerah = true;
                        posXghostmerah = 26;
                        posYghostmerah = 14;
                        score += 200;
                    }
                    if (posYghostpink == posYpacman && posXghostpink == posXpacman && statusghostpink == true)
                    {
                        statusghostpink = false;
                        arahSetanPink = "";
                        resetSetanPink = true;
                        posXghostpink = 26;
                        posYghostpink = 14;
                        score += 200;
                    }
                    if (posYghostbiru == posYpacman && posXghostbiru == posXpacman && statusghostbiru == true)
                    {
                        statusghostbiru = false;
                        arahSetanBiru = "";
                        resetSetanBiru = true;
                        posXghostbiru = 24;
                        posYghostbiru = 14;
                        score += 200;
                    }
                    if (posYghostorange == posYpacman && posXghostorange == posXpacman && statusghostorange == true)
                    {
                        statusghostorange = false;
                        arahSetanOrange = "";
                        resetSetanOrange = true;
                        posXghostorange = 28;
                        posYghostorange = 14;
                        score += 200;
                    }
                    waktuPowerUp--;
                    if (waktuPowerUp == 0)
                    {
                        waktuPowerUp = 150;//reset waktu
                        statuspacman = false;
                        statusghostmerah = false;
                        statusghostpink = false;
                        statusghostbiru = false;
                        statusghostorange = false;
                        resetSetanMerah= false;
                        resetSetanPink = false;
                        resetSetanBiru = false;
                        resetSetanOrange = false;
                    }
                }

                //  Cek Kondisi matek
                if ((posYghostmerah == posYpacman && posXghostmerah == posXpacman && statusghostmerah == false) || (posYghostpink == posYpacman && posXghostpink == posXpacman && statusghostpink == false) || (posYghostbiru == posYpacman && posXghostbiru == posXpacman && statusghostbiru == false) || (posYghostorange == posYpacman && posXghostorange == posXpacman && statusghostorange == false) || (posYpacman == posYghostmerah && posXpacman == posXghostmerah && statusghostmerah == false) || (posYpacman == posYghostpink && posXpacman == posXghostpink && statusghostpink == false) || (posYpacman == posYghostbiru && posXpacman == posXghostbiru && statusghostbiru == false) || (posYghostorange == posYpacman && posYghostorange == posXpacman && statusghostorange == false))
                {
                    tembok[posYpacman, posXpacman] = " ";
                    live--;
                    apaSudahgerak = false;
                    if (live == 0)
                    {
                        Console.Write("Game Over !!!");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Write("Mati\nsisanyawa: " + live);
                    }

                    //Reset position
                    posXpacman = 28;
                    posYpacman = 17;

                    posXghostmerah = 28;
                    posYghostmerah = 11;

                    posXghostorange = 28;
                    posYghostorange = 14;

                    posXghostpink = 26;
                    posYghostpink = 14;

                    posXghostbiru = 24;
                    posYghostbiru = 14;

                    //reset arah
                    arah = "";
                    arahSetanMerah = "";
                    arahSetanPink = "";
                    arahSetanBiru = "";
                    arahSetanOrange = "";

                    //reset power up
                    statuspacman = false;
                    statusghostmerah = false;
                    statusghostpink = false;
                    statusghostbiru = false;
                    statusghostorange = false;
                    resetSetanMerah = false;
                    resetSetanPink = false;
                    resetSetanBiru = false;
                    resetSetanOrange = false;

                    //setan[posYghostmerah, posXghostmerah] = "@";
                    waktu = 0;
                    count = 0;
                    Console.ReadKey();
                }

                //Cek menang
                bool menang = false;
                for (int i = 0; i <= 30; i++)
                {
                    for (int j = 0; j <= 54; j++)
                    {
                        if (tembok[i, j] == "*" || tembok[i, j] == "O")
                            menang = true;
                    }
                }
                if (menang == false)
                {
                    Console.WriteLine("YOU WIN\n", Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("Press ESC to EXIT or Press Any key to play again");
                    var keys = Console.ReadKey(true);

                    if (keys.Key == ConsoleKey.Escape) { Environment.Exit(0); }
                    else
                    {
                        Console.Clear();
                        statuspacman = false;
                        statusghostmerah = false;
                        statusghostpink = false;
                        statusghostbiru = false;
                        statusghostorange = false; goto ulang;

                    }


                    Environment.Exit(0);
                }
                // Cetak Map
                CetakMap();


                Console.SetCursorPosition(0, 33);
                Console.Write("Score: {0}", score);
                //Console.SetCursorPosition(0, 34);
                //Console.Write(waktu);
                Console.SetCursorPosition(48, 33);
                Console.Write("Live: " + live);
                //Console.SetCursorPosition(0, 35);
                //Console.WriteLine("PosYghostmerah: {0}\nPosXghostmerah: {1}", posYghostmerah, posXghostmerah);
                //Console.Write(statuspacman);
                Thread.Sleep(level);
                Console.Clear();

            }

        } while (true);

    }
}


