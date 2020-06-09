#include <iostream>

#include <string>



using namespace std;



int Addition(int, int);

int Increment(int);

void Increment(int, int&);

bool Ifless(int, int);

void Ifless(int, int, bool&);





int main(int argc, const char* argv[]) {

    cout << Increment(-128) << endl;

    cout << Increment(45) << endl;

    cout << Increment(163) << endl;

    bool a, b, c;

    Ifless(33, 117, a);

    cout << boolalpha << a << endl;

    Ifless(-6, -10, b);

    cout << boolalpha << b << endl;

    Ifless(26, 26, c);

    cout << boolalpha << c << endl;



}



int Addition(int number1, int number2)

{

    while (number2 != 0)

    {

        auto carry = number1 & number2;

        number1 ^= number2;

        number2 = carry << 1;

    }

    return number1;
}



int Increment(int number)

{

    return -~number;

}



void Increment(int number, int& result)

{

    result = -~number;

}



bool Ifless(int number1, int number2)

{

    if (!(bool)(number1 ^ number2))

    {

        return false;

    }

    auto sign = Addition(number1, Addition(~number2, 1)) >> 31;

    return !(sign == 0);

}





void Ifless(int number1, int number2, bool& result)

{

    if (!(bool)(number1 ^ number2))

    {

        result = false;

    }

    auto sign = Addition(number1, Addition(~number2, 1)) >> 31;

    result = !(bool)(sign == 0);

}