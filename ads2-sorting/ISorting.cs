using System;
namespace ads2_sorting
{
    public interface ISorting<T>
    {
        T[] Sort(T[] data);
    }
}
