namespace System.Collections.Generic
{
    class C
    {
        static void Main(string[] z)
        {
            foreach(var p in z)
            {
                var a=new char[99];
                var s=new Stack<int>();
                var f=0<0;
                for(int i=0,d=0;i<p.Length;++i)
                {
                    if(f)
                    {
                        if(p[i]=='[')s.Push(i);
                        f=p[i]==']'?s.Pop()>=0:f;
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
                                Console.Write(a[d]);
                                break;
                            case'[':
                                f=a[d]==0;
                                s.Push(f?-1:i);
                                break;
                            case']':
                                i=s.Pop()-1;
                                break;
                        }
                    }
                }
            }
        }
    }
}
