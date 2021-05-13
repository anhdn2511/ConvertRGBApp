using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConvertRGBApp
{
    public interface ISubject
    {
        void attach(Observer observer);
        void detach(Observer observer);
        void notify(System.Drawing.Color c);

    }
    public class Subject : ISubject
    {
        public List<Observer> observersList;
        public Subject() {
            observersList = new List<Observer>();
        }   
        public void attach(Observer observer)
        {
            if (!observersList.Contains(observer)) observersList.Add(observer);
        }
        public void detach(Observer observer)
        {
            if (observersList.Contains(observer)) observersList.Remove(observer);
        }
        public void notify(System.Drawing.Color c)
        {
            foreach(var obs in observersList)
            {
                obs.update(c);
            }
        }
    }
}
