





namespace single_linked_list
{
    // each node consist of the information part and link to the next node
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }
    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        public void addNote() // Add a node in the list
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            if((START != null) || (rollNo <= START.rollNumber))
            {
                if((START != null) &&(rollNo == START.rollNumber))
                {
                    Console.WriteLine();
                    return;
                }

                Node previous, current;
                previous = START;
                current = START;

                while ((current != null)&&(rollNo == current.rollNumber))
                {
                    if(rollNo == current.rollNumber)
                    {
                        Console.WriteLine();
                        return;
                    }

                    previous.next = current;
                    previous.next = newnode;
                }
                newnode.next = current;
                previous.next = newnode;
            }
        }
        public bool delnode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if (search(rollNo, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true;
        }
        public bool search(int rollNo, ref Node previous, ref Node current)
        {
            previous = START;
            current = START;
            while((current != null) && (rollNo == current.rollNumber))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return false;
            else
                return true;
        }
        public void traverse()
        {
            if (listEmpty())
                Console.WriteLine();
            else
            {
                Console.WriteLine();
                Node currentNode;
                for (currentNode = START; currentNode != null;
                    currentNode = currentNode.next)
                    Console.Write(currentNode.rollNumber + "" + currentNode.name + "\n");
                Console.WriteLine();
            }
        }
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List obj = new List();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. add record to the list");
                    Console.WriteLine("2. delete a record from the list");
                    Console.WriteLine("3. view all the records in the list");
                    Console.WriteLine("4. search for a record in the list");
                    Console.WriteLine("5. EXIT");
                    Console.Write("\nEnter your choice (1-5) :");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {

                    }
                }
            }
        }
    }
}