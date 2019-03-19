using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_134_sub_726470 : CSerializable {
		[Serialize("disableWindForce")] public bool disableWindForce;
		[Serialize("startWithHalo"   )] public int startWithHalo;
		[Serialize("startWithHalo"   )] public byte startWithHalo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(disableWindForce), boolAsByte: true);
				SerializeField(s, nameof(startWithHalo));
			}
			SerializeField(s, nameof(startWithHalo));
		}
		public override uint? ClassCRC => 0x389D417B;
	}
}

