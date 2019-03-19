using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_Map_CheckType : RLC_Mission_Guard {
		[Serialize("mapType")] public uint mapType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(mapType));
		}
		public override uint? ClassCRC => 0xCF8C03CE;
	}
}

