using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITF {
    public class Settings {
        public enum Mode {
            RaymanLegendsPC, RaymanAdventuresIOS
        };
		public Mode mode = Mode.RaymanLegendsPC;

        public enum EngineVersion {
			None = -1,
            RL = 0
        };
        public enum Game { None, RL, RA };
        public enum Platform { None, PC, iOS, Android, WiiU };
        public enum Endian { Little, Big };

        public EngineVersion engineVersion;
        public Game game;
        public Platform platform;
        public Endian endian;

        public bool IsLittleEndian {
            get { return endian == Endian.Little; }
        }

        public static void Init(Mode mode) {
            switch (mode) {
                case Mode.RaymanLegendsPC: s = RLPC; break;
				case Mode.RaymanAdventuresIOS: s = RAIOS; break;
            }
            if (s != null) s.mode = mode;
        }


        public static Settings s = null;
		public static Settings RLPC = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RL,
			platform = Platform.PC,
			endian = Endian.Big
        };
		public static Settings RAIOS = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RA,
			platform = Platform.iOS,
			endian = Endian.Big
		};
    }
}