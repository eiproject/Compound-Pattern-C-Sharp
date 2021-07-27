﻿using System.Collections; 

namespace CompoundPattern.Models {
  class QuackObserver : IQuackObserver {
    ArrayList _allObservers;
    IQuackObserver _animal;
    internal QuackObserver(IQuackObserver animal) {
      _allObservers = new ArrayList();
      _animal = animal;
    }

    void IQuackObserver.RegisterObserver(IObserver observer) {
      _allObservers.Add(observer);
    }

    void IQuackObserver.NotifyObservers() {
      foreach (IObserver observer in _allObservers) {
        observer.Update(_animal);
      }
    }
  }
}
