using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class UIMenuActionSound : CSerializable {
		[Serialize("action"   )] public StringID action;
		[Serialize("selection")] public StringID selection;
		[Serialize("sound"    )] public StringID sound;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(action));
			SerializeField(s, nameof(selection));
			SerializeField(s, nameof(sound));
		}
	}
}

