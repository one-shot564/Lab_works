#include <string>
#include <iostream>
#include <string.h>
#include <vector>



using namespace std;


class Stroka
{
private:

    string str;

public:

    Stroka(string strochka)
    {
        str = strochka;
    }

    string Getstr()
    {
        return str;
    }

    int Length()
    {
        return str.length();
    }

    void Change(char a, char b)
    {
        for (int i = 0; i < str.length(); i++)
        {
            if (str[i] == a) str[i] = b;
        }

    }

};

class Text
{


private:

    vector <Stroka> text;


public:

    Text(Stroka str)
    {
        text = vector <Stroka>{ str };
    }

    Text(string str)
    {
        text = vector <Stroka>{ Stroka(str) };
    }


    void Addstr(Stroka str)
    {
        text.push_back(str);
    }

    void Addstr(string str)
    {
        text.push_back(Stroka(str));
    }




    void Delstr(int number)
    {
        text.erase(text.begin() + number - 1);
    }

    void Clear()
    {
        text.clear();
    }


    int lengthStroka(int i)
    {
        return text[i].Length();
    }

    int Numberlet()
    {
        int number = 0;
        for (int i = 0; i < text.size(); i++)
        {
            number += lengthStroka(i);
        }

        return number;
    }

    int Find(string strtofind)
    {
        int count = 0;
        for (int i = 0; i < text.size(); i++)
        {
            if (strtofind == text[i].Getstr()) count++;
        }

        return count;
    }

    void change(char a, char b)
    {
        for (int i = 0; i < text.size(); i++)
        {
            text[i].Change(a, b);

        }
    }

    void OutText()
    {
        for (int i = 0; i < text.size(); i++)
        {

            cout << text[i].Getstr() << endl;
        }
        cout << "=============================================================================\n";

    }
};






void main()
{
    setlocale(LC_ALL, "Ukr");

    Text skovoroda("Всякому мiсту — звичай i права,");
    skovoroda.Addstr("Всяка тримає свiй ум голова;");
    skovoroda.Addstr("Всякому серцю — любов i тепло,");
    skovoroda.Addstr("Всякеє горло свiй смак вiднайшло");

    skovoroda.OutText();

    Stroka Esenin_1("не жалею, не зову, не плачу");
    Stroka Esenin_2("Все пройдет, как с белых яблонь дым");

    skovoroda.Addstr(Esenin_1);
    skovoroda.OutText();

    skovoroda.Delstr(5);
    skovoroda.OutText();

    skovoroda.change('в', 'у');      
    skovoroda.OutText();

    cout << skovoroda.Numberlet() << " символи" << endl;
    cout << "=============================================================================\n";

    skovoroda.Addstr("Всякому серцю — любов i тепло,");
    skovoroda.Addstr("Всякому серцю — любов i тепло,");

    skovoroda.OutText();
    cout << skovoroda.Find("Всякому серцю — любов i тепло,") << endl;
    cout << "=============================================================================\n";
    system("pause");






}
