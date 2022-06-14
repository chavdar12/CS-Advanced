using System.Collections;

namespace _003;

public class Lake : IEnumerable<int>
{
    private IReadOnlyList<int> stones;

    public Lake(int[] stones)
    {
        this.stones = stones;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (var i = 0; i < stones.Count; i += 2) yield return stones[i];

        for (var i = stones.Count - 1; i >= 0; i--)
            if (i % 2 != 0)
                yield return stones[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}