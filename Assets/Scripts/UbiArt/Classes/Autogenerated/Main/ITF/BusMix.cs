using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RL | GameFlags.COL)]
	public partial class BusMix : CSerializable {
		[Serialize("name"    )] public StringID name;
		[Serialize("priority")] public uint priority;
		[Serialize("duration")] public float duration;
		[Serialize("fadeIn"  )] public float fadeIn;
		[Serialize("fadeOut" )] public float fadeOut;
		[Serialize("busDefs" )] public CList<BusDef> busDefs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(priority));
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(fadeIn));
				SerializeField(s, nameof(fadeOut));
				SerializeField(s, nameof(busDefs));
			} else {
				SerializeField(s, nameof(priority));
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(fadeIn));
				SerializeField(s, nameof(fadeOut));
				SerializeField(s, nameof(busDefs));
			}
		}
	}
}

