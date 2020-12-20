#include <iostream>
#include<string>
// substitute chars in a string
void substitute(char*, char, char);
int main()
{
	using namespace std;

	char c1 = 'a', c2 = 'x';
	string s = "la!belavella!bel";
	char* p;

	cout << "Original String: " << s << endl;

	for (int i = 0; i < s.length(); i++)
	{
		p = &s[i];
		substitute(p, c1, c2);
	}

	cout << "Ammended String: " << s << endl;

	return 0;
}

void substitute(char* s, char c1, char c2)
{
	if (*s == c1 && *(s + 1) == '!')
	{
		*s = c2;
	}
}

