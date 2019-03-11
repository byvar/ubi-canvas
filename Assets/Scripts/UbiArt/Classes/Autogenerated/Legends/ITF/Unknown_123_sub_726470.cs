using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_123_sub_726470 : CSerializable {
		[Serialize("disableWindForce")] public Placeholder disableWindForce;
		[Serialize("disableWindForce")] public bool disableWindForce;
		[Serialize("startWithHalo"   )] public bool startWithHalo;
		[Serialize("startWithHalo"   )] public Placeholder startWithHalo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(disableWindForce));
				SerializeField(s, nameof(disableWindForce));
				SerializeField(s, nameof(startWithHalo));
			}
			SerializeField(s, nameof(startWithHalo));
		}
		public override uint? ClassCRC => 0x389D417B;
	}
}

