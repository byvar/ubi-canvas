using UnityEngine;

namespace UbiArt.ITF {
	public partial class Target : CSerializable {
		[Serialize("targets")] public CMap<StringID, Action> targets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(targets));
		}
	}
}

