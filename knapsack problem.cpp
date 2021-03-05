#include<iostream>
//#include<conio.h>
using namespace std;
int v[10][10];
int max(int a,int b)
{
	return a>b?a:b;
}
int  main()
{
int w[10],p[10],i,j,n,m;
//clrscr();
cout<<"enter the number of item";
cin>>n;
for(i=1;i<=n;i++)
{
	cout<<"enter weight and values for"<<i<<"the item";
	cin>>w[i]>>p[i];
}
cout<<"enter the size of knapsack";
cin>>m;
for(i=0;i<=n;i++)
v[i][0]=0;
for(j=0;j<=m;j++)
v[0][j]=0;
for(i=1;i<=n;i++)
{
	for(j=1;j<=m;j++)
	if(w[i]>j)
	v[i][j]=v[i-1][j];
	else
	v[i][j]=max(v[i-1][j],(p[i]+v[i-1][j-w[i]]));
}
cout<<"\n profit matrix is \n";
for(i=0;i<=n;i++)
{
	for(j=0;j<=m;j++)
	cout<<"\t"<<v[i][j];
cout<<endl;
}
cout<<"maximum values is=="<<v[n][m];
getch();
return 0;
}
