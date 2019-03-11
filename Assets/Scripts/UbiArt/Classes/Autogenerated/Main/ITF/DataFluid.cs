using UnityEngine;

namespace UbiArt.ITF {
	public partial class DataFluid : CSerializable {
		[Serialize("EdgeFluidList"      )] public CList<EdgeFluid> EdgeFluidList;
		[Serialize("EdgeFluidListLevels")] public CList<EdgeFluidLevel> EdgeFluidListLevels;
		[Serialize("IsCushion"          )] public bool IsCushion;
		[Serialize("WeightMultiplier"   )] public float WeightMultiplier;
		[Serialize("LayerInfos"         )] public CList<FluidFriseLayer> LayerInfos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags10)) {
				SerializeField(s, nameof(EdgeFluidList));
				SerializeField(s, nameof(EdgeFluidListLevels));
				SerializeField(s, nameof(IsCushion));
				SerializeField(s, nameof(WeightMultiplier));
				SerializeField(s, nameof(LayerInfos));
			}
		}
	}
}

