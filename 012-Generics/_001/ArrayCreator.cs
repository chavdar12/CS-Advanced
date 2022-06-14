namespace _001;

public static class ArrayCreator
{
    public static T[] Create<T>(int length, T defaultItem)
    {
        var result = new T[length];
        for (var i = 0; i < length; i++) result[i] = defaultItem;

        return result;
    }
}