using System;
using System.Collections.Generic;
using ThirtyDayChallenge.Challenges;
namespace ThirtyDayChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      var obj = new Day30CheckValidSequence();
      var input = new TreeNode(0)
      {
        left = new TreeNode(1)
        {
          left = new TreeNode(1),
          right = new TreeNode(1)
          {
            left = new TreeNode(0),
            right = new TreeNode(0)
          }
        },
        right = new TreeNode(0)
        {
          left = new TreeNode(0),
          right = new TreeNode(0)
          {
            left = new TreeNode(1)
            {
              left = new TreeNode(0)
              {
                right = new TreeNode(1)
              },
              right = new TreeNode(1)
              {
                left = new TreeNode(0),
                right = new TreeNode(0)
              }
            },
            right = new TreeNode(0)
            {
              left = new TreeNode(0),
              right = new TreeNode(0)
              {
                left = new TreeNode(1)
                {
                  left = new TreeNode(0)
                  {
                    right = new TreeNode(1)
                  },
                  right = new TreeNode(1)
                  {
                    left = new TreeNode(0),
                    right = new TreeNode(0)
                  }
                },
                right = new TreeNode(0)
                {
                  left = new TreeNode(0),
                  right = new TreeNode(0)
                  {
                    left = new TreeNode(1)
                    {
                      left = new TreeNode(0)
                      {
                        right = new TreeNode(1)
                      },
                      right = new TreeNode(1)
                      {
                        left = new TreeNode(0),
                        right = new TreeNode(0)
                      }
                    },
                    right = new TreeNode(0)
                    {
                      left = new TreeNode(0),
                      right = new TreeNode(0)
                      {
                        left = new TreeNode(1)
                        {
                          left = new TreeNode(0)
                          {
                            right = new TreeNode(1)
                          },
                          right = new TreeNode(1)
                          {
                            left = new TreeNode(0),
                            right = new TreeNode(0)
                          }
                        },
                        right = new TreeNode(0)
                        {
                          left = new TreeNode(0),
                          right = new TreeNode(0)
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      };

      Console.WriteLine(obj.IsValidSequence(input, new[] { 0, 1, 1 }));
    }
  }
}
//ghbrc
