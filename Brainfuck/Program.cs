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
                if(f)
                {
                    if(p[i]=='[')s[t++]=i;
                    f=p[i]==']'?s[--t]>=0:f;
                }
                else
                {
                    switch(p[i])
                    {
                        case'>':
                            ++d;
                            break;
                        case'<':
                            --d;
                            break;
                        case'+':
                            ++a[d];
                            break;
                        case'-':
                            --a[d];
                            break;
                        case'.':
                            System.Console.Write(a[d]);
                            break;
                        case'[':
                            f=a[d]==0;
                            s[t++]=f?-1:i;
                            break;
                        case']':
                            i=s[--t]-1;
                            break;
                    }
                }
            }
        }
    }
}
