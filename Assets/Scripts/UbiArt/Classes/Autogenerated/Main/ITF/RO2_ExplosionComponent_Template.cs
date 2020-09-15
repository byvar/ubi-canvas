using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_ExplosionComponent_Template : ActorComponent_Template {
		public StringID fxName;
		public Generic<PhysShape> shape;
		public uint hitLevel;
		public uint faction;
		public bool sendStim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fxName = s.SerializeObject<StringID>(fxName, name: "fxName");
			shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
			hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
			faction = s.Serialize<uint>(faction, name: "faction");
			sendStim = s.Serialize<bool>(sendStim, name: "sendStim");
		}
		public override uint? ClassCRC => 0xDABFA0CE;
	}
}

