using System.Collections.Generic;
using System.Threading;

namespace TestTask.Models.Observer
{
    public class Subject : ISubject
    {
        public List<IObserver> Observers { get; private set; }
       
        public Subject()
        {
            Observers = new List<IObserver>();
            
        }
        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update();
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
        public void Go()
        {
            new Thread(new ThreadStart(Run)).Start();
        }
        void Run()
        {

            NotifyObservers();
        }
    }
}
