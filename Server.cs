using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using AltV.Net.ColoredConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dampfstube.MyPlayer;
using System.Globalization;

namespace Dampfstube
{
    class Server : Resource
    {
        public override void OnStart()
        {
            Alt.LogWarning("<< Server gestartet >>");
            Utils.startstopLog("**Start: **" + (DateTime.Now.ToString("g") + " Uhr - Server gestartet!"), "Server");
            //SQL
            Datenbank.InitConnection();


        }

        public override void OnStop()
        {
            Alt.LogError(">> Server gestoppt! <<");
           // Utils.startstopLog("**Stop: **" + (DateTime.Now.ToString("dd MMM yyyy hh:mm g") + " Uhr - Server gestoppt!"), "Admin");
        }

        public override IEntityFactory<IPlayer> GetPlayerFactory()
        {
            return new MyPlayerFactory();
        }

        



    }
}
