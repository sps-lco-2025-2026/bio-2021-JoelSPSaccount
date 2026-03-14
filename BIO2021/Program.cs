using System.Diagnostics;

// Q1 - create a class based on the data given 
bool e = DownPat.IsValid("DEC");
Debug.Assert(!DownPat.IsValid("DE"));
Debug.Assert(DownPat.IsValid("C"));
Debug.Assert(DownPat.IsValid("DEC"));
// test the output 
public class DownPat
{
    public static bool IsValid(string Pat)
    {
        if (Pat.Length==2) return Pat[0]>Pat[1];
        else if(Pat.Length==1) return true;
        else for (int i = 1;i<Pat.Length;i++)
            if (IsValid(new string(Pat.Substring(0,i).Reverse().ToArray())) & IsValid(new string(Pat.Substring(i).Reverse().ToArray())))
                return true;
        return false;
    }
}
