using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLib
{
    public class Node<KeyType, PayloadType> where
        KeyType : IComparable<KeyType>
    {
        public Node<KeyType, PayloadType> LeftChild = null;
        public Node<KeyType, PayloadType> RightChild = null;
        public int NDescendants = 0;
        public KeyType Key { get; set; }
        public PayloadType Payload { get; set; }

        public Node(KeyType key, PayloadType payload)
        {
            Key = key;
            Payload = payload;
        }

        public static IEnumerable<Tuple<KeyType, PayloadType>> InOrderTraversal(
            Node<KeyType, PayloadType> root, List<Tuple<KeyType, PayloadType>> inOrderList)
        {
            throw new NotImplementedException();
        }

        public void ToString(StringBuilder builder)
        {
            throw new NotImplementedException();
        }

        public static void RotateRight(ref Node<KeyType,
            PayloadType> root)
        {
            throw new NotImplementedException();
        }

        public static void RotateLeft(ref Node<KeyType,
    PayloadType> root)
        {
            throw new NotImplementedException();
        }

        public static void Insert(Node<KeyType, PayloadType> root,
            KeyType key, PayloadType payload)
        {
            throw new NotImplementedException();
        }

        public static void InsertAtRoot(ref Node<KeyType, PayloadType> root,
        KeyType key, PayloadType payload)
        {
            throw new NotImplementedException();
        }

        public static int Height(Node<KeyType, PayloadType> node)
        {
            throw new NotImplementedException();
        }


        // Lab2 Functions


        public static KeyType MinKey(Node<KeyType, PayloadType> root)
        {
            throw new NotImplementedException();
        }

        public static KeyType MaxKey(Node<KeyType, PayloadType> root)
        {
            throw new NotImplementedException();
        }


        public static void ComputeNDescendants(Node<KeyType, PayloadType> myNode)
        {
            throw new NotImplementedException();
        }

  
        public static KeyType Select(Node<KeyType, PayloadType> root, int targetRank)
        {
            throw new NotImplementedException();
        }



        public static int Rank(Node<KeyType, PayloadType> root, KeyType targetKey)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<Tuple<KeyType, PayloadType>> Range(
            Node<KeyType, PayloadType> root, KeyType min, KeyType max)
        {
            throw new NotImplementedException();
        }
    }
}
