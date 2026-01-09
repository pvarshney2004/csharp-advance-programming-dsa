using Advance_Programming_DSA.Linked_List;
using System;
namespace Linked_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            // Example usage of BrowserHistory and NavigationSystem
            NavigationSystem obj = new BrowserHistory();
            obj.Visit("www.example.com");
            obj.Visit("www.google.com");
            obj.Visit("www.github.com");
            obj.Back();
            obj.Back();
            obj.Back();
            obj.Forward();
            */

            // Implementation of playlist queue
            //MediaPlayer obj2 = new MusicPlayer();
            //obj2.AddSong("song-1");
            //obj2.AddSong("song-2");
            //obj2.AddSong("song-3");
            //obj2.AddSong("song-4");
            //obj2.GetCurrentSong();
            //obj2.PlayNext();

            //SupportQueue sq = new SupportQueue();
            //sq.AddRequestInQueue(new CallRequest());
            //sq.AddRequestInQueue(new ChatRequest());
            //sq.AddRequestInQueue(new EmailRequest());
            //sq.CallNextRequest();
            //sq.CallNextRequest();
            //sq.CallNextRequest();
            //sq.CallNextRequest();

            //NotificationSystem sys = new NotificationSystem();
            //sys.AddNotification(new SMSNotification());
            //sys.AddNotification(new OTPNotification());
            //sys.AddNotification(new NewsNotification());
            //sys.SendAll();

            //UndoRedoManager urm = new UndoRedoManager();
            //urm.Do(new WriteCommand());
            //urm.Do(new DeleteCommand());
            //urm.Undo();
            //urm.Undo();
            //urm.Redo();

            //SocialMediaFeed feed = new SocialMediaFeed();
            //feed.AddNotification(new LikeNotification());
            //feed.AddNotification(new CommentNotification());
            //feed.AddNotification(new LikeNotification());
            //feed.Displayfeed();

            //CallCenterQueue cq = new CallCenterQueue();
            //cq.AddSupportTicket(new CallTicket());
            //cq.AddSupportTicket(new ChatTicket());
            //cq.AddSupportTicket(new EmailTicket());
            //cq.RemoveSupportTicket();
            //cq.RemoveSupportTicket();
            //cq.RemoveSupportTicket();
            //cq.RemoveSupportTicket();

            TrainRouteSystem sys = new TrainRouteSystem();
            sys.AddStationAtLast("delhi");
            sys.AddStationAtLast("agra");
            sys.AddStationAtLast("mathura");
            sys.AddStationAtBeginning("Hathras");
            sys.DisplayRoute();
            sys.RemoveStation("agra");
            sys.DisplayRoute();

            TrainRouteSystem sys2 = new ExpressTrainRoute();
            sys2.AddStationAtLast("delhi");
            sys2.AddStationAtLast("agra");
            sys2.AddStationAtLast("mathura");
            sys2.AddStationAtBeginning("Hathras");
            sys2.AddStationAtBeginning("Aligarh");
            sys2.DisplayRoute();
        }
    }
}