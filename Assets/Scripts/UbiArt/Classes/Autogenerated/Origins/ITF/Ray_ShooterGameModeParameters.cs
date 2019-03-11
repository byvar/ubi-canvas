using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ShooterGameModeParameters : CSerializable {
		[Serialize("playersDataList")] public Placeholder playersDataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playersDataList));
		}
		public override uint? ClassCRC => 0x63E0A1F7;
	}
}

