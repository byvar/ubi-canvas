using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class ZAction : CSerializable {
		[Serialize("name"    )] public StringID name;
		[Serialize("inverted")] public bool inverted;
		[Serialize("scale"   )] public float scale;
		[Serialize("input"   )] public CList<ZInput> input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(inverted));
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(input));
		}
	}
}

