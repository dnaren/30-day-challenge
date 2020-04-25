using System.Collections.Generic;
namespace ThirtyDayChallenge.Challenges
{
  public class LRUCache
  {
    /*
    Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and put.

    get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
    put(key, value) - Set or insert the value if the key is not already present. 
    When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.

    The cache is initialized with a positive capacity.

    Follow up:
    Could you do both operations in O(1) time complexity?

    Example:

    LRUCache cache = new LRUCache( 2 capacity );

    cache.put(1, 1);
    cache.put(2, 2);
    cache.get(1);       // returns 1
    cache.put(3, 3);    // evicts key 2
    cache.get(2);       // returns -1 (not found)
    cache.put(4, 4);    // evicts key 1
    cache.get(1);       // returns -1 (not found)
    cache.get(3);       // returns 3
    cache.get(4);       // returns 4
    */

    private Item Head = new Item();
    private Item Tail = new Item();
    private Dictionary<int, Item> Cache = new Dictionary<int, Item>();
    private int MaxCapacity { get; }
    private int CurrentItemCount { get; set; }

    public LRUCache(int capacity)
    {
      MaxCapacity = capacity;
      Head.Next = Tail;
      Tail.Previous = Head;
    }

    public int Get(int key)
    {
      if (Cache.ContainsKey(key))
      {
        var item = Cache[key];
        item.Previous.Next = item.Next;
        item.Next.Previous = item.Previous;

        if (item.Next == Tail)
        {
          Tail.Previous = item.Previous;
        }

        item.Previous = Head;
        item.Next = Head.Next;

        Head.Next.Previous = item;
        Head.Next = item;

        return item.Value;
      }

      return -1;
    }

    public void Put(int key, int value)
    {
      if (Get(key) != -1)
      {
        //Item found
        Head.Next.Value = value;
      }
      else
      {
        //Item not found
        var newHead = InsertHead(key, value);
        Cache.Add(key, newHead);

        if (CurrentItemCount == MaxCapacity)
          RemoveTail();
        else
          CurrentItemCount++;

      }
    }

    private void RemoveTail()
    {
      //remove tail item 
      var itemToRemove = Tail.Previous;
      Cache.Remove(itemToRemove.Key);

      itemToRemove.Previous.Next = Tail;
      Tail.Previous = itemToRemove.Previous;
    }

    private Item InsertHead(int key, int value)
    {
      var newItem = new Item
      {
        Key = key,
        Value = value,
        Previous = Head,
        Next = Head.Next
      };

      Head.Next.Previous = newItem;
      Head.Next = newItem;

      if (CurrentItemCount == 0)
      {
        Tail.Previous = newItem;
      }

      return newItem;
    }
  }

  public class Item
  {
    public int Key { get; set; }
    public int Value { get; set; }
    public Item Previous { get; set; }
    public Item Next { get; set; }
  }
}