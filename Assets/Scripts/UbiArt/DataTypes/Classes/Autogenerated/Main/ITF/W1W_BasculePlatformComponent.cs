using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_BasculePlatformComponent : ActorComponent {
		public Angle Angle__0;
		public Angle Angle__1;
		public bool bool__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Angle__0 = s.SerializeObject<Angle>(Angle__0, name: "Angle__0");
			Angle__1 = s.SerializeObject<Angle>(Angle__1, name: "Angle__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
		}
		public override uint? ClassCRC => 0xA48AB748;
	}
}

