using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_HomeNodeProfile : CSerializable {
		[Serialize("name"    )] public string name;
		[Serialize("nodePath")] public Path nodePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(nodePath));
		}
		public override uint? ClassCRC => 0xD13ADFA4;
	}
}

