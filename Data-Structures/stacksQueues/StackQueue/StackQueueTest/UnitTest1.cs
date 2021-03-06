using System;
using Xunit;
using StackQueue.Classes;

namespace StackQueueTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests if a node can be pushed to the top of a stack
        /// </summary>
        [Fact]
        public void CanPushNodeToStack()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Stack stack = new Stack(node1);

            stack.Push(node2);

            Assert.Equal(node2, stack.Top);
        }  
        
        /// <summary>
        /// Tests if a node can be popped off the top of a stack
        /// </summary>
        [Fact]
        public void CanPopOffStack()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Stack stack = new Stack(node1);
            stack.Push(node2);

            Assert.Equal(node2, stack.Pop());
        }
        
        /// <summary>
        /// Tests if top node on stack can be peeked at
        /// </summary>
        [Fact]
        public void CanPeekTopOfStack()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Stack stack = new Stack(node1);
            stack.Push(node2);

            Assert.Equal(node2, stack.Peek());
        }
        
        /// <summary>
        /// Tests if new node can be enqueued on a queue
        /// </summary>
        [Fact]
        public void CanEnqueueNewNode()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Queue queue = new Queue(node1);

            queue.Enqueue(node2);

            Assert.Equal(node2, queue.Rear);
        }
        
        /// <summary>
        /// Tests if new node can be dequeued from a queue
        /// </summary>
        [Fact]
        public void CanDequeueNodeFromQueue()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Queue queue = new Queue(node1);
            queue.Enqueue(node2);

            Assert.Equal(node1, queue.Dequeue());
        }

        /// <summary>
        /// Tests if first node in queue can be peeked at
        /// </summary>
        [Fact]
        public void CanPeekAtFrontNodeInQueue()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Queue queue = new Queue(node1);
            queue.Enqueue(node2);

            Assert.Equal(node1, queue.Peek());
        }
    }
}
