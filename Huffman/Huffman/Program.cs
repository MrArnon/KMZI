using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Huffman
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "foo bar";
            HuffmanTree huffmanTree = new HuffmanTree();
            if(1!=input.Length)
            {
            // Build the Huffman tree
            huffmanTree.Build(input);

            // Encode
            BitArray encoded = huffmanTree.Encode(input);

            Console.Write("Encoded: ");
            string info = string.Empty;
            foreach (bool bit in encoded)
            {
                // Console.Write((bit ? 1 : 0) + "");
                if (bit) info += '1';
                else info += '0';

            }
            Console.WriteLine(info);
            Console.WriteLine();

            // Decode
            string decoded = huffmanTree.Decode(encoded);

            Console.WriteLine("Decoded: " + decoded);

            Console.ReadLine();
            }
        else
        {
        Console.WriteLine("Decoded: " + "0");
        Console.ReadLine();
        }
        }
    }
}
