int number = 121;
bool isPalindrome = true;

if (number < 0)
    isPalindrome = false;
else{
    int reverse = 0;
    int temp = number;
    while (temp > 0){
        reverse = reverse * 10 + temp % 10;
        temp /= 10;
    }
    if (reverse != number)
        isPalindrome = false;
}

Console.WriteLine(isPalindrome);
