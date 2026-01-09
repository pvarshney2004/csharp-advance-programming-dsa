using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    /*
     Scenario 2: Music Playlist Queue
Use Case: A music player plays songs one after another and can dynamically add/remove
songs.
Why LinkedList? Dynamic addition/removal from both ends.
OOP Concepts:
● Encapsulation: Playlist data is secured.
● Abstraction: Methods like playNext(), addSong() simplify usage.
● Polymorphism: If we extend MediaPlayer, it could play videos, podcasts, etc.
     */
    // Song Node class
    class Song
    {
        public string SongTitle;
        public Song Next;
        public Song(string songTitle)
        {
            SongTitle = songTitle;
            Next = null;
        }
    }   
    // abstract class MediaPlayer
    abstract class MediaPlayer
    {
        protected Song head;
        protected Song tail;
        public abstract void PlayNext();
        
        public void AddSong(string title)
        {
            Song newSong = new Song(title);
            if (head == null)
            {
                head = tail = newSong;
                
            }
            else
            {
                tail.Next = newSong;
                tail = newSong;
            }
            Console.WriteLine("New Song added: " + title);
        }

        public void GetCurrentSong()
        {
            Console.WriteLine("Currently Playing: " + head.SongTitle);
        }
    }
    // Subclass musicplayer
    class MusicPlayer : MediaPlayer
    {
        public override void PlayNext()
        {
            if (head.Next == null)
            {
                Console.WriteLine("No more song available");
                return;
            }
            else
            {
                head = head.Next;
                Console.WriteLine("Now playing: "+ head.SongTitle);
            }
        }
    }
}
