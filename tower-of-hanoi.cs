public class TowerOfHanoi
{
    private int index;
    private Stack<int> disks;

    public TowerOfHanoi(int i)
    {
        disks = new Stack<int>();
        index = i;
    }

    public int Index()
    {
        return index;
    }

    public void Push(int i)
    {
        if (disks.Count != 0 && disks.Peek() <= i)
        {
            throw new Exception("Disk push is invalid");
        }
        else
        {
            disks.Push(i);
        }
    }

    public void MovetoTop(TowerOfHanoi destination)
    {
        int top = disks.Pop();
        destination.Push(top);
    }

    public void MoveDisks(int n, TowerOfHanoi destination, TowerOfHanoi buffer)
    {
        if (n > 0)
        {
            MoveDisks(n-1, buffer, destination);
            MovetoTop(destination);
            MoveDisks(n - 1, destination, this);
        }
    }
}