
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Utils {
    [Serializable]
    public class GenericQueue<T> {
        public List<T> queue;

        public GenericQueue() {
            queue = new List<T>();
        }

        public void Enqueue(T value) {
            queue.Add(value);
        }

        public T Dequeue() {
  
            T tempQueuedVariable = queue[0];
            queue.RemoveAt(0);
            return tempQueuedVariable;
            

        }

        public int Size() {
            return queue.Count;
        }

        public void Clear() {
            queue.Clear();
        }

    }
}
