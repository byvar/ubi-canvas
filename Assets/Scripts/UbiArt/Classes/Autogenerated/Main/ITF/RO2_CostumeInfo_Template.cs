using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_CostumeInfo_Template : CSerializable {
		[Serialize("playerIDInfo"   )] public StringID playerIDInfo;
		[Serialize("painting"       )] public Path painting;
		[Serialize("backgroundColor")] public Color backgroundColor;
		[Serialize("levelDependency")] public StringID levelDependency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playerIDInfo));
			SerializeField(s, nameof(painting));
			SerializeField(s, nameof(backgroundColor));
			SerializeField(s, nameof(levelDependency));
		}
	}
}

