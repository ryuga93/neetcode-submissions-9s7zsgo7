public class MedianFinder {
    private PriorityQueue<int, int> rightMinHeap = new PriorityQueue<int, int>();
    private PriorityQueue<int, int> leftMaxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

    public MedianFinder() {

    }
    
    public void AddNum(int num) {
        if (rightMinHeap.Count > 0 && num > rightMinHeap.Peek())
        {
            rightMinHeap.Enqueue(num, num);
        }
        else
        {
            leftMaxHeap.Enqueue(num, num);
        }
        
        if ((leftMaxHeap.Count - rightMinHeap.Count) > 1)
        {
            var val = leftMaxHeap.Dequeue();
            rightMinHeap.Enqueue(val, val);
        }
        else if ((rightMinHeap.Count - leftMaxHeap.Count) > 1)
        {
            var val = rightMinHeap.Dequeue();
            leftMaxHeap.Enqueue(val, val);
        }
    }
    
    public double FindMedian() {
        if ((leftMaxHeap.Count + rightMinHeap.Count) % 2 == 0)
        {
            return (leftMaxHeap.Peek() + rightMinHeap.Peek()) / 2.0;
        }
        else
        {
            if (leftMaxHeap.Count > rightMinHeap.Count)
            {
                return leftMaxHeap.Peek();
            }
            else
            {
                return rightMinHeap.Peek();
            }
        }
    }
}
