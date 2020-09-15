using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class DataFluid : CSerializable {
		public CList<EdgeFluid> EdgeFluidList;
		public CList<EdgeFluidLevel> EdgeFluidListLevels;
		public bool IsCushion;
		public float WeightMultiplier;
		public CList<FluidFriseLayer> LayerInfos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags10)) {
				EdgeFluidList = s.SerializeObject<CList<EdgeFluid>>(EdgeFluidList, name: "EdgeFluidList");
				EdgeFluidListLevels = s.SerializeObject<CList<EdgeFluidLevel>>(EdgeFluidListLevels, name: "EdgeFluidListLevels");
				IsCushion = s.Serialize<bool>(IsCushion, name: "IsCushion");
				WeightMultiplier = s.Serialize<float>(WeightMultiplier, name: "WeightMultiplier");
				LayerInfos = s.SerializeObject<CList<FluidFriseLayer>>(LayerInfos, name: "LayerInfos");
			}
		}
	}
}

