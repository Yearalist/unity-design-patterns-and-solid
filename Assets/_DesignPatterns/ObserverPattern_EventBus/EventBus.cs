// Event Bus - Central hub for all game events

// Radyonun frekansýný deðiþtirmek gibi, oyun içi olaylarý yayýnlamak ve dinlemek için kullanýlan bir sistemdir. Olaylar, string anahtarlarýyla tanýmlanýr ve dinleyiciler bu anahtarlarla abone olabilirler. Olay yayýnlandýðýnda, tüm ilgili dinleyiciler tetiklenir. Bu, oyun içi iletiþimi basitleþtirir ve kodun daha modüler olmasýný saðlar.

using System;
using System.Collections.Generic;
using UnityEngine;

public static class EventBus 
{

    private static Dictionary<string, Action> events = new Dictionary<string, Action>();

    public static void Subscribe(string eventName, Action listener)// Radyoyu açýp frekansa ayarlanmak. "Bu olayý dinlemek istiyorum" demek.
    {
        if (events.ContainsKey(eventName))
        {
            events[eventName] += listener;
        }
        else
        {
            events[eventName] = listener;
        }
        Debug.Log($"[EventBus] Subscribed to: {eventName}");
    }

    public static void Unsubscribe(string eventName, Action listener)// Dinleyiciyi çýkar. Taksici radyoyu kapattý, artýk duymuyor. Ama diðer dinleyiciler etkilenmiyor.
    {
        if (events.ContainsKey(eventName))
        {
            events[eventName] -= listener;
            Debug.Log($"[EventBus] Unsubscribed from: {eventName}");
        }
    }
    public static void Publish(string eventName)//Radyo istasyonu haber yayýnlýyor. "Düþman öldü!" diye baðýrýyor. Kim dinliyorsa harekete geçiyor.
    {
        if (events.ContainsKey(eventName))
        {
            events[eventName]?.Invoke();//Bu frekansa abone olan tüm dinleyicilerin metodlarýný çaðýr. ?. ile null kontrolü yapýyoruz, kimse dinlemiyorsa hata vermez.
            Debug.Log($"[EventBus] Published: {eventName}");
        }
        else
        {
            Debug.Log($"[EventBus] Published: {eventName} (no listeners)");
        }
    }


}
