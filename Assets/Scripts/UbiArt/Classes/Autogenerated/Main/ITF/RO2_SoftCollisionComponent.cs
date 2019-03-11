using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SoftCollisionComponent : GraphicComponent {
		[Serialize("MaxParticles")] public uint MaxParticles;
		[Serialize("Simulation"  )] public RO2_SoftCollisionSimulation Simulation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(MaxParticles));
			SerializeField(s, nameof(Simulation));
		}
		public override uint? ClassCRC => 0xF42A2227;
	}
}

