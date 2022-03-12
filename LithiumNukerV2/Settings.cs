using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// All of the settings can be changed from here

namespace LithiumNukerV2
{
    public class Settings
    {
        public static bool Debug = false;
        
        public static readonly string Logo = @"
                  _dP                 9m_
               _#P                     9#_
               d#@                       9#m
              d##                         ###
             J###                         ###L               ___       ___  _________  ___  ___  ___  ___  ___  _____ ______
             {###K                       J###K              |\  \     |\  \|\___   ___\\  \|\  \|\  \|\  \|\  \|\   _ \  _   \
             ]####K      ___aaa___      J####F              \ \  \    \ \  \|___ \  \_\ \  \\\  \ \  \ \  \\\  \ \  \\\__\ \  \
         __gmM######_  w#P''   ''9#m  _d#####Mmw__           \ \  \    \ \  \   \ \  \ \ \   __  \ \  \ \  \\\  \ \  \\|__| \  \
      _g##############mZ_         __g##############m_         \ \  \____\ \  \   \ \  \ \ \  \ \  \ \  \ \  \\\  \ \  \    \ \  \
    _d####M@PPPP@@M#######Mmp gm#########@@PPP9@M####m_        \ \_______\ \__\   \ \__\ \ \__\ \__\ \__\ \_______\ \__\    \ \__\
   a###''          ,Z'#####@' '######'\g          ''M##m        \|_______|\|__|    \|__|  \|__|\|__|\|__|\|_______|\|__|     \|__|
 J#@'             0L  '*##     ##@'  J#              *#K
  #'               `#    '_gmwgm_~    dF               `#_         ::::    ::: :::    ::: :::    ::: :::::::::: :::::::::
 7F                 '#_   ]#####F   _dK                 JE         :+:+:   :+: :+:    :+: :+:   :+:  :+:        :+:    :+:
 ]                    *m__ ##### __g@'                   F         :+:+:+  +:+ +:+    +:+ +:+  +:+   +:+        +:+    +:+
                        'PJ#####LP'                                +#+ +:+ +#+ +#+    +:+ +#++:++    +#++:++#   +#++:++#:
  `                       0######_                      '          +#+  +#+#+# +#+    +#+ +#+  +#+   +#+        +#+    +#+
                        _0########_                                #+#   #+#+# #+#    #+# #+#   #+#  #+#        #+#    #+#
      .               _d#####^#####m__              ,              ###    ####  ########  ###    ### ########## ###    ###
      '*w_________am#####P'   ~9#####mw_________w*'
           ''9@#####@M''           ''P@#####@M'";
		   
        public static string Token;
        public static long? GuildId = null;
        public static int Threads = 40;
        public static int ConnectionLimit = 25; // 10 concurrent connections
        public static readonly string WebhookName = "Cold Wizzed U";
        public static readonly string AvatarUrl = "https://cdn.discordapp.com/avatars/719887748152033352/c48b63c83268091c792d46334ebc33e1.png?size=4096";
    }
}
