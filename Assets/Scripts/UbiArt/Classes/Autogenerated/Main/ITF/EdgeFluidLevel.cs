using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EdgeFluidLevel : CSerializable {
		[Serialize("IdEdgeFluid")] public uint IdEdgeFluid;
		[Serialize("Data"       )] public EdgeData Data;
		[Serialize("Xf"         )] public Transform2d Xf;
		[Serialize("Scale"      )] public float Scale;
		[Serialize("LayerInfos" )] public CList<FluidFriseLayer> LayerInfos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(IdEdgeFluid));
			SerializeField(s, nameof(Data));
			SerializeField(s, nameof(Xf));
			SerializeField(s, nameof(Scale));
			SerializeField(s, nameof(LayerInfos));
		}
	}
}

