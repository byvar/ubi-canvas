using UnityEngine;

namespace UbiArt.online {
	public partial class gameGlobalsData : CSerializable {
		[Serialize("variables"  )] public string variables;
		[Serialize("KEY"        )] public StringID KEY;
		[Serialize("versionTime")] public online.DateTime versionTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(variables));
			SerializeField(s, nameof(KEY));
			SerializeField(s, nameof(versionTime));
		}
	}
}

