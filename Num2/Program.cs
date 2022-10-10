/*Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

 void GetDistanse (int X1, int X2, int Y1, int Y2, int Z1, int Z2)
 {
    double result = 0;
    int tempX = (X2 - X1) * (X2 - X1); 
    int tempY = (Y2 - Y1) * (Y2 - Y1);
    int tempZ = (Z2 - Z1) * (Z2 - Z1);
    result = Math.Sqrt(tempX + tempY + tempZ);
    Console.WriteLine($"расстояние между двумяточками = {result}");
 }
 GetDistanse(7, 1, -5, -1, 0, 9);