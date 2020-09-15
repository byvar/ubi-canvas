using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class TemplatePickable : TemplateObj {
		public bool WIP;
		public bool LOWUPDATE;
		public WorldUpdateLayer UPDATELAYER;
		public WorldUpdateLayer2 UPDATELAYER2;
		public bool USEVIEWFRUSTUMFLAG;
		public Angle ANGLE;
		public Vec2d SCALE;
		public uint ObjectFamily;
		public CList<string> TAGS;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				ANGLE = s.SerializeObject<Angle>(ANGLE, name: "ANGLE");
				SCALE = s.SerializeObject<Vec2d>(SCALE, name: "SCALE");
				ObjectFamily = s.Serialize<uint>(ObjectFamily, name: "ObjectFamily");
			} else if (Settings.s.game == Settings.Game.RL) {
				TAGS = s.SerializeObject<CList<string>>(TAGS, name: "TAGS");
				WIP = s.Serialize<bool>(WIP, name: "WIP", options: CSerializerObject.Options.BoolAsByte);
				LOWUPDATE = s.Serialize<bool>(LOWUPDATE, name: "LOWUPDATE", options: CSerializerObject.Options.BoolAsByte);
				UPDATELAYER = s.Serialize<WorldUpdateLayer>(UPDATELAYER, name: "UPDATELAYER");
			} else if (Settings.s.game == Settings.Game.COL) {
				TAGS = s.SerializeObject<CList<string>>(TAGS, name: "TAGS");
				WIP = s.Serialize<bool>(WIP, name: "WIP", options: CSerializerObject.Options.BoolAsByte);
				LOWUPDATE = s.Serialize<bool>(LOWUPDATE, name: "LOWUPDATE", options: CSerializerObject.Options.BoolAsByte);
				UPDATELAYER2 = s.Serialize<WorldUpdateLayer2>(UPDATELAYER2, name: "UPDATELAYER2");
			}  else {
				TAGS = s.SerializeObject<CList<string>>(TAGS, name: "TAGS");
				WIP = s.Serialize<bool>(WIP, name: "WIP");
				LOWUPDATE = s.Serialize<bool>(LOWUPDATE, name: "LOWUPDATE");
				UPDATELAYER = s.Serialize<WorldUpdateLayer>(UPDATELAYER, name: "UPDATELAYER");
				USEVIEWFRUSTUMFLAG = s.Serialize<bool>(USEVIEWFRUSTUMFLAG, name: "USEVIEWFRUSTUMFLAG");
			}
		}
		public enum WorldUpdateLayer {
			[Serialize("WorldUpdateLayer_Gameplay")] Gameplay = 0,
			[Serialize("WorldUpdateLayer_CutScene")] CutScene = 1,
			[Serialize("WorldUpdateLayer_Menu"    )] Menu = 2,
			[Serialize("WorldUpdateLayer_TRC"     )] TRC = 3,
		}
		public enum WorldUpdateLayer2 {
			[Serialize("WorldUpdateLayer_Gameplay")] Gameplay = 0,
			[Serialize("WorldUpdateLayer_CutScene")] CutScene = 1,
			[Serialize("WorldUpdateLayer_Menu"    )] Menu = 2,
			[Serialize("WorldUpdateLayer_TRC"     )] TRC = 5,
		}
		public override uint? ClassCRC => 0x7D85E599;
	}
}

