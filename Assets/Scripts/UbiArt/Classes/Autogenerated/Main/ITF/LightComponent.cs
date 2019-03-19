using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class LightComponent : ActorComponent {
		[Serialize("useOnActor")] public int useOnActor;
		[Serialize("useOnFrize")] public int useOnFrize;
		[Serialize("useBV"     )] public int useBV;
		[Serialize("alpha"     )] public float alpha;
		[Serialize("red"       )] public float red;
		[Serialize("green"     )] public float green;
		[Serialize("blue"      )] public float blue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(useOnActor));
				SerializeField(s, nameof(useOnFrize));
				SerializeField(s, nameof(useBV));
				SerializeField(s, nameof(alpha));
				SerializeField(s, nameof(red));
				SerializeField(s, nameof(green));
				SerializeField(s, nameof(blue));
			}
		}
		public override uint? ClassCRC => 0x89DA5668;
	}
}

