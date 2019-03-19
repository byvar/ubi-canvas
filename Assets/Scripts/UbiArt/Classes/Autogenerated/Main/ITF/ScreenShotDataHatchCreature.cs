using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ScreenShotDataHatchCreature : online.OpenGraphObject {
		[Serialize("creature_name")] public string creature_name;
		[Serialize("family_name"  )] public string family_name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(creature_name));
			SerializeField(s, nameof(family_name));
		}
		public override uint? ClassCRC => 0x6295C980;
	}
}

