using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_CostumeInfo_Template : CSerializable {
		public StringID playerIDInfo;
		public Path painting;
		public Color backgroundColor;
		public StringID levelDependency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playerIDInfo = s.SerializeObject<StringID>(playerIDInfo, name: "playerIDInfo");
			painting = s.SerializeObject<Path>(painting, name: "painting");
			backgroundColor = s.SerializeObject<Color>(backgroundColor, name: "backgroundColor");
			levelDependency = s.SerializeObject<StringID>(levelDependency, name: "levelDependency");
		}
	}
}

