using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_StorePacksPerksInfo : CSerializable {
		public uint id;
		public string name;
		public uint durationInSeconds;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.Serialize<uint>(id, name: "id");
			name = s.Serialize<string>(name, name: "name");
			durationInSeconds = s.Serialize<uint>(durationInSeconds, name: "durationInSeconds");
		}
	}
}

