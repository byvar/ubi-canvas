using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_HomeNodeProfile : CSerializable {
		public string name;
		public Path nodePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.Serialize<string>(name, name: "name");
			nodePath = s.SerializeObject<Path>(nodePath, name: "nodePath");
		}
		public override uint? ClassCRC => 0xD13ADFA4;
	}
}

