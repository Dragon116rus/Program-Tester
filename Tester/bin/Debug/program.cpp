// cf324a.cpp: определяет точку входа для консольного приложения.
//

#include <iostream>
#include <vector>
#include <fstream>
#include <algorithm>
using namespace std;
int k = 0;
long long n = 10000;
vector<char> prime(n + 1, true);
vector<int> primes(n);
bool isEasy(int num) {
	int m =k;
	for (size_t i = 0; i < m; i++)
	{
		if (primes[i] >= num)
			return true;
 		if (num%primes[i] == 0)
			return false;
	}
	return true;
}
bool getOther(int num, int sum) {
	if (num + 2 == sum) {
		cout << 2 << endl << num << " " << 2;
		return true;
	}
	else
		for (size_t i = 0; i < k; i++)
		{
			if (prime[sum - num - primes[i]]) {
				cout << 3 << endl << num << " " << primes[i] << " " << sum - num - primes[i];
				return true;
			}
		}
	return false;
}
int main()
{


	prime[0] = prime[1] = false;
	for (int i = 2; i <= n; ++i)
		if (prime[i])
			if (i * 1ll * i <= n)
				for (int j = i*i; j <= n; j += i)
					prime[j] = false;

	for (size_t i = 2; i < n; i++)
	{
		if (prime[i] == true)
			primes[k++] = i;
	}
	int r;
	cin >> r;
	int sum = r;
	int n1, n2, n3;
	while (r) {
		if (isEasy(r)) {
			if (r == sum)
			{
				cout << 1 << endl;
				cout << r;
				return 0;
			}
			else
				if (getOther(r, sum))
					return 0;
		}
		r--;
	}
    return 0;
}

