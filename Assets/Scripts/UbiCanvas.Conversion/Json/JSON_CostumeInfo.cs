using Newtonsoft.Json;
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
		public uint DescriptionID { get; set; } // LocID

		public string Family { get; set; } // Rayman, Globox, Teensy, Barbara are the options

		public string ScoreHudID { get; set; } // world/common/ui/common/playerscore/scorehud_{ScoreHudID}.act
		public string MoskitoID { get; set; } // world/common/shooter/playablecharacter/shootermoskito{MoskitoFamily}/shootermoskito{MoskitoID}.act
		public string DuckID { get; set; } // world/common/shooter/playablecharacter/duck/duck_{DuckID.ToLowerInvariant()}.act

		[JsonIgnore]
		public string ActorPath_Main { get; set; }
		[JsonIgnore]
		public string ActorPath_ScoreHUD { get; set; }
		[JsonIgnore]
		public string ActorPath_Moskito { get; set; }
		[JsonIgnore]
		public string ActorPath_Duck { get; set; }
		[JsonIgnore]
		public string ActorPath_Painting { get; set; } // .act for the painting (world/home/actor/costumes/costume*.act)
		[JsonIgnore]
		public string TemplatePath_Painting { get; set; } // .tpl for the painting (world/home/actor/costumes/components/costume*.tpl)
		[JsonIgnore]
		public string TemplatePath_Trail { get; set; } // .tpl for the actor's teleport trail (world/common/fx/actors/trails/teleporttrail_*.tpl)

		public string IconPath { get; set; }
		public Vec2d IconSize { get; set; }
		public JSON_Color DeathBubbleColor { get; set; }
		public JSON_Color TrailColor { get; set; }

		public RO2_CostumeDescriptor_Template.CostumeType2 CostumeType { get; set; }

		public string SubSkeleton { get; set; }
		public JSON_DuckType DuckType { get; set; }
		public float? Scale { get; set; }
		//public string SkeletonPath { get; set; }

		public Dictionary<string, JSON_TextureBank> TextureBanks { get; set; }

		public JSON_CostumePainting Painting { get; set; }

		public JSON_LockData Lock { get; set; }

		public class JSON_TextureBank {
			public string PBK { get; set; }
			public string Diffuse { get; set; }
			public string Backlight { get; set; }

			[JsonIgnore]
			public TextureBankPath GameBank { get; set; }
			[JsonIgnore]
			public string ID { get; set; }
		}

		public class JSON_CostumePainting {
			public string Animation { get; set; } // world/common/playablecharacter/{Family.ToLower}/animation/{Animation}.anm
			public JSON_Color BackgroundColor { get; set; }
			public string LevelDependency { get; set; } // Unlock only after certain level is completed
			public int Priority { get; set; }
			public bool Unlockable { get; set; }
		}

		public enum JSON_DuckType : int {
			Normal = 0,
			Naked = 1
		}
	}
}
