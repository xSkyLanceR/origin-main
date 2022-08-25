int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a = 3;
int b = 7;
int c = 10;
int a1 = 228;
int b1 = 1;
int c1 = 9;
int a2 = 33;
int b2 = 21;
int c2 = 45;

int max = Max(Max(a, b, c), Max(a1, b1, c1), Max(a2, b2, c2));



Console.WriteLine(max);
