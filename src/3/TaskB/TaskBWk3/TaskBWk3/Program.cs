using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBWk3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(" ---< AVLTrees TEST >--- ");
            System.Console.WriteLine(" Step 1: Create 2 AVL Test Trees! \n");

            AVLTree<int> intTree1 = new AVLTree<int>();
            intTree1.InsertItem(12);
            intTree1.InsertItem(15);
            intTree1.InsertItem(16);
            intTree1.InsertItem(4);
            intTree1.InsertItem(17);
            intTree1.InsertItem(18);
            intTree1.InsertItem(13);
            intTree1.InsertItem(19);
            intTree1.InsertItem(20);

            AVLTree<int> intTree2 = new AVLTree<int>();
            intTree2.InsertItem(17);
            intTree2.InsertItem(16);
            intTree2.InsertItem(18);
            intTree2.InsertItem(19);
            intTree2.InsertItem(20);

            System.Console.WriteLine($"AVLTree 1 InOrder :=>\t {intTree1.InOrder()}");
            System.Console.WriteLine($"AVLTree 1 Height :=> \t {intTree1.Height()}");
            System.Console.WriteLine($"AVLTree 2 InOrder :=>\t {intTree2.InOrder()}");
            System.Console.WriteLine($"AVLTree 2 Height :=> \t {intTree2.Height()}");
            
            
            System.Console.WriteLine($"\nStep 2 : Check if Tree 2 is a Equal to And/Or a SubTree of Tree 1");
            System.Console.WriteLine($"\nEquals: \t{intTree1.Equals(intTree2)} ");
            System.Console.WriteLine($"SubTree:\t{intTree1.SubTree(intTree2)}\n ");

            System.Console.WriteLine($"\nStep 3 : Add item to Tree 2 And Check if Tree 2 is a Equal to And/Or a SubTree of Tree 1\n");
            intTree2.InsertItem(21);
            System.Console.WriteLine($"AVLTree 1 InOrder :=>\t {intTree1.InOrder()}");
            System.Console.WriteLine($"AVLTree 1 Height :=> \t {intTree1.Height()}");
            System.Console.WriteLine($"AVLTree 2 InOrder :=>\t {intTree2.InOrder()}");
            System.Console.WriteLine($"AVLTree 2 Height :=> \t {intTree2.Height()}");
            
            System.Console.WriteLine($"\nEquals: \t{intTree1.Equals(intTree2)} ");
            System.Console.WriteLine($"SubTree:\t{intTree1.SubTree(intTree2)}\n ");

            System.Console.WriteLine($"\nStep 4 : Make Tree2 a Copy of Tree1 and test if the trees are Equal\n");
           intTree2.Copy(intTree1);

            System.Console.WriteLine($"AVLTree 1 InOrder :=>\t {intTree1.InOrder()}");
            System.Console.WriteLine($"AVLTree 1 Height :=> \t {intTree1.Height()}");
            System.Console.WriteLine($"AVLTree 2 InOrder :=>\t {intTree2.InOrder()}");
            System.Console.WriteLine($"AVLTree 2 Height :=> \t {intTree2.Height()}");

            System.Console.WriteLine($"\nEquals: \t{intTree1.Equals(intTree2)} ");
            System.Console.WriteLine($"SubTree:\t{intTree1.SubTree(intTree2)}\n ");

            
            System.Console.ReadKey();
        }
    }
}
