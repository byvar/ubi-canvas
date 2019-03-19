using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class IManager : CSerializable {
		[Serialize("ConfigPath")] public Path ConfigPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ConfigPath));
		}
		public override uint? ClassCRC => 0xAC97A187;
	}
}

