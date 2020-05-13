class P
{
    static void Main(string[] z)
    {
        foreach(var p in z)
        {
            try
            {
                for(dynamic c,a=new char[99],s=new int[9],f=1>0,i=0,d=0,t=0;;)
                {
                    c=p[i];
                    if(f&c==62)++d;
                    if(f&c==60)--d;
                    if(f&c==43)++a[d];
                    if(f&c==45)--a[d];
                    if(f&c==46)System.Console.Write(a[d]);
                    if(c==91)s[t++]=f?(f=a[d]!=0)?i:-1:i;
                    i=(c==93&&f&(f|=s[--t]<0))?s[t]:++i;
                }
            }
            catch{}
        }
    }
}