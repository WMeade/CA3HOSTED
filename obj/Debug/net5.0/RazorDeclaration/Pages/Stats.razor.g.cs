// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CA3A.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using CA3A;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using CA3A.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Stats.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Stats : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 305 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Stats.razor"
       

    public Stats playerStats;
    public String playerSearch;

    public async Task getstats()
    {
        try
        {
            playerStats = await Http.GetFromJsonAsync<Stats>(String.Format("https://lichess.org/api/user/{0}", playerSearch));
        }
        catch
        {
            playerStats = null;
        }

    }

    public int getHoursPlayed()
    {
        return playerStats.playTime.total / 60;
    }

    public string getHighestOrLowestRating(bool max)
    {
        Dictionary<string, int> ratings = new Dictionary<string, int>();
        ratings.Add("Classical", playerStats.perfs.classical.rating);
        ratings.Add("Rapid", playerStats.perfs.rapid.rating);
        ratings.Add("Blitz", playerStats.perfs.blitz.rating);
        ratings.Add("Bullet", playerStats.perfs.bullet.rating);
        ratings.Add("Anti-chess", playerStats.perfs.antichess.rating);
        ratings.Add("Atomic", playerStats.perfs.atomic.rating);
        ratings.Add("Crazyhouse", playerStats.perfs.crazyhouse.rating);
        ratings.Add("Kingofthehill", playerStats.perfs.kingOfTheHill.rating);
        ratings.Add("Puzzles", playerStats.perfs.puzzle.rating);

        var maxRating = 0;
        if (max)
        {
            maxRating = ratings.Values.Max();
        }
        else
        {
            maxRating = ratings.Values.Min();
        }

       
        var gameMode = ratings.FirstOrDefault(x => x.Value == maxRating).Key;

        return String.Format("{0}: {1}", gameMode, maxRating);
    }

    public string getHighestOrLowestPlayed(bool max)
    {
        Dictionary<string, int> ratings = new Dictionary<string, int>();
        ratings.Add("Classical", playerStats.perfs.classical.games);
        ratings.Add("Rapid", playerStats.perfs.rapid.games);
        ratings.Add("Blitz", playerStats.perfs.blitz.games);
        ratings.Add("Bullet", playerStats.perfs.bullet.games);
        ratings.Add("Anti-chess", playerStats.perfs.antichess.games);
        ratings.Add("Atomic", playerStats.perfs.atomic.games);
        ratings.Add("Crazyhouse", playerStats.perfs.crazyhouse.games);
        ratings.Add("Kingofthehill", playerStats.perfs.kingOfTheHill.games);
        ratings.Add("Puzzles", playerStats.perfs.puzzle.games);

        var maxRating = 0;
        if (max)
        {
            maxRating = ratings.Values.Max();
        }
        else
        {
            maxRating = ratings.Values.Min();
        }

       
        var gameMode = ratings.FirstOrDefault(x => x.Value == maxRating).Key;

        return String.Format("{0}: {1}", gameMode, maxRating);
    }


    public class Antichess
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
    }

    public class Atomic
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Blitz
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
    }

    public class KingOfTheHill
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Crazyhouse
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
    }

    public class Bullet
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Correspondence
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Horde
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Puzzle
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
    }

    public class Classical
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Rapid
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
    }

    public class Storm
    {
        public int runs { get; set; }
        public int score { get; set; }
    }

    public class Streak
    {
        public int runs { get; set; }
        public int score { get; set; }
    }

    public class Perfs
    {
        public Antichess antichess { get; set; }
        public Atomic atomic { get; set; }
        public Blitz blitz { get; set; }
        public KingOfTheHill kingOfTheHill { get; set; }
        public Crazyhouse crazyhouse { get; set; }
        public Bullet bullet { get; set; }
        public Correspondence correspondence { get; set; }
        public Horde horde { get; set; }
        public Puzzle puzzle { get; set; }
        public Classical classical { get; set; }
        public Rapid rapid { get; set; }
        public Storm storm { get; set; }
        public Streak streak { get; set; }
    }

    public class PlayTime
    {
        public int total { get; set; }
        public int tv { get; set; }
    }

    public class Count
    {
        public int all { get; set; }
        public int rated { get; set; }
        public int ai { get; set; }
        public int draw { get; set; }
        public int drawH { get; set; }
        public int loss { get; set; }
        public int lossH { get; set; }
        public int win { get; set; }
        public int winH { get; set; }
        public int bookmark { get; set; }
        public int playing { get; set; }
        public int import { get; set; }
        public int me { get; set; }
    }

    public class Stats
    {
        public string id { get; set; }
        public string username { get; set; }
        public Perfs perfs { get; set; }
        public long createdAt { get; set; }
        public bool online { get; set; }
        public long seenAt { get; set; }
        public PlayTime playTime { get; set; }
        public string url { get; set; }
        public Count count { get; set; }
        public bool followable { get; set; }
        public bool following { get; set; }
        public bool blocking { get; set; }
        public bool followsYou { get; set; }
    }






#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
