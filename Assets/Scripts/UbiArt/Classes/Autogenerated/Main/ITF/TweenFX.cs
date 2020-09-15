using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class TweenFX : TweenInstruction {
		public ObjectPath target;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			target = s.SerializeObject<ObjectPath>(target, name: "target");
		}
		public override uint? ClassCRC => 0x4927CB67;
	}
}

