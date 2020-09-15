using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class TemplatePickable : TemplateObj {
		[Serialize("WIP"               )] public bool WIP;
		[Serialize("LOWUPDATE"         )] public bool LOWUPDATE;
		[Serialize("UPDATELAYER"       )] public WorldUpdateLayer UPDATELAYER;
		[Serialize("UPDATELAYER"       )] public WorldUpdateLayer2 UPDATELAYER2;
		[Serialize("USEVIEWFRUSTUMFLAG")] public bool USEVIEWFRUSTUMFLAG;
		[Serialize("ANGLE"             )] public Angle ANGLE;
		[Serialize("SCALE"             )] public Vec2d SCALE;
		[Serialize("ObjectFamily"      )] public uint ObjectFamily;
		[Serialize("TAGS"              )] public CList<string> TAGS;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(ANGLE));
				SerializeField(s, nameof(SCALE));
				SerializeField(s, nameof(ObjectFamily));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(TAGS));
				SerializeField(s, nameof(WIP), boolAsByte: true);
				SerializeField(s, nameof(LOWUPDATE), boolAsByte: true);
				SerializeField(s, nameof(UPDATELAYER));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(TAGS));
				SerializeField(s, nameof(WIP), boolAsByte: true);
				SerializeField(s, nameof(LOWUPDATE), boolAsByte: true);
				SerializeField(s, nameof(UPDATELAYER2));
			}  else {
				SerializeField(s, nameof(TAGS));
				SerializeField(s, nameof(WIP));
				SerializeField(s, nameof(LOWUPDATE));
				SerializeField(s, nameof(UPDATELAYER));
				SerializeField(s, nameof(USEVIEWFRUSTUMFLAG));
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

