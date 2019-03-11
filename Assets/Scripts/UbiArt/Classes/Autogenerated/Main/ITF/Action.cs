using UnityEngine;

namespace UbiArt.ITF {
	public partial class Action : CSerializable {
		[Serialize("actions")] public CMap<StringID, FXControl> actions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actions));
		}
	}
}

