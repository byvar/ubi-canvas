using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_StorePacksPerksInfo : CSerializable {
		[Serialize("id")] public uint id;
		[Serialize("name")] public string name;
		[Serialize("durationInSeconds")] public uint durationInSeconds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(durationInSeconds));
		}
	}
}

