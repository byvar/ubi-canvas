using UnityEngine;

namespace UbiArt.online {
	public partial class DeviceUIDInfo : CSerializable {
		[Serialize("uid"         )] public string uid;
		[Serialize("mdl"         )] public string mdl;
		[Serialize("lastuse"     )] public string lastuse;
		[Serialize("token"       )] public string token;
		[Serialize("federated_id")] public string federated_id;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uid));
			SerializeField(s, nameof(mdl));
			SerializeField(s, nameof(lastuse));
			SerializeField(s, nameof(token));
			SerializeField(s, nameof(federated_id));
		}
	}
}

