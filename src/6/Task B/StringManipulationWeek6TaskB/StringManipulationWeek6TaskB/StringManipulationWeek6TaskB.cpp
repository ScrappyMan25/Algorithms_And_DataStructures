#include <iostream>
#include<string>

using namespace std;

void recombination(string, string, string);

int main()
{
	string String1, String2, Splitter;

	cout << "Input DNA Strand 1: " << endl;
	cin >> String1;
	cout << "Input DNA Strand 2: " << endl;
	cin >> String2;
	cout << "Input DNA Splitter Strand: " << endl;
	cin >> Splitter;

	cout << "DNA Strand 1: " << String1 << endl;
	cout << "DNA Strand 1: " << String2 << endl;
	cout << "DNA Splitter Strand: " << Splitter << endl << endl;

	recombination(String1, String2, Splitter);

	cout << "Input DNA Strand 1: " << endl;
	cin >> String1;
	cout << "Input DNA Strand 2: " << endl;
	cin >> String2;
	cout << "Input DNA Splitter Strand: " << endl;
	cin >> Splitter;

	cout << "DNA Strand 1: " << String1 << endl;
	cout << "DNA Strand 1: " << String2 << endl;
	cout << "DNA Splitter Strand: " << Splitter << endl << endl;

	recombination(String1, String2, Splitter);

	return 0;
}

void recombination(string s1, string s2, string s)
{
	string s1_left, s1_right, s2_left, s2_right;
	int s1_splitter = 0, s2_splitter = 0;
	int s1_from = 0, s2_from = 0;
	s1_splitter = s1.find(s, s1_from);
	s2_splitter = s2.find(s, s2_from);

	//cout << s1_splitter << endl << s2_splitter << endl;

	if (s1_splitter != -1 && s2_splitter != -1)
	{
		do
		{
			do
			{
				s1_left.assign(s1, 0, s1_splitter);
				s1_right.assign(s1, (s1_splitter + s.length()), s1.length());
				s2_left.assign(s2, 0, s2_splitter);
				s2_right.assign(s2, (s2_splitter + s.length()), s2.length());

				cout << s1_left + s + s2_right << endl << s2_left + s + s1_right + "\n" << endl;

				s2_from = s2_splitter + 1;
				s2_splitter = s2.find(s, s2_from);
			} while (s2_splitter != -1);

			s2_from = 0;
			s2_splitter = s2.find(s, s2_from);

			s1_from = s1_splitter + 1 ;
			s1_splitter = s1.find(s, s1_from);

		} while (s1_splitter != -1);
	}
	else
		cout << "Recombination Not Possible with Provided Sequesnses" << endl;

}