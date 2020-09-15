using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_SoftCollisionComponent : GraphicComponent {
		public uint MaxParticles;
		public RO2_SoftCollisionSimulation Simulation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			MaxParticles = s.Serialize<uint>(MaxParticles, name: "MaxParticles");
			Simulation = s.SerializeObject<RO2_SoftCollisionSimulation>(Simulation, name: "Simulation");
		}
		public override uint? ClassCRC => 0xF42A2227;
	}
}

