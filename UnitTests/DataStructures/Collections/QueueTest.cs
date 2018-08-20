using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using DS = DataStructures.Collections;

namespace UnitTests.DataStructures.Collections
{
    public class QueueTest
    {
        DS.Queue<int> queue = new DS.Queue<int>();

        [Theory]
        [InlineData(1)]
        public void Enqueue(int value)
        {
            queue.Enqueue(value);
        }

        [Theory]
        [InlineData(new[] { 3, 4, 5, 6, 7, 1, 2, 34, 5, 6, 7, 7 })]
        public void EnqueueCollection(IEnumerable<int> collection)
        {
            foreach (var item in collection)
            {
                queue.Enqueue(item);
            }
        }

        [Theory]
        [InlineData(new[] { 3, 4, 5, 6, 7, 1, 2, 34, 5, 6, 7, 7 })]
        public void EnqueueDequeCollection(int[] collection)
        {
            for (int i = 0; i < collection.Count() / 2; i++)
            {
                queue.Enqueue(collection[i]);
            }
            queue.Dequeue();
            queue.Dequeue();

            for (int i = collection.Count() / 2; i < collection.Count(); i++)
            {
                queue.Enqueue(collection[i]);
            }
        }

        [Fact]
        public void Dequeue()
        {
            try
            {
                int result = queue.Dequeue();
            }
            catch (InvalidOperationException) { }
        }


    }
}
