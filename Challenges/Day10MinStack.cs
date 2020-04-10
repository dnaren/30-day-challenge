using System.Collections.Generic;

namespace ThirtyDayChallenge.Challenges
{
  public class MinStack
  {
    /*
    Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

    push(x) -- Push element x onto stack.
    pop() -- Removes the element on top of the stack.
    top() -- Get the top element.
    getMin() -- Retrieve the minimum element in the stack.
    

    Example:

    MinStack minStack = new MinStack();
    minStack.push(-2);
    minStack.push(0);
    minStack.push(-3);
    minStack.getMin();   --> Returns -3.
    minStack.pop();
    minStack.top();      --> Returns 0.
    minStack.getMin();   --> Returns -2.

    */
    private List<int> stack;
    private List<int> minStack;
    public MinStack()
    {
      stack = new List<int>();
      minStack = new List<int>();
    }

    public void Push(int x)
    {
      stack.Add(x);
      if (minStack.Count == 0 || minStack[0] >= x)
      {
        minStack.Insert(0, x);
      }
    }

    public void Pop()
    {
      if (stack.Count > 0)
      {
        var toBePoppedValue = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);

        if (toBePoppedValue == minStack[0])
        {
          minStack.RemoveAt(0);
        }
      }
    }

    public int Top()
    {
      return stack[stack.Count - 1];
    }

    public int GetMin()
    {
      return minStack[0];
    }
  }
}