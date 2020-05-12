class C
{
    static void Main(string[] z)
    {
        foreach(var p in z)
        {
            var a=new char[99];
            var s=new int[9];
            var f=0<0;
            for(int i=0,d=0,t=0;i<p.Length;++i)
            {
                var c=p[i];
                if(f)
                {
                    if(c=='[')s[t++]=i;
                    f=c==']'?s[--t]>=0:f;
                }
                else
                {
                    if(c=='>')++d;
                    if(c=='<')--d;
                    if(c=='+')++a[d];
                    if(c=='-')--a[d];
                    if(c=='.')System.Console.Write(a[d]);
                    if(c=='[')s[t++]=(f=a[d]==0)?-1:i;
                    if(c==']')i=s[--t]-1;
                }
            }
        }
    }
}