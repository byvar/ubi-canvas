using UnityEngine;

namespace UbiArt.ITF {
	public partial class TrajectoryNodeComponent_Template : ActorComponent_Template {
		[Serialize("useCurvedEnd")] public bool useCurvedEnd;
		[Serialize("useDrawDebug")] public bool useDrawDebug;
		[Serialize("name"        )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(useCurvedEnd));
				SerializeField(s, nameof(name));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(useCurvedEnd));
				SerializeField(s, nameof(name));
			} else {
				SerializeField(s, nameof(useCurvedEnd));
				SerializeField(s, nameof(useDrawDebug));
				SerializeField(s, nameof(name));
			}
		}
		public override uint? ClassCRC => 0x040C7328;
	}
}

