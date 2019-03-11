using UnityEngine;

namespace UbiArt.ITF {
	public partial class TemplatePickable : TemplateObj {
		[Serialize("WIP"               )] public bool WIP;
		[Serialize("LOWUPDATE"         )] public bool LOWUPDATE;
		[Serialize("UPDATELAYER"       )] public WorldUpdateLayer UPDATELAYER;
		[Serialize("USEVIEWFRUSTUMFLAG")] public bool USEVIEWFRUSTUMFLAG;
		[Serialize("ANGLE"             )] public Angle ANGLE;
		[Serialize("SCALE"             )] public Vector2 SCALE;
		[Serialize("ObjectFamily"      )] public uint ObjectFamily;
		[Serialize("TAGS"              )] public Placeholder TAGS;
		[Serialize("UPDATELAYER"       )] public Enum_UPDATELAYER UPDATELAYER;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(ANGLE));
				SerializeField(s, nameof(SCALE));
				SerializeField(s, nameof(ObjectFamily));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(TAGS));
				SerializeField(s, nameof(WIP));
				SerializeField(s, nameof(LOWUPDATE));
				SerializeField(s, nameof(UPDATELAYER));
			} else {
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
		public enum Enum_UPDATELAYER {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x7D85E599;
	}
}

