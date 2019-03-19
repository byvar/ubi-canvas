using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_ExplosionComponent_Template : ActorComponent_Template {
		[Serialize("fxName"  )] public StringID fxName;
		[Serialize("shape"   )] public Generic<PhysShape> shape;
		[Serialize("hitLevel")] public uint hitLevel;
		[Serialize("faction" )] public uint faction;
		[Serialize("sendStim")] public bool sendStim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fxName));
			SerializeField(s, nameof(shape));
			SerializeField(s, nameof(hitLevel));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(sendStim));
		}
		public override uint? ClassCRC => 0xDABFA0CE;
	}
}

