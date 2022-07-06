using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CorrectDemo
{
    
    public class Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();
    }
    
    public class Playlist
    {
        public Playlist()
        {
            this.Songs = new HashSet<Song>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlaylistId { get; set; } 
        public string Name { get; set; } = string.Empty;
        public ICollection<Song> Songs { get; set; } =  new HashSet<Song>();
    }
    
    public class Song
    {   
        public Song()
        {
           this.Playlists = new HashSet<Playlist>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SongId { get; set; }
        public string SongName { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public ICollection<Playlist> Playlists {get; set; }  = new HashSet<Playlist>();
    }
}
