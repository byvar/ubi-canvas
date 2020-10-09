using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class TweenFX : TweenInstruction {
		public ObjectPath target;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			target = s.SerializeObject<ObjectPath>(target, name: "target");
		}
		public override uint? ClassCRC => 0x4927CB67;
	}
}

