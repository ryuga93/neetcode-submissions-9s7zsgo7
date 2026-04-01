public class KthLargest {
    private int _k = 0;
    private PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
    public KthLargest(int k, int[] nums) {
        foreach(var num in nums)
        {
            minHeap.Enqueue(num, num);
        }

        _k = k;
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val, val);

        while (minHeap.Count > _k)
        {
            minHeap.Dequeue();
        }
        return minHeap.Peek();
    }
}
