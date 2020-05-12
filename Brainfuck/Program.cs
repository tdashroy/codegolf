using C=System.Console;
class P
{
    static void Main(string[] z)
    {
        foreach(var p in z)
        {
            try
            {
                for(dynamic a=new int[30000],s=new int[9],f=1>0,i=0,d=0,t=0;;)
                {
                    var c=p[i];
                    if(f&c=='>')++d;
                    if(f&c=='<')--d;
                    if(f&c=='+')++a[d];
                    if(f&c=='-')--a[d];
                    if(f&c=='.')C.Write((char)a[d]);
                    if(f&c==',')a[d]=C.Read();
                    if(c=='[')s[t++]=f?(f=a[d]!=0)?i:-1:i;
                    i=(c==']'&&f&(f|=s[--t]<0))?s[t]:++i;
                }
            }
            catch{}
        }
    }
}