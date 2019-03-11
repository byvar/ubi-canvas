using UnityEngine;

namespace UbiArt.ITF {
	public partial class ScreenShotDataCostumeShowcase : online.OpenGraphObject {
		[Serialize("costumeName")] public string costumeName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(costumeName));
		}
		public override uint? ClassCRC => 0x16DA3177;
	}
}

