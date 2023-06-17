using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_CostumeInfo { // CostumeDescriptor in home.isc
		public string CostumeID { get; set; }
		public uint NameID { get; set; } // LocID
		public string Family { get; set; } // Rayman, Globox, Teensy, Barbara are the options
		public string ActorPath_Main { get; set; }
		public string ActorPath_ScoreHUD { get; set; }
		public string ActorPath_Moskito { get; set; }
		public string ActorPath_Duck { get; set; }
		public string IconPath { get; set; }
		public Vec2d IconSize { get; set; }
		public UbiArt.Color DeathBubbleColor { get; set; }

		// Painting data
		public string PaintingActorPath { get; set; } // .act for the painting (world/home/actor/costumes/costume*.act)
		public UbiArt.Color PaintingBackgroundColor { get; set; }
		public string PaintingLevelDependency { get; set; } // Unlock only after certain level is completed
		public string DecorationBrickPath { get; set; } // Painting isc (only one exists for each of rayman, globox, teensy, barbara)
		public int Priority { get; set; }
		public RO2_CostumeDescriptor_Template.CostumeType2 CostumeType { get; set; }
		public bool Unlockable { get; set; }

		public JSON_LockData Lock { get; set; }

		public JSON_CostumeMain Main { get; set; }


		public class JSON_CostumeMain {
			public string TeleportTrail { get; set; }
			public string PBKPath { get; set; }
			public string DiffusePath { get; set; }
			public string BacklightPath { get; set; }
			public string SubSkeleton { get; set; }
		}
	}
}
