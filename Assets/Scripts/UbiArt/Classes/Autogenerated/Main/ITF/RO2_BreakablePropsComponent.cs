using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BreakablePropsComponent : ActorComponent {
		[Serialize("lumsGiven"     )] public uint lumsGiven;
		[Serialize("needActivation")] public bool needActivation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lumsGiven));
			SerializeField(s, nameof(needActivation));
		}
		public override uint? ClassCRC => 0x72C8CA61;
	}
}

