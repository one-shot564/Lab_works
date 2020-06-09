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

    Text skovoroda("������� �i��� � ������ i �����,");
    skovoroda.Addstr("����� ����� ��i� �� ������;");
    skovoroda.Addstr("������� ����� � ����� i �����,");
    skovoroda.Addstr("����� ����� ��i� ���� �i�������");

    skovoroda.OutText();

    Stroka Esenin_1("�� �����, �� ����, �� �����");
    Stroka Esenin_2("��� �������, ��� � ����� ������ ���");

    skovoroda.Addstr(Esenin_1);
    skovoroda.OutText();

    skovoroda.Delstr(5);
    skovoroda.OutText();

    skovoroda.change('�', '�');      
    skovoroda.OutText();

    cout << skovoroda.Numberlet() << " �������" << endl;
    cout << "=============================================================================\n";

    skovoroda.Addstr("������� ����� � ����� i �����,");
    skovoroda.Addstr("������� ����� � ����� i �����,");

    skovoroda.OutText();
    cout << skovoroda.Find("������� ����� � ����� i �����,") << endl;
    cout << "=============================================================================\n";
    system("pause");






}
