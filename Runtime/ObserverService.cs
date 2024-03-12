using System;
using System.Collections.Generic;
using HCGames.Extensions;

namespace HCGames.ObserverSystem{

    public class ObserverService : Singleton<ObserverService> ,IObserverService{
        private readonly Dictionary<string, Delegate> _observers = new();

        //No parameters
        public void Subscribe(string eventId, Action handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,0);
                _observers[eventId] = Delegate.Combine(observer, handler);
            }
            else{
                _observers.Add(eventId, handler);
            }
        }

        public void Unsubscribe(string eventId, Action handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,1);
                _observers[eventId] = Delegate.Remove(observer, handler);
                if (_observers[eventId] == null){
                    _observers.Remove(eventId);
                }
            }
        }

        public void Notify(string eventId){
            if (_observers.TryGetValue(eventId, out var observer)){
                ((Action)observer).Invoke();
            }
        }

        //One Parameter
        public void Subscribe<T>(string eventId, Action<T> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,0);
                _observers[eventId] = Delegate.Combine(observer, handler);
            }
            else{
                _observers.Add(eventId, handler);
            }
        }

        public void Unsubscribe<T>(string eventId, Action<T> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,1);
                _observers[eventId] = Delegate.Remove(observer, handler);
                if (_observers[eventId] == null){
                    _observers.Remove(eventId);
                }
            }
        }

        public void Notify<T>(string eventId, T parameter){
            if (_observers.TryGetValue(eventId, out var observer)){
                ((Action<T>)observer).Invoke(parameter);
            }
        }

        // Two parameters
        public void Subscribe<T1, T2>(string eventId, Action<T1, T2> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,0);
                _observers[eventId] = Delegate.Combine(observer, handler);
            }
            else{
                _observers.Add(eventId, handler);
            }
        }

        public void Unsubscribe<T1, T2>(string eventId, Action<T1, T2> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,1);
                _observers[eventId] = Delegate.Remove(observer, handler);
                if (_observers[eventId] == null){
                    _observers.Remove(eventId);
                }
            }
        }

        public void Notify<T1, T2>(string eventId, T1 parameter1, T2 parameter2){
            if (_observers.TryGetValue(eventId, out var observer)){
                ((Action<T1, T2>)observer).Invoke(parameter1, parameter2);
            }
        }

        // Three parameters
        public void Subscribe<T1, T2, T3>(string eventId, Action<T1, T2, T3> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,0);
                _observers[eventId] = Delegate.Combine(observer, handler);
            }
            else{
                _observers.Add(eventId, handler);
            }
        }

        public void Unsubscribe<T1, T2, T3>(string eventId, Action<T1, T2, T3> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,1);
                _observers[eventId] = Delegate.Remove(observer, handler);
                if (_observers[eventId] == null){
                    _observers.Remove(eventId);
                }
            }
        }

        public void Notify<T1, T2, T3>(string eventId, T1 parameter1, T2 parameter2, T3 parameter3){
            if (_observers.TryGetValue(eventId, out var observer)){
                ((Action<T1, T2, T3>)observer).Invoke(parameter1, parameter2, parameter3);
            }
        }

        // Four parameters
        public void Subscribe<T1, T2, T3, T4>(string eventId, Action<T1, T2, T3, T4> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,0);
                _observers[eventId] = Delegate.Combine(observer, handler);
            }
            else{
                _observers.Add(eventId, handler);
            }
        }

        public void Unsubscribe<T1, T2, T3, T4>(string eventId, Action<T1, T2, T3, T4> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,1);
                _observers[eventId] = Delegate.Remove(observer, handler);
                if (_observers[eventId] == null){
                    _observers.Remove(eventId);
                }
            }
        }

        public void Notify<T1, T2, T3, T4>(string eventId, T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4){
            if (_observers.TryGetValue(eventId, out var observer)){
                ((Action<T1, T2, T3, T4>)observer).Invoke(parameter1, parameter2, parameter3, parameter4);
            }
        }

        // Five parameters
        public void Subscribe<T1, T2, T3, T4, T5>(string eventId, Action<T1, T2, T3, T4, T5> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,0);
                _observers[eventId] = Delegate.Combine(observer, handler);
            }
            else{
                _observers.Add(eventId, handler);
            }
        }

        public void Unsubscribe<T1, T2, T3, T4, T5>(string eventId, Action<T1, T2, T3, T4, T5> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,1);
                _observers[eventId] = Delegate.Remove(observer, handler);
                if (_observers[eventId] == null){
                    _observers.Remove(eventId);
                }
            }
        }

        public void Notify<T1, T2, T3, T4, T5>(string eventId, T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5){
            if (_observers.TryGetValue(eventId, out var observer)){
                ((Action<T1, T2, T3, T4, T5>)observer).Invoke(parameter1, parameter2, parameter3, parameter4, parameter5);
            }
        }

        // Six parameters
        public void Subscribe<T1, T2, T3, T4, T5, T6>(string eventId, Action<T1, T2, T3, T4, T5, T6> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,0);
                _observers[eventId] = Delegate.Combine(observer, handler);
            }
            else{
                _observers.Add(eventId, handler);
            }
        }

        public void Unsubscribe<T1, T2, T3, T4, T5, T6>(string eventId, Action<T1, T2, T3, T4, T5, T6> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,1);
                _observers[eventId] = Delegate.Remove(observer, handler);
                if (_observers[eventId] == null){
                    _observers.Remove(eventId);
                }
            }
        }

        public void Notify<T1, T2, T3, T4, T5, T6>(string eventId, T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5, T6 parameter6){
            if (_observers.TryGetValue(eventId, out var observer)){
                ((Action<T1, T2, T3, T4, T5, T6>)observer).Invoke(parameter1, parameter2, parameter3, parameter4, parameter5, parameter6);
            }
        }

        // Seven parameters
        public void Subscribe<T1, T2, T3, T4, T5, T6, T7>(string eventId, Action<T1, T2, T3, T4, T5, T6, T7> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,0);
                _observers[eventId] = Delegate.Combine(observer, handler);
            }
            else{
                _observers.Add(eventId, handler);
            }
        }

        public void Unsubscribe<T1, T2, T3, T4, T5, T6, T7>(string eventId, Action<T1, T2, T3, T4, T5, T6, T7> handler){
            if (_observers.TryGetValue(eventId, out var observer)){
                CheckTypes(observer,handler,eventId,1);
                _observers[eventId] = Delegate.Remove(observer, handler);
                if (_observers[eventId] == null){
                    _observers.Remove(eventId);
                }
            }
        }

        public void Notify<T1, T2, T3, T4, T5, T6, T7>(string eventId, T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5, T6 parameter6, T7 parameter7){
            if (_observers.TryGetValue(eventId, out var observer)){
                ((Action<T1, T2, T3, T4, T5, T6, T7>)observer).Invoke(parameter1, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7);
            }
        }
        
        public void ClearHandlers(string eventId){
            if (!_observers.ContainsKey(eventId)) return;
            _observers.Remove(eventId);
        }

        public void ClearAllHandlers(){
            _observers.Clear();
        }

        private void CheckTypes(Delegate observer,Delegate handler,string eventId,int type){
            if (observer.GetType() == handler.GetType()) return;
            var typeStr = type switch{
                0 => "subscribing for",
                1 => "unsubscribing from",
                2 => "notifying",
                _ => ""
            };
            throw new ArgumentException($"Incompatible delegate types when {typeStr} {eventId}. Existing is {observer.GetType()}, new handler is {handler.GetType()}");
        }

    }
}
