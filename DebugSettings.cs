﻿using System;

namespace RocksmithScrobbler.Configuration {
    [Serializable]
    public class DebugSettings {
        public bool debugStateMachine = false;
        public bool debugSongDetails = false;
        public bool debugCache = false;
        public bool debugMemoryReadout = false;
        public bool debugSystemHandleQuery = false;
        public bool debugFileDetailQuery = false;
    }
}