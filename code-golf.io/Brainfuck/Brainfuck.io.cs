class P
{
    static void Main(string[] z)
    {
        foreach(var p in z)
        {
            try
            {
                for(dynamic c,a=new char[99],s=new int[9],f=1>0,i=0,d=0,t=0;;i=(c==51&&f&(f|=s[--t]<0))?s[t]:++i)
                {
                    c=p[i]-42;
                    d+=(c-19)*(f&c>17&c<21?1:0);
                    a[d]+=(2-c)*(f&c>0&c<4?1:0);
                    if(f&c==4)System.Console.Write(a[d]);
                    if(c==49)s[t++]=f?(f=a[d]!=0)?i:-1:i;
                }
            }
            catch{}
        }
    }
}