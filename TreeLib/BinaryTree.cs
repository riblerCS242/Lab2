using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLib
{

    public class BinaryTree<KeyType, PayloadType>
           where KeyType : IComparable<KeyType>
    {
        Node<KeyType, PayloadType> Root = null;

        public string printConnections()
        {
            throw new NotImplementedException();
        }

        public int Height()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public void Insert(KeyType key,
        PayloadType payload)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tuple<KeyType, PayloadType>> InOrderTraversal()
        {
            throw new NotImplementedException();
        }

        public void InsertAtRoot(KeyType key, PayloadType payload)
        {
            throw new NotImplementedException();
        }

        // Lab2 Functions

        public int ComputeNDescendants()
        {
            throw new NotImplementedException();
        }

        public KeyType Select(int targetRank)
        {
            throw new NotImplementedException();
        }

        public int Rank(KeyType targetKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tuple<KeyType, PayloadType>> Range(KeyType min, KeyType max)
        {
            throw new NotImplementedException();
        }
    }
}
