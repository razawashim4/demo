CheckPalindrom();
void CheckPalindrom()
{
    Console.WriteLine("Enter a number or sentance");
    string? num=Console.ReadLine();
    if(num != null)
    for(int i = 0, j = num.Length - 1; i < num.Length / 2; i++, j--)
    {
            if (num[i] == num[j])
            {
                if(i == ((num.Length/2)-1))
                {
                    Console.WriteLine("Your number is Armstrong");
                }
            }
            else
            {
                Console.WriteLine("Your number is  not Armstrong");
                break;
            }
    }
    ////
    for(int i = 0, j = num.Length - 1; i < num.Length / 2; i++, j--)
    {
        if (num[i] == num[j])
        {
            if (i == ((num.Length / 2) - 1))
            {
                Console.WriteLine("Your number is Armstrong");
            }
        }
        else
        {
            Console.WriteLine("Your number is  not Armstrong");
            break;
        }
    }

}