using UnityEngine;

namespace UbiArt.ITF {
	public partial class ScreenShotDataFamilyReunited : online.OpenGraphObject {
		[Serialize("family_name")] public string family_name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(family_name));
		}
		public override uint? ClassCRC => 0x0CE17554;
	}
}

