using System;

namespace HCGames.ObserverSystem{
    public interface IObserverService{
        void Subscribe(string eventId, Action handler);
        void Unsubscribe(string eventId, Action handler);
        void Notify(string eventId);

        void Subscribe<T>(string eventId, Action<T> handler);
        void Unsubscribe<T>(string eventId, Action<T> handler);
        void Notify<T>(string eventId, T parameter);

        void Subscribe<T1, T2>(string eventId, Action<T1, T2> handler);
        void Unsubscribe<T1, T2>(string eventId, Action<T1, T2> handler);
        void Notify<T1, T2>(string eventId, T1 parameter1, T2 parameter2);

        void Subscribe<T1, T2, T3>(string eventId, Action<T1, T2, T3> handler);
        void Unsubscribe<T1, T2, T3>(string eventId, Action<T1, T2, T3> handler);
        void Notify<T1, T2, T3>(string eventId, T1 parameter1, T2 parameter2, T3 parameter3);

        void Subscribe<T1, T2, T3, T4>(string eventId, Action<T1, T2, T3, T4> handler);
        void Unsubscribe<T1, T2, T3, T4>(string eventId, Action<T1, T2, T3, T4> handler);
        void Notify<T1, T2, T3, T4>(string eventId, T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4);

        void Subscribe<T1, T2, T3, T4, T5>(string eventId, Action<T1, T2, T3, T4, T5> handler);
        void Unsubscribe<T1, T2, T3, T4, T5>(string eventId, Action<T1, T2, T3, T4, T5> handler);
        void Notify<T1, T2, T3, T4, T5>(string eventId, T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5);

        void Subscribe<T1, T2, T3, T4, T5, T6>(string eventId, Action<T1, T2, T3, T4, T5, T6> handler);
        void Unsubscribe<T1, T2, T3, T4, T5, T6>(string eventId, Action<T1, T2, T3, T4, T5, T6> handler);
        void Notify<T1, T2, T3, T4, T5, T6>(string eventId, T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5, T6 parameter6);

        void Subscribe<T1, T2, T3, T4, T5, T6, T7>(string eventId, Action<T1, T2, T3, T4, T5, T6, T7> handler);
        void Unsubscribe<T1, T2, T3, T4, T5, T6, T7>(string eventId, Action<T1, T2, T3, T4, T5, T6, T7> handler);
        void Notify<T1, T2, T3, T4, T5, T6, T7>(string eventId, T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4, T5 parameter5, T6 parameter6, T7 parameter7);

        void ClearHandlers(string eventId);
        void ClearAllHandlers();
    }
}
