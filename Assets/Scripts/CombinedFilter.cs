using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return DecrementiflessthanfirstFilter.cubes(ModO3.Module3(xs));
        //return ModO3.Module3(xs);
    }
}

