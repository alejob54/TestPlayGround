namespace TestPlayGround._98._Study
{
    public class Collections
    {
        // Direct Access Collections

        //String
        public string[] TestStrings(string name)
        {
            string[] strings = new string[name.Length];
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

            return strings.ToArray();
        }

        //Arrays
        public string[] TestArrays(string[] array)
        {
            Array.Reverse(array);
            return array;
        }

        //struct
        public string TestStruct(string name, string lastname)
        {
            NameStruct namestr = new NameStruct(name, lastname);
            return namestr.ToString();
        }

        public struct NameStruct
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public NameStruct(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName}";
            }
        }


        //Queues
        public struct MessageStruct
        {
            public int Id { get; set; }
            public string Message { get; set; }
        }

        private Queue<MessageStruct> MessagesQueue;

        public Collections()
        {
            MessagesQueue = new Queue<MessageStruct>();
        }
        public void AddMessage(MessageStruct message)
        {
            MessagesQueue.Enqueue(message);
        }

        public void ClearMessages()
        {
            if (MessagesQueue != null)
            {
                MessagesQueue.Clear();
            }
        }

        public void RemoveMessage()
        {
            if (MessagesQueue != null)
            {
                MessagesQueue.Dequeue();
            }
        }

        public int Count()
        {
            if (MessagesQueue == null) return 0;
            return MessagesQueue.Count();
        }

        public void Print()
        {
            if (MessagesQueue == null) return;
            foreach (var item in MessagesQueue)
            {
                Console.WriteLine($"{item.Id} {item.Message}");
            }
        }

        public void PrintAtIndex(int index)
        {
            var singleMessage = MessagesQueue.Where(a => a.Id.Equals(index)).FirstOrDefault();
            Console.WriteLine($"{singleMessage.Id} {singleMessage.Message}");
        }
    }
}
