using System;
using System.Collections;

/// <summary>
/// https://www.dofactory.com/net/iterator-design-pattern
/// </summary>
namespace Amazon.Core.DesignPatterns.Iterator
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Iterator Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Run()
        {
            // Build a collection
            var collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");

            // Create iterator
            // Iterator iterator = collection.CreateIterator();
            Iterator iterator = new Iterator(collection); // collection.CreateIterator();

            // Skip every other item
            iterator.Step = 2;

            Console.WriteLine("Iterating over collection:");

            for (Item item = iterator.First();
                !iterator.IsDone;
                item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("First item: " + iterator.First().Name);
            Console.WriteLine("Last item: " + iterator.Last().Name);

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// A collection item
    /// </summary>
    class Item
    {
        public string Name { get; private set; }

        public Item(string name)
        {
            Name = name;
        }
    }

    ///// <summary>
    ///// The 'Aggregate' interface
    ///// </summary>
    //interface IAbstractCollection
    //{
    //    Iterator CreateIterator();
    //}

    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    class Collection // : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();

        //public Iterator CreateIterator()
        //{
        //    return new Iterator(this);
        //}

        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }

    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        Item Last();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }

    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _current = 0;

        // Constructor
        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        // Gets first item
        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }

        public Item Last()
        {
            _current = _collection.Count - 1;
            return _collection[_current] as Item;
        }

        // Gets next item
        public Item Next()
        {
            _current += Step;
            if (!IsDone)
                return _collection[_current] as Item;
            else
                return null;
        }

        // Gets or sets stepsize
        public int Step { get; set; } = 1;

        // Gets current iterator item
        public Item CurrentItem
        {
            get { return _collection[_current] as Item; }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }
    }
}
