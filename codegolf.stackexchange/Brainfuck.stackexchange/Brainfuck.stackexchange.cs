﻿using C=System.Console;
class P
{
    static void Main(string[] z)
    {
        try
        {
            for(dynamic c,p=z[0],a=new int[30000],s=new int[9],f=1>0,i=0,d=0,t=0;;)
            {
                c=p[i];
                d+=(c-61)*(f&c>59&c<63?1:0);
                a[d]+=(44-c)*(f&c>42&c<46?1:0);
                if(f&c==46)C.Write((char)a[d]);
                if(f&c==44)a[d]=C.Read();
                if(c==91)s[t++]=f?(f=a[d]!=0)?i:-1:i;
                i=(c==93&&f&(f|=s[--t]<0))?s[t]:++i;
            }
        }
        catch{}
    }
}