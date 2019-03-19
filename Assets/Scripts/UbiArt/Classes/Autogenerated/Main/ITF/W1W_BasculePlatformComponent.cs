using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_BasculePlatformComponent : ActorComponent {
		[Serialize("Angle__0")] public Angle Angle__0;
		[Serialize("Angle__1")] public Angle Angle__1;
		[Serialize("bool__2" )] public bool bool__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Angle__0));
			SerializeField(s, nameof(Angle__1));
			SerializeField(s, nameof(bool__2));
		}
		public override uint? ClassCRC => 0xA48AB748;
	}
}

