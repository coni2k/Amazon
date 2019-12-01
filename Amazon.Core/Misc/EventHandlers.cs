using System;

namespace Amazon.Core.Misc.EventHandler
{
    public class Main
    {
        public static void Run()
        {
            var raiser = new EventRaiser();

            new EventListener(raiser);

            raiser.Name = "alpha";
            raiser.Name = "beta";

            Console.WriteLine("-");
            Console.ReadKey();
        }
    }

    public class EventRaiser
    {
        public delegate void NameChangedEventHandler(object sender, string name);
        public event NameChangedEventHandler NameChanged;

        public int Id { get; set; }
        public string Name {
            get { return _Name; }
            set
            {
                if (_Name == value)
                {
                    return;
                }

                _Name = value;

                NameChanged?.Invoke(this, value);
            }
        }

        private string _Name;
    }

    public class EventListener
    {
        public EventListener(EventRaiser raiser)
        {
            raiser.NameChanged += Raiser_NameChanged;
        }

        private void Raiser_NameChanged(object sender, string name)
        {
            Console.WriteLine($"Raiser - Name changed - New name: {name}");
        }
    }
}
